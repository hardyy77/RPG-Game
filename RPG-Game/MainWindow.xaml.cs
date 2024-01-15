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
using RPG_Game.Scripts;

namespace RPG_Game
{
    public partial class MainWindow : Window
    {
        Player player = new Player();


        public MainWindow()
        {
            InitializeComponent();
            player.Name = "Hardy";

        }

        private void PlayerViewClick(object sender, RoutedEventArgs e)
        {
            SetVisibility(PlayerView);
            PlayerNameLabel.Content = "Name: " + player.Name;
            PlayerMaxHealthLabel.Content = "MaxHealth: " + player.MaxHealth;
            PlayerHealthLabel.Content = "Health: " + player.Health;
            PlayerStrengthLabel.Content = "Strength: " + player.Strength;
            PlayerStaminaLabel.Content = "Stamina: " + player.Stamina;
            PlayerGoldLabel.Content = "Gold: " + player.Gold;
            PlayerBankLabel.Content = "Bank: " + player.Bank;
            PlayerLevelLabel.Content = "Level: " + player.Level;
            PlayerExpLabel.Content = "Experience: " + player.Experience;
        }
        private void LocationViewClick(object sender, RoutedEventArgs e)
        {
            SetVisibility(LocationView);
        }
        private void SetVisibility(Grid activateView)
        {
            PlayerView.Visibility = Visibility.Collapsed;
            LocationView.Visibility = Visibility.Collapsed;

            activateView.Visibility = Visibility.Visible;
        }

    }
}
