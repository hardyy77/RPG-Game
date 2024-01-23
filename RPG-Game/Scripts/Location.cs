using System;
using System.Collections.Generic;

namespace RPG_Game.Scripts
{
    public enum LocationType
    {
        Forest,
        Mountains,
        Ocean
    }

    public class Location
    {
        public string Name { get; private set; }
        public string Description { get; private set; }

        //public List<Monster> MonstersInLocation { get; private set; }

        public Location(LocationType locationType)
        {
            //MonstersInLocation = new List<Monster>();
            //Monster monster = new Monster();
            //List<string[]> allMonsters = monster.allMonsters;
            SetLocationDetails(locationType);
            //AssignMonstersToLocation(allMonsters, monster);
        }

        private void SetLocationDetails(LocationType locationType)
        {
            switch (locationType)
            {
                case LocationType.Forest:
                    Name = "Forest";
                    Description = "A dense and mysterious forest with towering trees.";
                    break;

                case LocationType.Mountains:
                    Name = "Mountains";
                    Description = "Majestic peaks covered in snow and rocky cliffs.";
                    break;

                case LocationType.Ocean:
                    Name = "Ocean";
                    Description = "Endless waves and vast horizons of the deep blue sea.";
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(locationType), locationType, null);
            }
        }

        //private void AssignMonstersToLocation(List<string[]> allMonsters, Monster monster)
        //{
        //    foreach (var monsterData in allMonsters)
        //    {

        //        monster.InitializeMonster(monsterData);

        //        if (monster.Id > 0 && monster.Id < 6)
        //        {
        //            MonstersInLocation.Add(monster);
        //        }
        //        switch (monsterData[0])
        //        {
        //            case "1":
        //            case "2":
        //            case "3":
        //            case "4":
        //            case "5":
        //                if (Name == "Forest")
        //                    MonstersInLocation.Add(monster);
        //                break;

        //            case "11":
        //            case "12":
        //            case "13":
        //            case "14":
        //            case "15":
        //                if (Name == "Ocean")
        //                    MonstersInLocation.Add(monster);
        //                break;

        //            case "21":
        //            case "22":
        //            case "23":
        //            case "24":
        //            case "25":
        //                if (Name == "Mountains")
        //                    MonstersInLocation.Add(monster);
        //                break;
        //        }
        //    }
        //}
    }
}