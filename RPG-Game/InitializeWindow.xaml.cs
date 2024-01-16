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
using System.Windows.Shapes;

namespace RPG_Game
{
    public partial class InitialWindow : Window
    {
        public InitialWindow()
        {
            InitializeComponent();
        }

        private void StartGameClick(object sender, RoutedEventArgs e)
        {
            string playerName = PlayerNameTextBox.Text;

            // Otwórz nowe okno i przekaż nazwę gracza
            MainWindow mainWindow = new MainWindow(playerName);
            mainWindow.Show();

            // Zamknij bieżące okno (InitialWindow)
            Close();
        }
    }
}
