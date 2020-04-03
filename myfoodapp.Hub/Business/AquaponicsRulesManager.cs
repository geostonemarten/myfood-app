using myfoodapp.Hub.Models;
using Newtonsoft.Json;
using SimpleExpressionEvaluator;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web.Hosting;

namespace myfoodapp.Hub.Business
{
    public class AquaponicsRulesManager
    {
        public static bool ValidateRules(GroupedMeasure currentMeasures, int productionUnitId)
        {
            Evaluator evaluator = new Evaluator();
            bool isValid = true;

            ApplicationDbContext db = new ApplicationDbContext();
            ApplicationDbContext dbLog = new ApplicationDbContext();

            var data = File.ReadAllText(HostingEnvironment.MapPath("~/Content/SmartGreenhouseRules.json"));
            var rulesList = JsonConvert.DeserializeObject<List<Rule>>(data);

            var currentProductionUnit = db.ProductionUnits.Include(p => p.owner.language).Where(p => p.Id == productionUnitId).FirstOrDefault();
            var warningEventType = db.EventTypes.Where(p => p.Id == 1).FirstOrDefault();

            var currentProductionUnitOwner = currentProductionUnit.owner;

            foreach (var rule in rulesList)
            {
                var warningContent = String.Empty;
                bool rslt = false;

                try
                {
                    try
                    {
                        rslt = evaluator.Evaluate(rule.ruleEvaluator, currentMeasures);
                        warningContent = rule.warningContent;
                    }
                    catch (Exception ex)
                    {
                        dbLog.Logs.Add(Log.CreateErrorLog(String.Format("Error with Rule Manager Evaluator - {0}", rule.ruleEvaluator), ex));
                        dbLog.SaveChanges();
                    }

                    if (currentProductionUnitOwner != null && currentProductionUnitOwner.language != null)
                    {
                        switch (currentProductionUnitOwner.language.description)
                        {
                            case "fr":
                                warningContent = rule.warningContentFR;
                                break;
                            default:
                                break;
                        }
                    }

                    var bindingValue = currentMeasures.GetType().GetProperty(rule.bindingPropertyValue).GetValue(currentMeasures, null);
                    var message = String.Format(warningContent, bindingValue);

                    if (rslt)
                    {
                            if (currentProductionUnit != null)
                            {
                                db.Events.Add(new Event() { date = DateTime.Now, description = message, isOpen = false, productionUnit = currentProductionUnit, eventType = warningEventType, createdBy = "MyFood Bot" });
                                db.SaveChanges();
                            }

                        isValid = false;
                    }
                }
                catch (Exception ex)
                {
                    dbLog.Logs.Add(Log.CreateErrorLog(String.Format("Error with Rule Manager Evaluator - {0}",rule.ruleEvaluator), ex));
                    dbLog.SaveChanges();
                }
            }

            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                dbLog.Logs.Add(Log.CreateErrorLog(String.Format("Error with Rule Manager - Save Events"), ex));
                dbLog.SaveChanges();
            }

            return isValid;
        }

        public static GroupedMeasure MeasuresProcessor(int productionUnitId)
        {
            var db = new ApplicationDbContext();
            var dbLog = new ApplicationDbContext();

            ProductionUnit currentProductionUnit = db.ProductionUnits.Include(p => p.hydroponicType)
                                                                     .Where(p => p.Id == productionUnitId).FirstOrDefault();

            var phSensor = db.SensorTypes.Where(s => s.Id == 1).FirstOrDefault();
            var waterTemperatureSensor = db.SensorTypes.Where(s => s.Id == 2).FirstOrDefault();
            var dissolvedOxySensor = db.SensorTypes.Where(s => s.Id == 3).FirstOrDefault();
            var ORPSensor = db.SensorTypes.Where(s => s.Id == 4).FirstOrDefault();
            var airTemperatureSensor = db.SensorTypes.Where(s => s.Id == 5).FirstOrDefault();
            var airHumidity = db.SensorTypes.Where(s => s.Id == 6).FirstOrDefault();

            DateTime thisDay = DateTime.Now;
            DateTime lastDay = thisDay.AddDays(-1);
            DateTime twoDaysAgo = thisDay.AddDays(-2);
            DateTime threeDaysAgo = thisDay.AddDays(-3);
            DateTime aWeekAgo = thisDay.AddDays(-7);

            GroupedMeasure currentMeasures = new GroupedMeasure();
            currentMeasures.hydroponicTypeName = currentProductionUnit.hydroponicType.name;

            try
            {
                var currentLastDayMaxPHValue = db.Measures.Where(m => m.captureDate > lastDay &&
                                             m.productionUnit.Id == currentProductionUnit.Id &&
                                             m.sensor.Id == phSensor.Id).OrderBy(m => m.Id).Max(t => t.value);

                var currentLastDayMinPHValue = db.Measures.Where(m => m.captureDate > lastDay &&
                                   m.productionUnit.Id == currentProductionUnit.Id &&
                                   m.sensor.Id == phSensor.Id).OrderBy(m => m.Id).Min(t => t.value);

                var currentTwoDaysMaxPHValue = db.Measures.Where(m => m.captureDate > twoDaysAgo && m.captureDate < lastDay &&
                                   m.productionUnit.Id == currentProductionUnit.Id &&
                                   m.sensor.Id == phSensor.Id).OrderBy(m => m.Id).Max(t => t.value);

                var currentTwoDaysMinPHValue = ((decimal?)db.Measures.Where(m => m.captureDate > twoDaysAgo && m.captureDate < lastDay &&
                                   m.productionUnit.Id == currentProductionUnit.Id &&
                                   m.sensor.Id == phSensor.Id).OrderBy(m => m.Id).Min(t => (decimal?)t.value)).GetValueOrDefault();

                var currentThreeDaysMaxPHValue = ((decimal?)db.Measures.Where(m => m.captureDate > threeDaysAgo && m.captureDate < twoDaysAgo &&
                                   m.productionUnit.Id == currentProductionUnit.Id &&
                                   m.sensor.Id == phSensor.Id).OrderBy(m => m.Id).Max(t => (decimal?)t.value)).GetValueOrDefault();

                var currentThreeDaysMinPHValue = ((decimal?)db.Measures.Where(m => m.captureDate > threeDaysAgo && m.captureDate < twoDaysAgo &&
                                   m.productionUnit.Id == currentProductionUnit.Id &&
                                   m.sensor.Id == phSensor.Id).OrderBy(m => m.Id).Min(t => (decimal?)t.value)).GetValueOrDefault();

                var currentLastWeekMaxPH = db.Measures.Where(m => m.captureDate > aWeekAgo &&
                             m.productionUnit.Id == currentProductionUnit.Id &&
                             m.sensor.Id == phSensor.Id).OrderBy(m => m.Id).Max();

                var currentLastWeekMinPH = db.Measures.Where(m => m.captureDate > aWeekAgo &&
                                             m.productionUnit.Id == currentProductionUnit.Id &&
                                             m.sensor.Id == phSensor.Id).OrderBy(m => m.Id).Min();
                
                currentMeasures.lastWeekMaxPHValue = currentLastDayMaxPHValue;
                currentMeasures.lastWeekMinPHValue = currentLastDayMinPHValue;

                var currentLastWeekMaxPHValue = currentLastWeekMaxPH.value;
                var currentLastWeekMinPHValue = currentLastWeekMinPH.value;

                var currentLastWeekMaxPHDate = currentLastWeekMaxPH.captureDate;
                var currentLastWeekMinPHDate = currentLastWeekMinPH.captureDate;

                if (currentLastWeekMinPHDate < currentLastWeekMaxPHDate)
                    currentMeasures.lastWeekPHRise = true;
                else
                    currentMeasures.lastWeekPHFall = false;

                if (currentLastWeekMinPHDate > currentLastWeekMaxPHDate)
                    currentMeasures.lastWeekPHFall = true;
                else
                    currentMeasures.lastWeekPHRise = false;

                var currentLastWeekAveragePHValue = db.Measures.Where(m => m.captureDate > aWeekAgo &&
                                             m.productionUnit.Id == currentProductionUnit.Id &&
                                             m.sensor.Id == phSensor.Id).OrderBy(m => m.Id).Average(t => t.value);

                currentMeasures.lastWeekPHVariation = Math.Round(Math.Abs(currentLastWeekMaxPHValue - currentLastWeekMinPHValue), 1);
                currentMeasures.threeLastDayPHVariation = Math.Round((Math.Abs(currentLastDayMaxPHValue - currentLastDayMinPHValue) + Math.Abs(currentTwoDaysMaxPHValue - currentTwoDaysMinPHValue) + Math.Abs(currentThreeDaysMaxPHValue - currentThreeDaysMinPHValue)) / 3, 1);
                currentMeasures.lastWeekAveragePHValue = Math.Round(currentLastWeekAveragePHValue, 1);

                var currentLastWeekMaxAirTempValue = ((decimal?)db.Measures.Where(m => m.captureDate > aWeekAgo &&
                                   m.productionUnit.Id == currentProductionUnit.Id &&
                                   m.sensor.Id == airTemperatureSensor.Id).OrderBy(m => m.Id).Max(t => (decimal?)t.value)).GetValueOrDefault();

                var currentLastWeekMinAirTempValue = ((decimal?)db.Measures.Where(m => m.captureDate > aWeekAgo &&
                                   m.productionUnit.Id == currentProductionUnit.Id &&
                                   m.sensor.Id == airTemperatureSensor.Id).OrderBy(m => m.Id).Min(t => (decimal?)t.value)).GetValueOrDefault();

                var currentLastWeekAverageAirTempValue = ((decimal?)db.Measures.Where(m => m.captureDate > aWeekAgo &&
                   m.productionUnit.Id == currentProductionUnit.Id &&
                   m.sensor.Id == airTemperatureSensor.Id).OrderBy(m => m.Id).Sum(t => (decimal?)t.value) / (6 * 24)).GetValueOrDefault();

                currentMeasures.lastWeekMaxAirTempValue = Math.Round(currentLastWeekMaxAirTempValue, 1);
                currentMeasures.lastWeekMinAirTempValue = Math.Round(currentLastWeekMinAirTempValue, 1);
                currentMeasures.lastWeekAverageAirTempValue = Math.Round(currentLastWeekAverageAirTempValue, 1);

                var currentLastWeekMaxWaterTempValue = ((decimal?)db.Measures.Where(m => m.captureDate > aWeekAgo &&
                   m.productionUnit.Id == currentProductionUnit.Id &&
                   m.sensor.Id == waterTemperatureSensor.Id).OrderBy(m => m.Id).Max(t => (decimal?)t.value)).GetValueOrDefault();

                var currentLastWeekMinWaterTempValue = ((decimal?)db.Measures.Where(m => m.captureDate > aWeekAgo &&
                                   m.productionUnit.Id == currentProductionUnit.Id &&
                                   m.sensor.Id == waterTemperatureSensor.Id).OrderBy(m => m.Id).Min(t => (decimal?)t.value)).GetValueOrDefault();

                currentMeasures.lastWeekMaxWaterTempValue = Math.Round(currentLastWeekMaxWaterTempValue, 1);
                currentMeasures.lastWeekMinWaterTempValue = Math.Round(currentLastWeekMinWaterTempValue, 1);

                var currentLastWeekAverageHumidityValue = ((decimal?)db.Measures.Where(m => m.captureDate > aWeekAgo &&
                                   m.productionUnit.Id == currentProductionUnit.Id &&
                                   m.sensor.Id == airHumidity.Id).OrderBy(m => m.Id).Average(t => (decimal?)t.value)).GetValueOrDefault();

                currentMeasures.lastWeekAverageHumidityValue = Math.Round(currentLastWeekAverageHumidityValue, 1);

                var warningEventType = db.EventTypes.Where(p => p.Id == 1).FirstOrDefault();

                var lostSignal = db.Events.Include(ev=> ev.eventType).Where(ev => ev.date > aWeekAgo && ev.eventType.Id == warningEventType.Id && ev.createdBy == "MyFood Bot" &&
                                                   ev.productionUnit.Id == currentProductionUnit.Id && 
                                                  (ev.description.Contains("Déconnectée") || ev.description.Contains("Offine"))).Count();

                currentMeasures.lastWeekLostSignal = lostSignal;

                if (currentProductionUnit.lastMeasureReceived != null)
                    currentMeasures.daysSinceLastSignal = (DateTime.Now - currentProductionUnit.lastMeasureReceived).Value.Days;

                currentMeasures.lastSignalStrenghtReceived = currentProductionUnit.lastSignalStrenghtReceived;
            }
            catch (Exception ex)
            {
                dbLog.Logs.Add(Log.CreateErrorLog("Error on Measures Processing", ex));
                dbLog.SaveChanges();
            }     

            return currentMeasures;
        }
    }

    public class GroupedMeasure
    {
        public Int64 Id { get; set; }
        public decimal? lastWeekMinPHValue { get; set; } = 0;
        public decimal? lastWeekMaxPHValue { get; set; } = 0;
        public decimal? lastWeekPHVariation { get; set; } = 0;
        public bool? lastWeekPHRise { get; set; } = false;
        public bool? lastWeekPHFall { get; set; } = false;
        public decimal? threeLastDayPHVariation { get; set; } = 0;
        public decimal? lastWeekAveragePHValue { get; set; } = 0;
        public decimal? waterTempValue { get; set; } = 0;
        public decimal? lastWeekMinWaterTempValue { get; set; } = 0;
        public decimal? lastWeekMaxWaterTempValue { get; set; } = 0;
        public decimal? lastWeekMinAirTempValue { get; set; } = 0;
        public decimal? lastWeekMaxAirTempValue { get; set; } = 0;
        public decimal? lastWeekAverageAirTempValue { get; set; } = 0;
        public decimal? lastWeekAverageHumidityValue { get; set; } = 0;
        public string hydroponicTypeName { get; set; } = String.Empty;
        public int? lastWeekLostSignal { get; set; } = 0;
        public string lastSignalStrenghtReceived { get; set; } = String.Empty;
        public int? daysSinceLastSignal { get; set; } = 0;
    }
}