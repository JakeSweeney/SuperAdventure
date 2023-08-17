using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player
    {
        public int currentHitPoints { get; set; }
        public int maximumHitPoints { get; set; }
        public int gold { get; set; }
        public int experiencePoints { get; set; }
        public int level { get; set; }
        public Player(int currentHitPoints, int maximumHitPoints, int gold, int experiencePoints, int level)
        {
            this.currentHitPoints = currentHitPoints;
            this.maximumHitPoints = maximumHitPoints;
            this.gold = gold;
            this.experiencePoints = experiencePoints;
            this.level = level;

        }

    }
}
