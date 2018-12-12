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
	    public string imagePath;
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
    public enum Months { January=1, February=2, March=3, April=4, May=5, June=6, July=7, August=8, September=9, October=10, November=11, December=12};
    public enum Position { North, South, Top, Center, Down };

}
