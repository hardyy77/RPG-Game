using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game.Scripts
{
    public class Monster : Character
    {
        private int gold;
        private int exp;



        public int Gold { get; set; }
        public int Exp { get; set; }

        public Monster()
        {
            Health = 5;
            Strength = 30;
            Stamina = 5;
            Gold = 10;
            Exp = 60;
        }
    }
}
