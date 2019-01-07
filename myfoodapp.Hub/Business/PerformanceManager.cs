using myfoodapp.Hub.Models;
using myfoodapp.Hub.Models.OpenData;
using myfoodapp.Hub.Services;
using System;
using System.Data.Entity;
using System.Linq;

namespace myfoodapp.Hub.Business
{
    public static class PerformanceManager
    {
        private static int monthlyAverageProductionAerospring = 4;
        private static int monthlyAverageProductionCity = 7;
        private static int monthlyAverageProductionFamilyWithoutBeds = 12;
        private static int monthlyAverageProductionFamilyWithBeds = 15;
        private static int monthlyAverageProductionFarm = 25;

        //CARLSSON-KANYAMA, Annika, et al. "Potential contributions of food consumption patterns to climate change."
        // The American journal of clinical nutrition. 2009, 1704S-1709S
        private static double CO2SparedPerKilogramLocallyProduced = 1.1;

        public static OpenProductionUnitsStatsViewModel GetNetworkStatistic(ApplicationDbContext db)
        {
            MeasureService measureService = new MeasureService(db);

            var rslt = db.ProductionUnits;

            var productionUnitNumber = 0;

            var totalBalcony = rslt.Where(p => p.productionUnitType.Id == 1).Count();

            var totalCity = rslt.Where(p => p.productionUnitType.Id == 2 ||
                                            p.productionUnitType.Id == 12).Count();

            var totalFamilyWithoutBeds = rslt.Where(p => p.productionUnitType.Id == 3 || 
                                                         p.productionUnitType.Id == 4).Count();

            var totalFamilyWithBeds = rslt.Where(p => p.productionUnitType.Id == 8 ||
                                                      p.productionUnitType.Id == 9 ||
                                                      p.productionUnitType.Id == 10||
                                                      p.productionUnitType.Id == 11).Count();

            var totalFarm = rslt.Where(p => p.productionUnitType.Id == 5).Count();

            var totalMonthlyProduction = totalBalcony * monthlyAverageProductionAerospring 
                                           + totalCity * monthlyAverageProductionCity 
                                           + totalFamilyWithoutBeds * monthlyAverageProductionFamilyWithoutBeds
                                           + totalFamilyWithBeds * monthlyAverageProductionFamilyWithoutBeds
                                           + totalFarm * monthlyAverageProductionFarm;

            var totalMonthlySparedCO2 = Math.Round(totalMonthlyProduction * CO2SparedPerKilogramLocallyProduced);

            productionUnitNumber = totalCity + totalFamilyWithoutBeds + totalFamilyWithBeds + totalFarm;

            return new OpenProductionUnitsStatsViewModel() { productionUnitNumber = productionUnitNumber,
                                                             totalMonthlyProduction = totalMonthlyProduction,
                                                             totalMonthlySparedCO2 = totalMonthlySparedCO2
                                                           }; 
        }

        public static int GetEstimatedMonthlyProduction(int productionUnitTypeId)
        {
            var averageMonthlyProduction = 0;

            switch (productionUnitTypeId)
            {
                case 1:
                    //AeroSpring
                    averageMonthlyProduction = monthlyAverageProductionAerospring;
                    break;
                case 2:
                case 12:
                    //City Original & Signature
                    averageMonthlyProduction = monthlyAverageProductionCity;
                    break;
                case 3:
                case 4:
                    //Family14 & Family22 Original
                    averageMonthlyProduction = monthlyAverageProductionFamilyWithoutBeds;
                    break;
                case 8:
                case 9:
                case 10:
                case 11:
                    //Family22 Production -> Signature
                    averageMonthlyProduction = monthlyAverageProductionFamilyWithBeds;
                    break;
                case 5:
                    //Farm
                    averageMonthlyProduction = monthlyAverageProductionFarm;
                    break;
                default:
                    break;
            }

            return averageMonthlyProduction;
        }

        public static double GetEstimatedMonthlySparedCO2(int averageMonthlyProduction)
        {
            return Math.Round(averageMonthlyProduction * CO2SparedPerKilogramLocallyProduced, 0);
        }

        public static decimal GetNetworkScore(ApplicationDbContext db)
        {
            decimal networkScore = 0;

            var upAndRunning = db.ProductionUnits.Where(p => p.productionUnitStatus.Id == 3).Count();

            var lastMeasures = db.Measures.Where(m => m.sensor.Id == 1).OrderByDescending(m => m.captureDate).Take(upAndRunning);

            lastMeasures.ToList().ForEach(m => {
                networkScore += Math.Abs(m.value - 6.8m);
            });

            if (upAndRunning > 0)
                return Math.Round(networkScore, 1);
            else
                return 0;
        }
    }
}