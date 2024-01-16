using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game.Scripts
{
    public class Player : Character
    {
        Item[] Equipment = new Item[10];
        private int gold;
        private int bank;
        private int level;
        private int experience;

        public int Gold { get; set; }
        public int Bank { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }

        public Player()
        {
            MaxHealth = 100;
            Health = 100;
            Strength = 50;
            Stamina = 30;
            Gold = 500;
            Bank = 1000;
            Level = 1;
            Experience = 0;
        }

        public void GetGold(Monster monster)
        {
            this.Gold += monster.Gold;
        }
        public void GetExp(Monster monster)
        {
            this.Experience += monster.Exp;
            this.CheckLevel();
        }
        public void CheckLevel()
        {
            int expToNextLevel = this.Level * 10;
            if (this.Experience > expToNextLevel)
            {
                this.Level++;
                this.Experience -= expToNextLevel;
            }

        }
    }
}
