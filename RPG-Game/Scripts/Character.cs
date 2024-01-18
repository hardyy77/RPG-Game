using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game.Scripts
{
    public abstract class Character 
    {
        protected int id;
        protected int maxHealth;
        protected int health;
        protected string name = "";
        protected int stamina;
        protected int strength;
        
        protected int gold;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int MaxHealth
        {
            get { return maxHealth; }
            set { maxHealth = value; }
        }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Stamina
        {
            get { return stamina; }
            set { stamina = value; }
        }

        public int Strength
        {
            get { return strength; }
            set { strength = value; }
        }

    
        public int Gold
        {
            get { return gold; }
            set { gold = value; }
        }
    }
}
