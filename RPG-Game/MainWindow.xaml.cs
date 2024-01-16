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

namespace RPG_Game
{
    public partial class MainWindow : Window
    {
        Player player = new Player();


        public MainWindow(string Name)
        {
            InitializeComponent();
           
            player.Name = Name;

            
            DataContext = player;

            PlayerViewList();
        }

        private void PlayerViewClick(object sender, RoutedEventArgs e)
        {
            SetVisibility(PlayerView);

            PlayerMaxHealthLabel.Content = "MaxHealth: " + player.MaxHealth;
            PlayerStrengthLabel.Content = "Strength: " + player.Strength;
            PlayerStaminaLabel.Content = "Stamina: " + player.Stamina;
        }

        private void LocationViewClick(object sender, RoutedEventArgs e)
        {
            SetVisibility(LocationView);
        }

        private void SetVisibility(UIElement activateView)
        {
            PlayerView.Visibility = Visibility.Visible;
            LocationView.Visibility = Visibility.Collapsed;

            activateView.Visibility = Visibility.Visible;
        }

        private void PlayerViewList()
        {
            PlayerNameLabel.Content = "Name: " + player.Name;
            PlayerHealthLabel.Content = "Health: " + player.Health;
            PlayerLevelLabel.Content = "Level: " + player.Level;
            PlayerExpLabel.Content = "Experience: " + player.Experience;
            PlayerGoldLabel.Content = "Gold: " + player.Gold;
            PlayerBankLabel.Content = "Bank: " + player.Bank;
        }

    }
}
