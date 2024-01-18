using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;

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
           
        }

        private void MonsterReader()
        {
            StreamReader monsterFile = new StreamReader("assets/monster.csv");
            var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = false,
            };
            var csv = new CsvReader(monsterFile, csvConfig);
        }
    }
}
