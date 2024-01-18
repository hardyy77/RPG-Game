using RPG_Game.Scripts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System;

namespace RPG_Game
{
    public partial class MainWindow : Window
    {
        Player player = new Player();
        Monster monster = new Monster();
        Location location= new Location();
        

        public MainWindow(string Name)
        {
            InitializeComponent();

            player.Name = Name;
            monster = new Monster();

            DataContext = player;

            PlayerViewList();
        }

        private void PlayerViewClick(object sender, RoutedEventArgs e)
        {
            SetVisibility(PlayerView);

            PlayerStrengthLabel.Content = $"Strength: {player.Strength}";
            PlayerStaminaLabel.Content = $"Stamina: {player.Stamina}";
        }

        private void LocationViewClick(object sender, RoutedEventArgs e)
        {
            SetVisibility(LocationView);

            LocationLabel.Content = location.Name;
            MonsterStatsLabel.Content = $"Monster Stats: {monster.Name}," +
                $" Health: {monster.Health}," +
                $" Strength: {monster.Strength}," +
                $" Stamina: {monster.Stamina}," +
                $" Gold: {monster.Gold}," +
                $" Exp: {monster.Exp}";
        }

        private void SetVisibility(UIElement activateView)
        {
            PlayerView.Visibility = Visibility.Collapsed;
            LocationView.Visibility = Visibility.Collapsed;

            activateView.Visibility = Visibility.Visible;
        }

        private void PlayerViewList()
        {
            PlayerNameLabel.Content = $"Name: {player.Name}";
            PlayerHealthLabel.Content = $"Health: {player.Health}";
            PlayerMaxHealthLabel.Content = $"MaxHealth: {player.MaxHealth}";
            PlayerLevelLabel.Content = $"Level: {player.Level}";
            PlayerExpLabel.Content = $"Experience: {player.Experience}";
            PlayerGoldLabel.Content = $"Gold: {player.Gold}";
            PlayerBankLabel.Content = $"Bank: {player.Bank}";
        }

        private void Exploration(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 101);

            if (randomNumber <= 50)
            {
                Battle(randomNumber);
            }
            else if (randomNumber <= 60)
            {
                GetItem(randomNumber);
            }
            else if (randomNumber <= 100)
            {
                GetGold(randomNumber);
            }

            PlayerViewList();
        }

        private void Battle(int randomNumber)
        {
            if (monster.Strength < player.Strength)
            {
                string messageBoxText = $"You win! {monster.Name}";

                MessageBox.Show(messageBoxText);
                GetItem(randomNumber);
                player.GetGold(monster);
                player.GetExp(monster);
            }
            else if (monster.Strength > player.Strength)
            {
                string messageBoxText = "You lose!";

                MessageBox.Show(messageBoxText);
                player.Health -= monster.Strength;
            }
            else
            {
                string messageBoxText = "Draw!";

                MessageBox.Show(messageBoxText);
            }
        }

        private void GetItem(int randomNumber)
        {
            MessageBox.Show("Nothing special is here");
        }

        private void GetGold(int randomNumber)
        {
            player.Gold += 20;
            MessageBox.Show("You found some gold");
        }
    }
}
