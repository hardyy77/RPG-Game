using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Xml.Linq;
using CsvHelper;
using CsvHelper.Configuration;
using RPG_Game.Scripts;
using RPG_Game;

public class Monster : Character
{
    public List<string[]> allMonsters;
    private int exp;

    public int Exp
    {
        get { return exp; }
        set { exp = value; }
    }

    public Monster()
    {
        allMonsters = MonsterReader();
        if (allMonsters != null && allMonsters.Count > 0)
        {
            InitializeMonster(allMonsters[0]);
        }
        else
        {
            MessageBox.Show("Brak danych potworów lub błąd odczytu pliku.");
        }
    }

    public List<string[]> MonsterReader()
    {
        try
        {
            using (StreamReader streamReader = new StreamReader("C:\\Users\\arekl\\source\\GitHub\\RPG\\RPG\\RPG-Game\\Assets\\monster.csv"))
            {
                streamReader.ReadLine();

                List<string[]> monsters = new List<string[]>();
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                    string[] values = line.Split(',');

                    if (values.Length == 8)
                    {
                        monsters.Add(values);
                    }
                    else
                    {
                        MessageBox.Show($"Błąd w wierszu: {line}");
                    }
                }
                return monsters;
            }
        }
        catch (Exception exception)
        {
            MessageBox.Show($"Wystąpił błąd odczytu {exception.Message}");
            return null;
        }
    }

    public void InitializeMonster(string[] monsterData)
    {
        
        Name = monsterData[1].Trim();
        Health = int.Parse(monsterData[2]);
        Strength = int.Parse(monsterData[3]);
        Stamina = int.Parse(monsterData[4]);
        Gold = int.Parse(monsterData[5]);
        Exp = int.Parse(monsterData[6]);
    }
}

