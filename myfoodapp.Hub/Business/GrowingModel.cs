﻿using System.Collections.Generic;

namespace myfoodapp.Hub.Business
{
    public class GrowingModel
    {
        public string modelName;
        public string type;
        public string options;
        public List<ProductionMonth> productionMonths;

        private static GrowingState seed = new GrowingState() { Id = 0, name = "[[[Seed]]]" };
        private static GrowingState grow = new GrowingState() { Id = 1, name = "[[[Grow]]]" };
        private static GrowingState harvest = new GrowingState() { Id = 2, name = "[[[Harvest]]]" };
        private static GrowingState paused = new GrowingState() { Id = 3, name = "[[[Paused]]]" };

        private static Month january = new Month() { Id = 0, name = "[[[January]]]" };
        private static Month february = new Month() { Id = 1, name = "[[[February]]]" };
        private static Month march = new Month() { Id = 2, name = "[[[March]]]" };
        private static Month april = new Month() { Id = 3, name = "[[[April]]]" };
        private static Month may = new Month() { Id = 4, name = "[[[May]]]" };
        private static Month june = new Month() { Id = 5, name = "[[[June]]]" };
        private static Month july = new Month() { Id = 6, name = "[[[July]]]" };
        private static Month august = new Month() { Id = 7, name = "[[[August]]]" };
        private static Month september = new Month() { Id = 8, name = "[[[September]]]" };
        private static Month october = new Month() { Id = 9, name = "[[[October]]]" };
        private static Month november = new Month() { Id = 10, name = "[[[November]]]" };
        private static Month december = new Month() { Id = 11, name = "[[[December]]]" };

        private static Position south = new Position() { Id = 0, name = "[[[South]]]" };
        private static Position north = new Position() { Id = 1, name = "[[[North]]]" };
        private static Position top = new Position() { Id = 2, name = "[[[Top]]]" };
        private static Position down = new Position() { Id = 3, name = "[[[Down]]]" };
        private static Position medium = new Position() { Id = 2, name = "[[[Medium]]]" };

        private static Vegetable tomato = new Vegetable() { name = "[[[Tomato]]]", cropPerSlot = 3, imagePath = "tomato.jpg" };
        private static Vegetable lettuce = new Vegetable() { name = "[[[Lettuce]]]", cropPerSlot = 8, imagePath = "lettuce.jpg" };
        private static Vegetable pepper = new Vegetable() { name = "[[[Pepper]]]", cropPerSlot = 4, imagePath = "pepper.jpg" };
        private static Vegetable eggplant = new Vegetable() { name = "[[[Eggplant]]]", cropPerSlot = 3, imagePath = "eggplant.jpg" };
        private static Vegetable cucumber = new Vegetable() { name = "[[[Cucumber]]]", cropPerSlot = 3, imagePath = "cucumber.jpg" };
        private static Vegetable edibleFlower = new Vegetable() { name = "[[[Edible Flower]]]", cropPerSlot = 8, imagePath = "edible-flower.jpg" };
        private static Vegetable kale = new Vegetable() { name = "[[[Kale]]]", cropPerSlot = 4, imagePath = "kale.jpg" };
        private static Vegetable mesclun = new Vegetable() { name = "[[[Mesclun]]]", cropPerSlot = 4, imagePath = "mesclun.jpg" };
        private static Vegetable strawberry = new Vegetable() { name = "[[[Strawberry]]]", cropPerSlot = 8, imagePath = "strawberry.jpg" };
        private static Vegetable purslane = new Vegetable() { name = "[[[Purslane]]]", cropPerSlot = 8, imagePath = "purslane.jpg" };
        private static Vegetable whiteOnion = new Vegetable() { name = "[[[White Onion]]]", cropPerSlot = 15, imagePath = "white-onion.jpg" };
        private static Vegetable leek = new Vegetable() { name = "[[[Leek]]]", cropPerSlot = 30, imagePath = "leek.jpg" };
        private static Vegetable chard = new Vegetable() { name = "[[[Chard]]]", cropPerSlot = 5, imagePath = "chard.jpg" };
        private static Vegetable cabbageCabu = new Vegetable() { name = "[[[Cabbage Cabu]]]", cropPerSlot = 3, imagePath = "cabbage-cabu.jpg" };
        private static Vegetable carrot = new Vegetable() { name = "[[[Carrot]]]", cropPerSlot = 100, imagePath = "carrot.jpg" };
        private static Vegetable turnip = new Vegetable() { name = "[[[Turnip]]]", cropPerSlot = 40, imagePath = "turnip.jpg" };
        private static Vegetable spinach = new Vegetable() { name = "[[[Spinach]]]", cropPerSlot = 12, imagePath = "spinach.jpg" };
        private static Vegetable argulaSalad = new Vegetable() { name = "[[[Argula Salad]]]", cropPerSlot = 4, imagePath = "argula-salad.jpg" };
        private static Vegetable celery = new Vegetable() { name = "[[[Celery]]]", cropPerSlot = 6, imagePath = "celery.jpg" };
        private static Vegetable parsnip = new Vegetable() { name = "[[[Parsnip]]]", cropPerSlot = 40, imagePath = "parsnip.jpg" };
        private static Vegetable blackRadish = new Vegetable() { name = "[[[Black Radish]]]", cropPerSlot = 40, imagePath = "black-radish.jpg" };
        private static Vegetable dwarfBean = new Vegetable() { name = "[[[Dwarf Bean]]]", cropPerSlot = 10, imagePath = "dwarf-bean.jpg" };
        private static Vegetable dwarfPeas = new Vegetable() { name = "[[[Dwarf Peas]]]", cropPerSlot = 10, imagePath = "dwarf-peas.jpg" };
        private static Vegetable beetroot = new Vegetable() { name = "[[[Beetroot]]]", cropPerSlot = 30, imagePath = "beetroot.jpg" };
        private static Vegetable cauliflower = new Vegetable() { name = "[[[Cauliflower]]]", cropPerSlot = 3, imagePath = "cauliflower.jpg" };
        private static Vegetable cabbageRave = new Vegetable() { name = "[[[Cabbage Rave]]]", cropPerSlot = 5, imagePath = "cabbage-rave.jpg" };
        private static Vegetable sweetPotatoes = new Vegetable() { name = "[[[Sweet Potatoes]]]", cropPerSlot = 4, imagePath = "sweet-potatoes.jpg" };
        private static Vegetable broadBean = new Vegetable() { name = "[[[Broad Bean]]]", cropPerSlot = 10, imagePath = "broad-bean.jpg" };
        private static Vegetable fennel = new Vegetable() { name = "[[[Fennel]]]", cropPerSlot = 4, imagePath = "fennel.jpg" };
        private static Vegetable lamblettuce = new Vegetable() { name = "[[[Lamb Lettuce]]]", cropPerSlot = 4, imagePath = "lamb-lettuce.jpg" };
        private static Vegetable zucchini = new Vegetable() { name = "[[[Zucchini]]]", cropPerSlot = 2, imagePath = "zucchini.jpg" };
        private static Vegetable cabbageBruxelles = new Vegetable() { name = "[[[Cabbage Bruxelles]]]", cropPerSlot = 2, imagePath = "cabbage-bruxelles.jpg" };


        public void GenerateModel()
        {
            var model = new GrowingModel();
            model.modelName = "Family22 Annual Planning v.1";
            model.type = "Family22";
            model.options = "36 x Zipgrow Towers | 5 x Perma Beds | 1 x Aerospring";

            List<ProductionMonth> productionMonths = new List<ProductionMonth>();

            var february = GetFebruary();
            var mars = GetMarch();
            var april = GetApril();

            productionMonths.Add(february);
            productionMonths.Add(mars);
            productionMonths.Add(april);

            model.productionMonths = new List<ProductionMonth>();
            model.productionMonths = productionMonths;
        }

        private static ProductionMonth GetFebruary()
        {
            List<ProductionArea> productionAreas;
            List<ProductionType> productionTypes;

            ProductionArea indoorProductionArea;
            ProductionType aquaponicProductionType, permacultureProductionType, aerospringProductionType;
            ProductionMonth currentMonth;

            productionAreas = new List<ProductionArea>();
            productionTypes = new List<ProductionType>();

            var aquaponicSlots = new List<Slot>();
            var permaSlots = new List<Slot>();
            var aeroSlots = new List<Slot>();

            indoorProductionArea = new ProductionArea();
            indoorProductionArea.name = "[[[Indoor]]]";

            aquaponicProductionType = new ProductionType();
            aquaponicProductionType.name = "[[[Aquaponics]]]";

            permacultureProductionType = new ProductionType();
            permacultureProductionType.name = "[[[Perma Beds]]]";

            aerospringProductionType = new ProductionType();
            aerospringProductionType.name = "[[[Aerospring]]]";

            currentMonth = new ProductionMonth();
            currentMonth.month = february;

            lettuce.growingState = harvest;
            lettuce.productionQuantity = 180;

            kale.growingState = harvest;
            kale.productionQuantity = 180;

            mesclun.growingState = harvest;
            mesclun.productionQuantity = 180;

            purslane.growingState = harvest;
            purslane.productionQuantity = 100;

            leek.growingState = grow;
            leek.productionQuantity = 0;

            cabbageCabu.growingState = harvest;
            cabbageCabu.productionQuantity = 1500;

            chard.growingState = harvest;
            chard.productionQuantity = 200;

            spinach.growingState = harvest;
            spinach.productionQuantity = 180;

            chard.growingState = harvest;
            chard.productionQuantity = 200;

            argulaSalad.growingState = harvest;
            argulaSalad.productionQuantity = 200;

            cabbageRave.growingState = harvest;
            cabbageRave.productionQuantity = 250;

            cauliflower.growingState = harvest;
            cauliflower.productionQuantity = 1000;

            whiteOnion.growingState = harvest;
            whiteOnion.productionQuantity = 40;

            blackRadish.growingState = seed;
            blackRadish.productionQuantity = 0;

            fennel.growingState = harvest;
            fennel.productionQuantity = 300;

            //AQUAPONICS SLOTS

            var slot_aqua_1 = new Slot();
            slot_aqua_1.id = "[[[Zipgrow Tower]]] #1";
            slot_aqua_1.number = 6;
            slot_aqua_1.position = south;
            slot_aqua_1.vegetable = lettuce;

            var slot_aqua_2 = new Slot();
            slot_aqua_2.id = "[[[Zipgrow Tower]]] #2";
            slot_aqua_2.number = 3;
            slot_aqua_2.position = south;
            slot_aqua_2.vegetable = lettuce;

            var slot_aqua_3 = new Slot();
            slot_aqua_3.id = "[[[Zipgrow Tower]]] #3";
            slot_aqua_3.number = 3;
            slot_aqua_3.position = north;
            slot_aqua_3.vegetable = lettuce;

            var slot_aqua_4 = new Slot();
            slot_aqua_4.id = "[[[Zipgrow Tower]]] #4";
            slot_aqua_4.number = 3;
            slot_aqua_4.position = north;
            slot_aqua_4.vegetable = kale;

            var slot_aqua_5 = new Slot();
            slot_aqua_5.id = "[[[Zipgrow Tower]]] #5";
            slot_aqua_5.number = 3;
            slot_aqua_5.position = north;
            slot_aqua_5.vegetable = mesclun;

            var slot_aqua_6 = new Slot();
            slot_aqua_6.id = "[[[Zipgrow Tower]]] #6";
            slot_aqua_6.number = 3;
            slot_aqua_6.position = north;
            slot_aqua_6.vegetable = purslane;

            var slot_aqua_7 = new Slot();
            slot_aqua_7.id = "[[[Zipgrow Tower]]] #7";
            slot_aqua_7.number = 3;
            slot_aqua_7.position = north;
            slot_aqua_7.vegetable = whiteOnion;

            aquaponicSlots.Add(slot_aqua_1);
            aquaponicSlots.Add(slot_aqua_2);
            aquaponicSlots.Add(slot_aqua_3);
            aquaponicSlots.Add(slot_aqua_4);
            aquaponicSlots.Add(slot_aqua_5);
            aquaponicSlots.Add(slot_aqua_6);
            aquaponicSlots.Add(slot_aqua_7);
            aquaponicProductionType.slots = aquaponicSlots;

            //PERMA SLOTS

            var slot_perma_1 = new Slot();
            slot_perma_1.id = "[[[Perma Bed #1 [[[Slot]]] #1";
            slot_perma_1.number = 3;
            slot_perma_1.position = top;
            slot_perma_1.vegetable = leek;

            var slot_perma_2 = new Slot();
            slot_perma_2.id = "[[[Perma Bed #1 [[[Slot]]] #2";
            slot_perma_2.number = 3;
            slot_perma_2.position = medium;
            slot_perma_2.vegetable = cabbageCabu;

            var slot_perma_3 = new Slot();
            slot_perma_3.id = "[[[Perma Bed #1 [[[Slot]]] #3";
            slot_perma_3.number = 3;
            slot_perma_3.position = down;
            slot_perma_3.vegetable = chard;

            var slot_perma_4 = new Slot();
            slot_perma_4.id = "[[[Perma Bed #2 [[[Slot]]] #1";
            slot_perma_4.number = 3;
            slot_perma_4.position = top;
            slot_perma_4.vegetable = spinach;

            var slot_perma_5 = new Slot();
            slot_perma_5.id = "[[[Perma Bed #2 [[[Slot]]] #2";
            slot_perma_5.number = 3;
            slot_perma_5.position = medium;
            slot_perma_5.vegetable = cabbageBruxelles;

            var slot_perma_6 = new Slot();
            slot_perma_6.id = "[[[Perma Bed #2 [[[Slot]]] #3";
            slot_perma_6.number = 3;
            slot_perma_6.position = down;
            slot_perma_6.vegetable = beetroot;

            //var slot_perma_7 = new Slot();
            //slot_perma_7.id = "[[[Perma Bed]]] #3 [[[Slot]]] #1";
            //slot_perma_7.number = 3;
            //slot_perma_7.position = top;
            //slot_perma_7.vegetable = tomato;

            var slot_perma_8 = new Slot();
            slot_perma_8.id = "[[[Perma Bed]]] #3 [[[Slot]]] #2";
            slot_perma_8.number = 3;
            slot_perma_8.position = medium;
            slot_perma_8.vegetable = cabbageRave;

            var slot_perma_9 = new Slot();
            slot_perma_9.id = "[[[Perma Bed]]] #3 [[[Slot]]] #3";
            slot_perma_9.number = 3;
            slot_perma_9.position = down;
            slot_perma_9.vegetable = cauliflower;

            var slot_perma_10 = new Slot();
            slot_perma_10.id = "[[[Perma Bed]]] #4 [[[Slot]]] #2";
            slot_perma_10.number = 3;
            slot_perma_10.position = medium;
            slot_perma_10.vegetable = whiteOnion;

            var slot_perma_11 = new Slot();
            slot_perma_11.id = "[[[Perma Bed]]] #4 [[[Slot]]] #3";
            slot_perma_11.number = 3;
            slot_perma_11.position = down;
            slot_perma_11.vegetable = whiteOnion;

            var slot_perma_12 = new Slot();
            slot_perma_12.id = "[[[Perma Bed]]] #5 [[[Slot]]] #1";
            slot_perma_12.number = 3;
            slot_perma_12.position = top;
            slot_perma_12.vegetable = chard;

            var slot_perma_13 = new Slot();
            slot_perma_13.id = "[[[Perma Bed]]] #5 [[[Slot]]] #2";
            slot_perma_13.number = 3;
            slot_perma_13.position = medium;
            slot_perma_13.vegetable = fennel;

            var slot_perma_14 = new Slot();
            slot_perma_14.id = "[[[Perma Bed]]] #5 [[[Slot]]] #3";
            slot_perma_14.number = 3;
            slot_perma_14.position = down;
            slot_perma_14.vegetable = zucchini;

            //slots.Add(slot_perma_7);
            permaSlots.Add(slot_perma_8);
            permaSlots.Add(slot_perma_9);
            permaSlots.Add(slot_perma_10);
            permaSlots.Add(slot_perma_11);
            permaSlots.Add(slot_perma_12);
            permaSlots.Add(slot_perma_13);
            permaSlots.Add(slot_perma_14);
            permacultureProductionType.slots = permaSlots;

            //AEROSPRING SLOTS

            var slot_aero_1 = new Slot();
            slot_aero_1.id = "[[[Aerospring]]] #1";
            slot_aero_1.number = 12;
            slot_aero_1.position = down;
            slot_aero_1.vegetable = lettuce;
            slot_aero_1.oneCropPerSlot = true;

            var slot_aero_2 = new Slot();
            slot_aero_2.id = "[[[Aerospring]]] #2";
            slot_aero_2.number = 4;
            slot_aero_2.position = south;
            slot_aero_2.vegetable = cabbageRave;
            slot_aero_2.oneCropPerSlot = true;

            var slot_aero_3 = new Slot();
            slot_aero_3.id = "[[[Aerospring]]] #3";
            slot_aero_3.number = 4;
            slot_aero_3.position = north;
            slot_aero_3.vegetable = purslane;
            slot_aero_3.oneCropPerSlot = true;

            var slot_aero_4 = new Slot();
            slot_aero_4.id = "[[[Aerospring]]] #4";
            slot_aero_4.number = 2;
            slot_aero_4.position = north;
            slot_aero_4.vegetable = kale;
            slot_aero_4.oneCropPerSlot = true;

            var slot_aero_5 = new Slot();
            slot_aero_5.id = "[[[Aerospring]]] #5";
            slot_aero_5.number = 2;
            slot_aero_5.position = north;
            slot_aero_5.vegetable = mesclun;
            slot_aero_5.oneCropPerSlot = true;

            var slot_aero_6 = new Slot();
            slot_aero_6.id = "[[[Aerospring]]] #6";
            slot_aero_6.number = 2;
            slot_aero_6.position = north;
            slot_aero_6.vegetable = purslane;
            slot_aero_6.oneCropPerSlot = true;

            var slot_aero_7 = new Slot();
            slot_aero_7.id = "[[[Aerospring]]] #7";
            slot_aero_7.number = 2;
            slot_aero_7.position = north;
            slot_aero_7.vegetable = whiteOnion;
            slot_aero_7.oneCropPerSlot = true;

            var slot_aero_8 = new Slot();
            slot_aero_8.id = "[[[Aerospring]]] #8";
            slot_aero_8.number = 2;
            slot_aero_8.position = north;
            slot_aero_8.vegetable = kale;
            slot_aero_8.oneCropPerSlot = true;

            var slot_aero_9 = new Slot();
            slot_aero_9.id = "[[[Aerospring]]] #9";
            slot_aero_9.number = 2;
            slot_aero_9.position = north;
            slot_aero_9.vegetable = mesclun;
            slot_aero_9.oneCropPerSlot = true;

            var slot_aero_10 = new Slot();
            slot_aero_10.id = "[[[Aerospring]]] #10";
            slot_aero_10.number = 2;
            slot_aero_10.position = north;
            slot_aero_10.vegetable = purslane;
            slot_aero_10.oneCropPerSlot = true;

            var slot_aero_11 = new Slot();
            slot_aero_11.id = "[[[Aerospring]]] #11";
            slot_aero_11.number = 2;
            slot_aero_11.position = north;
            slot_aero_11.vegetable = whiteOnion;
            slot_aero_11.oneCropPerSlot = true;

            aeroSlots.Add(slot_aero_1);
            aeroSlots.Add(slot_aero_2);
            aeroSlots.Add(slot_aero_3);
            aeroSlots.Add(slot_aero_4);
            aeroSlots.Add(slot_aero_5);
            aeroSlots.Add(slot_aero_6);
            aeroSlots.Add(slot_aero_7);
            aeroSlots.Add(slot_aero_8);
            aeroSlots.Add(slot_aero_9);
            aeroSlots.Add(slot_aero_10);
            aeroSlots.Add(slot_aero_11);
            aerospringProductionType.slots = aeroSlots;

            productionTypes.Add(aquaponicProductionType);
            productionTypes.Add(permacultureProductionType);
            productionTypes.Add(aerospringProductionType);
            indoorProductionArea.productionTypes = productionTypes;

            productionAreas.Add(indoorProductionArea);
            currentMonth.productionAreas = productionAreas;

            return currentMonth;
        }

        private static ProductionMonth GetMarch()
        {
            List<ProductionArea> productionAreas;
            List<ProductionType> productionTypes;

            ProductionArea indoorProductionArea;
            ProductionType aquaponicProductionType, permacultureProductionType, aerospringProductionType;
            ProductionMonth currentMonth;

            productionAreas = new List<ProductionArea>();
            productionTypes = new List<ProductionType>();

            var aquaponicSlots = new List<Slot>();
            var permaSlots = new List<Slot>();
            var aeroSlots = new List<Slot>();

            indoorProductionArea = new ProductionArea();
            indoorProductionArea.name = "[[[Indoor]]]";

            aquaponicProductionType = new ProductionType();
            aquaponicProductionType.name = "[[[Aquaponics]]]";

            permacultureProductionType = new ProductionType();
            permacultureProductionType.name = "[[[Perma Beds]]]";

            aerospringProductionType = new ProductionType();
            aerospringProductionType.name = "[[[Aerospring]]]";

            currentMonth = new ProductionMonth();
            currentMonth.month = march;

            tomato.growingState = seed;
            tomato.productionQuantity = 0;

            pepper.growingState = seed;
            pepper.productionQuantity = 0;

            eggplant.growingState = seed;
            eggplant.productionQuantity = 0;

            cucumber.growingState = seed;
            cucumber.productionQuantity = 0;

            edibleFlower.growingState = seed;
            edibleFlower.productionQuantity = 0;

            strawberry.growingState = seed;
            strawberry.productionQuantity = 0;

            leek.growingState = harvest;
            leek.productionQuantity = 75;

            blackRadish.growingState = harvest;
            blackRadish.productionQuantity = 300;

            chard.growingState = harvest;
            chard.productionQuantity = 200;

            dwarfBean.growingState = seed;
            chard.productionQuantity = 0;

            dwarfPeas.growingState = seed;
            dwarfPeas.productionQuantity = 0;

            beetroot.growingState = seed;
            beetroot.productionQuantity = 0;

            cabbageRave.growingState = harvest;
            cabbageRave.productionQuantity = 250;

            whiteOnion.growingState = harvest;
            whiteOnion.productionQuantity = 10;

            fennel.growingState = harvest;
            fennel.productionQuantity = 150;

            zucchini.growingState = seed;
            zucchini.productionQuantity = 0;

            // AQUAPONICS SLOTS

            var slot_aqua_1 = new Slot();
            slot_aqua_1.id = "[[[Zipgrow Tower]]] #1";
            slot_aqua_1.number = 6;
            slot_aqua_1.position = south;
            slot_aqua_1.vegetable = tomato;

            var slot_aqua_2 = new Slot();
            slot_aqua_2.id = "[[[Zipgrow Tower]]] #2";
            slot_aqua_2.number = 3;
            slot_aqua_2.position = south;
            slot_aqua_2.vegetable = pepper;

            var slot_aqua_3 = new Slot();
            slot_aqua_3.id = "[[[Zipgrow Tower]]] #3";
            slot_aqua_3.number = 3;
            slot_aqua_3.position = north;
            slot_aqua_3.vegetable = eggplant;

            var slot_aqua_4 = new Slot();
            slot_aqua_4.id = "[[[Zipgrow Tower]]] #4";
            slot_aqua_4.number = 3;
            slot_aqua_4.position = north;
            slot_aqua_4.vegetable = cucumber;

            var slot_aqua_5 = new Slot();
            slot_aqua_5.id = "[[[Zipgrow Tower]]] #5";
            slot_aqua_5.number = 3;
            slot_aqua_5.position = north;
            slot_aqua_5.vegetable = edibleFlower;

            var slot_aqua_6 = new Slot();
            slot_aqua_6.id = "[[[Zipgrow Tower]]] #6";
            slot_aqua_6.number = 3;
            slot_aqua_6.position = north;
            slot_aqua_6.vegetable = strawberry;

            var slot_aqua_7 = new Slot();
            slot_aqua_7.id = "[[[Zipgrow Tower]]] #7";
            slot_aqua_7.number = 3;
            slot_aqua_7.position = north;
            slot_aqua_7.vegetable = strawberry;

            aquaponicSlots.Add(slot_aqua_1);
            aquaponicSlots.Add(slot_aqua_2);
            aquaponicSlots.Add(slot_aqua_3);
            aquaponicSlots.Add(slot_aqua_4);
            aquaponicSlots.Add(slot_aqua_5);
            aquaponicSlots.Add(slot_aqua_6);
            aquaponicSlots.Add(slot_aqua_7);
            aquaponicProductionType.slots = aquaponicSlots;

            //PERMA SLOTS

            var slot_perma_1 = new Slot();
            slot_perma_1.id = "[[[Perma Bed]]] #1 [[[Slot]]] #1";
            slot_perma_1.number = 3;
            slot_perma_1.position = top;
            slot_perma_1.vegetable = leek;

            var slot_perma_2 = new Slot();
            slot_perma_2.id = "[[[Perma Bed]]] #1 [[[Slot]]] #2";
            slot_perma_2.number = 3;
            slot_perma_2.position = medium;
            slot_perma_2.vegetable = chard;

            var slot_perma_3 = new Slot();
            slot_perma_3.id = "[[[Perma Bed]]] #1 [[[Slot]]] #3";
            slot_perma_3.number = 3;
            slot_perma_3.position = down;
            slot_perma_3.vegetable = blackRadish;

            var slot_perma_4 = new Slot();
            slot_perma_4.id = "[[[Perma Bed]]] #2 [[[Slot]]] #1";
            slot_perma_4.number = 3;
            slot_perma_4.position = top;
            slot_perma_4.vegetable = dwarfBean;

            var slot_perma_5 = new Slot();
            slot_perma_5.id = "[[[Perma Bed]]] #2 [[[Slot]]] #2";
            slot_perma_5.number = 3;
            slot_perma_5.position = medium;
            slot_perma_5.vegetable = cabbageBruxelles;

            var slot_perma_6 = new Slot();
            slot_perma_6.id = "[[[Perma Bed]]] #2 [[[Slot]]] #3";
            slot_perma_6.number = 3;
            slot_perma_6.position = down;
            slot_perma_6.vegetable = beetroot;

            var slot_perma_7 = new Slot();
            slot_perma_7.id = "[[[Perma Bed]]] #3 [[[Slot]]] #1";
            slot_perma_7.number = 3;
            slot_perma_7.position = top;
            slot_perma_7.vegetable = tomato;

            var slot_perma_8 = new Slot();
            slot_perma_8.id = "[[[Perma Bed]]] #3 [[[Slot]]] #2";
            slot_perma_8.number = 3;
            slot_perma_8.position = medium;
            slot_perma_8.vegetable = cabbageRave;

            var slot_perma_9 = new Slot();
            slot_perma_9.id = "[[[Perma Bed]]] #4 [[[Slot]]] #2";
            slot_perma_9.number = 3;
            slot_perma_9.position = medium;
            slot_perma_9.vegetable = whiteOnion;

            var slot_perma_10 = new Slot();
            slot_perma_10.id = "[[[Perma Bed]]] #4 [[[Slot]]] #3";
            slot_perma_10.number = 3;
            slot_perma_10.position = down;
            slot_perma_10.vegetable = whiteOnion;

            var slot_perma_11 = new Slot();
            slot_perma_11.id = "[[[Perma Bed]]] #5 [[[Slot]]] #1";
            slot_perma_11.number = 3;
            slot_perma_11.position = top;
            slot_perma_11.vegetable = chard;

            var slot_perma_12 = new Slot();
            slot_perma_12.id = "[[[Perma Bed]]] #5 [[[Slot]]] #2";
            slot_perma_12.number = 3;
            slot_perma_12.position = medium;
            slot_perma_12.vegetable = fennel;

            var slot_perma_13 = new Slot();
            slot_perma_13.id = "[[[Perma Bed]]] #5 [[[Slot]]] #3";
            slot_perma_13.number = 3;
            slot_perma_13.position = down;
            slot_perma_13.vegetable = zucchini;

            permaSlots.Add(slot_perma_7);
            permaSlots.Add(slot_perma_8);
            permaSlots.Add(slot_perma_9);
            permaSlots.Add(slot_perma_10);
            permaSlots.Add(slot_perma_11);
            permaSlots.Add(slot_perma_12);
            permaSlots.Add(slot_perma_13);
            permacultureProductionType.slots = permaSlots;

            //AEROSPRING SLOTS

            var slot_aero_1 = new Slot();
            slot_aero_1.id = "[[[Aerospring]]] #1";
            slot_aero_1.number = 12;
            slot_aero_1.position = down;
            slot_aero_1.vegetable = lettuce;
            slot_aero_1.oneCropPerSlot = true;

            var slot_aero_2 = new Slot();
            slot_aero_2.id = "[[[Aerospring]]] #2";
            slot_aero_2.number = 4;
            slot_aero_2.position = south;
            slot_aero_2.vegetable = cabbageRave;
            slot_aero_2.oneCropPerSlot = true;

            var slot_aero_3 = new Slot();
            slot_aero_3.id = "[[[Aerospring]]] #3";
            slot_aero_3.number = 4;
            slot_aero_3.position = north;
            slot_aero_3.vegetable = purslane;
            slot_aero_3.oneCropPerSlot = true;

            var slot_aero_4 = new Slot();
            slot_aero_4.id = "[[[Aerospring]]] #4";
            slot_aero_4.number = 2;
            slot_aero_4.position = north;
            slot_aero_4.vegetable = kale;
            slot_aero_4.oneCropPerSlot = true;

            var slot_aero_5 = new Slot();
            slot_aero_5.id = "[[[Aerospring]]] #5";
            slot_aero_5.number = 2;
            slot_aero_5.position = north;
            slot_aero_5.vegetable = mesclun;
            slot_aero_5.oneCropPerSlot = true;

            var slot_aero_6 = new Slot();
            slot_aero_6.id = "[[[Aerospring]]] #6";
            slot_aero_6.number = 2;
            slot_aero_6.position = north;
            slot_aero_6.vegetable = purslane;
            slot_aero_6.oneCropPerSlot = true;

            var slot_aero_7 = new Slot();
            slot_aero_7.id = "[[[Aerospring]]] #7";
            slot_aero_7.number = 2;
            slot_aero_7.position = north;
            slot_aero_7.vegetable = whiteOnion;
            slot_aero_7.oneCropPerSlot = true;

            var slot_aero_8 = new Slot();
            slot_aero_8.id = "[[[Aerospring]]] #8";
            slot_aero_8.number = 2;
            slot_aero_8.position = north;
            slot_aero_8.vegetable = kale;
            slot_aero_8.oneCropPerSlot = true;

            var slot_aero_9 = new Slot();
            slot_aero_9.id = "[[[Aerospring]]] #9";
            slot_aero_9.number = 2;
            slot_aero_9.position = north;
            slot_aero_9.vegetable = mesclun;
            slot_aero_9.oneCropPerSlot = true;

            var slot_aero_10 = new Slot();
            slot_aero_10.id = "[[[Aerospring]]] #10";
            slot_aero_10.number = 2;
            slot_aero_10.position = north;
            slot_aero_10.vegetable = purslane;
            slot_aero_10.oneCropPerSlot = true;

            var slot_aero_11 = new Slot();
            slot_aero_11.id = "[[[Aerospring]]] #11";
            slot_aero_11.number = 2;
            slot_aero_11.position = north;
            slot_aero_11.vegetable = whiteOnion;
            slot_aero_11.oneCropPerSlot = true;

            aeroSlots.Add(slot_aero_1);
            aeroSlots.Add(slot_aero_2);
            aeroSlots.Add(slot_aero_3);
            aeroSlots.Add(slot_aero_4);
            aeroSlots.Add(slot_aero_5);
            aeroSlots.Add(slot_aero_6);
            aeroSlots.Add(slot_aero_7);
            aeroSlots.Add(slot_aero_8);
            aeroSlots.Add(slot_aero_9);
            aeroSlots.Add(slot_aero_10);
            aeroSlots.Add(slot_aero_11);
            aerospringProductionType.slots = aeroSlots;

            productionTypes.Add(aquaponicProductionType);
            productionTypes.Add(permacultureProductionType);
            productionTypes.Add(aerospringProductionType);
            indoorProductionArea.productionTypes = productionTypes;

            productionAreas.Add(indoorProductionArea);
            currentMonth.productionAreas = productionAreas;

            return currentMonth;
        }

        private static ProductionMonth GetApril()
        {
            List<ProductionArea> productionAreas;
            List<ProductionType> productionTypes;

            ProductionArea indoorProductionArea;
            ProductionType aquaponicProductionType, permacultureProductionType, aerospringProductionType;
            ProductionMonth currentMonth;

            productionAreas = new List<ProductionArea>();
            productionTypes = new List<ProductionType>();

            var aquaponicSlots = new List<Slot>();
            var permaSlots = new List<Slot>();
            var aeroSlots = new List<Slot>();

            indoorProductionArea = new ProductionArea();
            indoorProductionArea.name = "[[[Indoor]]]";

            aquaponicProductionType = new ProductionType();
            aquaponicProductionType.name = "[[[Aquaponics]]]";

            permacultureProductionType = new ProductionType();
            permacultureProductionType.name = "[[[Perma Beds]]]";

            aerospringProductionType = new ProductionType();
            aerospringProductionType.name = "[[[Aerospring]]]";

            currentMonth = new ProductionMonth();
            currentMonth.month = april;

            tomato.growingState = grow;
            tomato.productionQuantity = 0;

            pepper.growingState = grow;
            pepper.productionQuantity = 0;

            eggplant.growingState = grow;
            eggplant.productionQuantity = 0;

            cucumber.growingState = grow;
            cucumber.productionQuantity = 0;

            edibleFlower.growingState = grow;
            edibleFlower.productionQuantity = 0;

            strawberry.growingState = grow;
            strawberry.productionQuantity = 0;

            leek.growingState = harvest;
            leek.productionQuantity = 75;

            parsnip.growingState = seed;
            parsnip.productionQuantity = 0;

            //chard.growingState = harvest;
            //chard.productionQuantity = 200;

            dwarfBean.growingState = harvest;
            chard.productionQuantity = 25;

            dwarfPeas.growingState = harvest;
            dwarfPeas.productionQuantity = 25;

            beetroot.growingState = grow;
            beetroot.productionQuantity = 0;

            sweetPotatoes.growingState = seed;
            sweetPotatoes.productionQuantity = 0;

            broadBean.growingState = seed;
            broadBean.productionQuantity = 0;

            //whiteOnion.growingState = harvest;
            //whiteOnion.productionQuantity = 10;

            //whiteOnion.growingState = harvest;
            //whiteOnion.productionQuantity = 10;

            //fennel.growingState = harvest;
            //fennel.productionQuantity = 150;

            zucchini.growingState = harvest;
            zucchini.productionQuantity = 500;

            //AQUAPONICS SLOTS

            var slot_aqua_1 = new Slot();
            slot_aqua_1.id = "[[[Zipgrow Tower]]] #1";
            slot_aqua_1.number = 6;
            slot_aqua_1.position = south;
            slot_aqua_1.vegetable = tomato;

            var slot_aqua_2 = new Slot();
            slot_aqua_2.id = "[[[Zipgrow Tower]]] #2";
            slot_aqua_2.number = 3;
            slot_aqua_2.position = south;
            slot_aqua_2.vegetable = pepper;

            var slot_aqua_3 = new Slot();
            slot_aqua_3.id = "[[[Zipgrow Tower]]] #3";
            slot_aqua_3.number = 3;
            slot_aqua_3.position = north;
            slot_aqua_3.vegetable = eggplant;

            var slot_aqua_4 = new Slot();
            slot_aqua_4.id = "[[[Zipgrow Tower]]] #4";
            slot_aqua_4.number = 3;
            slot_aqua_4.position = north;
            slot_aqua_4.vegetable = cucumber;

            var slot_aqua_5 = new Slot();
            slot_aqua_5.id = "[[[Zipgrow Tower]]] #5";
            slot_aqua_5.number = 3;
            slot_aqua_5.position = north;
            slot_aqua_5.vegetable = edibleFlower;

            var slot_aqua_6 = new Slot();
            slot_aqua_6.id = "[[[Zipgrow Tower]]] #6";
            slot_aqua_6.number = 3;
            slot_aqua_6.position = north;
            slot_aqua_6.vegetable = strawberry;

            var slot_aqua_7 = new Slot();
            slot_aqua_7.id = "[[[Zipgrow Tower]]] #7";
            slot_aqua_7.number = 3;
            slot_aqua_7.position = north;
            slot_aqua_7.vegetable = strawberry;

            aquaponicSlots.Add(slot_aqua_1);
            aquaponicSlots.Add(slot_aqua_2);
            aquaponicSlots.Add(slot_aqua_3);
            aquaponicSlots.Add(slot_aqua_4);
            aquaponicSlots.Add(slot_aqua_5);
            aquaponicSlots.Add(slot_aqua_6);
            aquaponicSlots.Add(slot_aqua_7);
            aquaponicProductionType.slots = aquaponicSlots;

            //PERMA SLOTS

            var slot_perma_1 = new Slot();
            slot_perma_1.id = "[[[Perma Bed]]] #1 [[[Slot]]] #1";
            slot_perma_1.number = 3;
            slot_perma_1.position = top;
            slot_perma_1.vegetable = leek;

            var slot_perma_2 = new Slot();
            slot_perma_2.id = "[[[Perma Bed]]] #1 [[[Slot]]] #2";
            slot_perma_2.number = 3;
            slot_perma_2.position = medium;
            slot_perma_2.vegetable = chard;

            //var slot_perma_3 = new Slot();
            //slot_perma_3.id = "[[[Perma Bed]]] #1 [[[Slot]]] #3";
            //slot_perma_3.number = 3;
            //slot_perma_3.position = down;
            //slot_perma_3.vegetable = blackRadish;

            var slot_perma_4 = new Slot();
            slot_perma_4.id = "[[[Perma Bed]]] #2 [[[Slot]]] #1";
            slot_perma_4.number = 3;
            slot_perma_4.position = top;
            slot_perma_4.vegetable = dwarfBean;

            var slot_perma_5 = new Slot();
            slot_perma_5.id = "[[[Perma Bed]]] #2 [[[Slot]]] #2";
            slot_perma_5.number = 3;
            slot_perma_5.position = medium;
            slot_perma_5.vegetable = cabbageBruxelles;

            var slot_perma_6 = new Slot();
            slot_perma_6.id = "[[[Perma Bed]]] #2 [[[Slot]]] #3";
            slot_perma_6.number = 3;
            slot_perma_6.position = down;
            slot_perma_6.vegetable = sweetPotatoes;

            var slot_perma_7 = new Slot();
            slot_perma_7.id = "[[[Perma Bed]]] #3 [[[Slot]]] #1";
            slot_perma_7.number = 3;
            slot_perma_7.position = top;
            slot_perma_7.vegetable = tomato;

            var slot_perma_8 = new Slot();
            slot_perma_8.id = "[[[Perma Bed]]] #3 [[[Slot]]] #2";
            slot_perma_8.number = 3;
            slot_perma_8.position = medium;
            slot_perma_8.vegetable = cabbageRave;

            var slot_perma_9 = new Slot();
            slot_perma_9.id = "[[[Perma Bed]]] #4 [[[Slot]]] #1";
            slot_perma_9.number = 3;
            slot_perma_9.position = top;
            slot_perma_9.vegetable = broadBean;

            //var slot_perma_10 = new Slot();
            //slot_perma_10.id = "[[[Perma Bed]]] #4 [[[Slot]]] #2";
            //slot_perma_10.number = 3;
            //slot_perma_10.position = medium;
            //slot_perma_10.vegetable = whiteOnion;

            //var slot_perma_11 = new Slot();
            //slot_perma_11.id = "[[[Perma Bed]]] #4 [[[Slot]]] #3";
            //slot_perma_11.number = 3;
            //slot_perma_11.position = down;
            //slot_perma_11.vegetable = whiteOnion;

            //var slot_perma_12 = new Slot();
            //slot_perma_12.id = "[[[Perma Bed]]] #5 [[[Slot]]] #1";
            //slot_perma_12.number = 3;
            //slot_perma_12.position = top;
            //slot_perma_12.vegetable = chard;

            //var slot_perma_13 = new Slot();
            //slot_perma_13.id = "[[[Perma Bed]]] #5 [[[Slot]]] #2";
            //slot_perma_13.number = 3;
            //slot_perma_13.position = medium;
            //slot_perma_13.vegetable = fennel;

            var slot_perma_14 = new Slot();
            slot_perma_14.id = "[[[Perma Bed]]] #5 [[[Slot]]] #3";
            slot_perma_14.number = 3;
            slot_perma_14.position = down;
            slot_perma_14.vegetable = zucchini;

            permaSlots.Add(slot_perma_7);
            permaSlots.Add(slot_perma_8);
            permaSlots.Add(slot_perma_9);
            //slots.Add(slot_perma_10);
            //slots.Add(slot_perma_11);
            //slots.Add(slot_perma_12);
            //slots.Add(slot_perma_13);
            permaSlots.Add(slot_perma_14);
            permacultureProductionType.slots = permaSlots;

            //AEROSPRING SLOTS

            var slot_aero_1 = new Slot();
            slot_aero_1.id = "[[[Aerospring]]] #1";
            slot_aero_1.number = 12;
            slot_aero_1.position = down;
            slot_aero_1.vegetable = lettuce;
            slot_aero_1.oneCropPerSlot = true;

            var slot_aero_2 = new Slot();
            slot_aero_2.id = "[[[Aerospring]]] #2";
            slot_aero_2.number = 4;
            slot_aero_2.position = south;
            slot_aero_2.vegetable = cabbageRave;
            slot_aero_2.oneCropPerSlot = true;

            var slot_aero_3 = new Slot();
            slot_aero_3.id = "[[[Aerospring]]] #3";
            slot_aero_3.number = 4;
            slot_aero_3.position = north;
            slot_aero_3.vegetable = purslane;
            slot_aero_3.oneCropPerSlot = true;

            var slot_aero_4 = new Slot();
            slot_aero_4.id = "[[[Aerospring]]] #4";
            slot_aero_4.number = 2;
            slot_aero_4.position = north;
            slot_aero_4.vegetable = kale;
            slot_aero_4.oneCropPerSlot = true;

            var slot_aero_5 = new Slot();
            slot_aero_5.id = "[[[Aerospring]]] #5";
            slot_aero_5.number = 2;
            slot_aero_5.position = north;
            slot_aero_5.vegetable = mesclun;
            slot_aero_5.oneCropPerSlot = true;

            var slot_aero_6 = new Slot();
            slot_aero_6.id = "[[[Aerospring]]] #6";
            slot_aero_6.number = 2;
            slot_aero_6.position = north;
            slot_aero_6.vegetable = purslane;
            slot_aero_6.oneCropPerSlot = true;

            var slot_aero_7 = new Slot();
            slot_aero_7.id = "[[[Aerospring]]] #7";
            slot_aero_7.number = 2;
            slot_aero_7.position = north;
            slot_aero_7.vegetable = whiteOnion;
            slot_aero_7.oneCropPerSlot = true;

            var slot_aero_8 = new Slot();
            slot_aero_8.id = "[[[Aerospring]]] #8";
            slot_aero_8.number = 2;
            slot_aero_8.position = north;
            slot_aero_8.vegetable = kale;
            slot_aero_8.oneCropPerSlot = true;

            var slot_aero_9 = new Slot();
            slot_aero_9.id = "[[[Aerospring]]] #9";
            slot_aero_9.number = 2;
            slot_aero_9.position = north;
            slot_aero_9.vegetable = mesclun;
            slot_aero_9.oneCropPerSlot = true;

            var slot_aero_10 = new Slot();
            slot_aero_10.id = "[[[Aerospring]]] #10";
            slot_aero_10.number = 2;
            slot_aero_10.position = north;
            slot_aero_10.vegetable = purslane;
            slot_aero_10.oneCropPerSlot = true;

            var slot_aero_11 = new Slot();
            slot_aero_11.id = "[[[Aerospring]]] #11";
            slot_aero_11.number = 2;
            slot_aero_11.position = north;
            slot_aero_11.vegetable = whiteOnion;
            slot_aero_11.oneCropPerSlot = true;

            aeroSlots.Add(slot_aero_1);
            aeroSlots.Add(slot_aero_2);
            aeroSlots.Add(slot_aero_3);
            aeroSlots.Add(slot_aero_4);
            aeroSlots.Add(slot_aero_5);
            aeroSlots.Add(slot_aero_6);
            aeroSlots.Add(slot_aero_7);
            aeroSlots.Add(slot_aero_8);
            aeroSlots.Add(slot_aero_9);
            aeroSlots.Add(slot_aero_10);
            aeroSlots.Add(slot_aero_11);
            aerospringProductionType.slots = aeroSlots;

            productionTypes.Add(aquaponicProductionType);
            productionTypes.Add(permacultureProductionType);
            productionTypes.Add(aerospringProductionType);
            indoorProductionArea.productionTypes = productionTypes;

            productionAreas.Add(indoorProductionArea);
            currentMonth.productionAreas = productionAreas;

            return currentMonth;
        }

    }

    public class ProductionMonth
    {
        public Month month;
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
        public bool oneCropPerSlot;
    }

    public class Vegetable
    {
        public string name;
        public string imagePath;
        public int cropPerSlot;
        public GrowingState growingState;
        public decimal productionQuantity;
        public decimal temperatureMin;
        public decimal temperatureMax;
    }

    public class GrowingState
    {
        public string name;
        public int Id;
    }

    public class Month
    {
        public string name;
        public int Id;
    }

    public class Position
    {
        public string name;
        public int Id;
    }

}
