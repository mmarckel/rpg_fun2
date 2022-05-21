﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player : LivingCreature
    {
        public int Gold { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }
        public List<InventoryItem> Inventory { get; set; }
        public List<PlayerQuest> Quests { get; set; }

        public Player (int currentHitPoints, int maximumHitPoints, int gold, int experiencePoints, int level) //constructor- SuperAdventure.cs calls this line kind of...
            : base(currentHitPoints, maximumHitPoints)
        {
            Gold = gold;
            ExperiencePoints = experiencePoints;
            Level = Level;
            Inventory = new List<InventoryItem>();
            Quests = new List<PlayerQuest>();
        }
    }
}