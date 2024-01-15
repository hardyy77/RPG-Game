using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game.Scripts
{
    public abstract class Character
    {

        private int maxHealth;
        private int health;
        private string name = "";
        private int stamina;
        private int strength;

        public int MaxHealth { get; set; }
        public int Health { get; set; }
        public string Name { get; set; }
        public int Stamina { get; set; }
        public int Strength { get; set; }

    }
}
