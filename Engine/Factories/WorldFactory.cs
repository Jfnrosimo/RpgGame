﻿using Engine.Models;

namespace Engine.Factories
{
    internal class WorldFactory
    {
        internal World CreateWorld()
        {
            World newWorld = new World();

            newWorld.AddLocation(-2,-1,"Farmer's Field",
                "There are rows of corn growing here, with giant rats hiding between them.",
                "../Images/Locations/FarmFields.png");
            newWorld.AddLocation(-1,-1,"Farmer's House",
                "This is the house of your neighbor, Farmer Ted.",
                "../Images/Locations/FarmHouse.png");
            newWorld.AddLocation(0,-1,"Home",
                "This is your home",
                "../Images/Locations/Home.png");
            newWorld.AddLocation(-1,0,"Trading Shop","The shop of susan, the trader.","../Images/Locations/Trader.png");
            newWorld.AddLocation(0,0,"Town square",
                "You see a fountain here.",
                "../Images/Locations/TownSquare.png");
            newWorld.AddLocation(1,0,"Town Gate",
                "There is a gate here, protecting the town from giant spiders.",
                "../Images/Locations/TownGate.png");
            newWorld.AddLocation(2,0,"Spider Forest",
                "The trees in this forest are covered with spider webs.",
                "../Images/Locations/SpiderForest.png");
            newWorld.AddLocation(0,1,"Herbalist's hut",
                "You see a small hut, with plants drying from the roof.",
                "../Images/Locations/HerbalistsHut.png");
            newWorld.AddLocation(0,2,"Herbalist's garden",
                "There are many plants here, with snakes hiding behind them.",
                "../Images/Locations/HerbalistsGarden.png");

            return newWorld;
        }
    }
}
