﻿using Engine.Factories;
using Engine.Models;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer
        {
            get; set;
        }
        public Location CurrentLocation
        {
            get; set;
        }
        public World CurrentWorld
        {
            get; set;
        }

        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Jeff";
            CurrentPlayer.CharacterClass = "Warrior";
            CurrentPlayer.HitPoints = 4;
            CurrentPlayer.Gold = 1000000;
            CurrentPlayer.ExperiencePoints = 10;
            CurrentPlayer.Level = 1;

            WorldFactory factory = new WorldFactory();
            CurrentWorld = factory.CreateWorld();

            CurrentLocation = CurrentWorld.LocationAt(0,0);
        }
    }
}
