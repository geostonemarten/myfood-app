using System.Collections.Generic;

namespace myfoodapp.Hub.Business
{
    public class GrowingModel
    {
        public string modelName;
        public string type;
        public string options;
        public List<ProductionMonth> productionMonths;
    }

    public class ProductionMonth
    {
        public Months months;
        public List<ProductionArea> productionAreas;
    }

    public class ProductionArea
    {
        public string name;
        public List<ProductionType> productionTypes;
    }

    public class ProductionType
    {
        public string name;
        public List<Slot> slots;
    }


    public class Slot
    {
        public string id;
        public Position position;
        public int number;
        public Vegetable vegetable;

    }

    public class Vegetable
    {
        public string name;
        public int cropPerSlot;
        public GrowingState growingState;
        public decimal productionQuantity;
        public decimal temperatureMin;
        public decimal temperatureMax;
    }

    public enum GrowingState { Seed, Grow, Harvest, Paused };
    public enum Months { January, February, March, April, May, June, July, August, September, October, November, December };
    public enum Position { North, South, Top, Center, Down };

}
