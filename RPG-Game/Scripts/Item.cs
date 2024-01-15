using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game.Scripts
{
    public abstract class Item
    {
        private string name = "";
        private int value;

        public string Name { get; set; }
        public int Value { get; set; }
    }
}
