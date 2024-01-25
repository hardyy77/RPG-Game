using System;
using System.Collections.Generic;
using System.Linq;

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
        public List<Monster> MonstersInLocation { get; private set; }

        public Location(LocationType locationType)
        {
            MonstersInLocation = new List<Monster>();
            Monster monster = new Monster();
            List<string[]> allMonsters = monster.allMonsters;
            SetLocationDetails(locationType);
            AssignMonstersToLocation(allMonsters, monster, locationType);
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

        private void AssignMonstersToLocation(List<string[]> allMonsters, Monster monster, LocationType locationType)
        {
            var monstersInCurrentLocation = allMonsters.Where(m => GetLocationTypeFromMonsterName(m[1]) == locationType);

            foreach (var monsterData in monstersInCurrentLocation)
            {
                monster.InitializeMonster(monsterData);

                MonstersInLocation.Add(new Monster
                {
                    Name = monster.Name,
                    Health = monster.Health,
                    Strength = monster.Strength,
                    Stamina = monster.Stamina,
                    Gold = monster.Gold,
                    Exp = monster.Exp
                });
            }
        }

        private LocationType GetLocationTypeFromMonsterName(string monsterName)
        {
            if (monsterName.ToLower().Contains("forest"))
            {
                return LocationType.Forest;
            }
            else if (monsterName.ToLower().Contains("mountains"))
            {
                return LocationType.Mountains;
            }
            else if (monsterName.ToLower().Contains("ocean"))
            {
                return LocationType.Ocean;
            }
            else
            {
                return LocationType.Forest;
            }
        }
    }
}