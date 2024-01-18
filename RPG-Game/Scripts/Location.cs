using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game
{
    public class Location
    {
        private string name = "";
        private string description = "";

        public string Name { get; set; }
        public string Description { get; set; }

        public Location()
        {
            Name = "Forest";
        }
    }
}
