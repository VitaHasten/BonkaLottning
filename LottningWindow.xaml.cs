using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace BonkaLottning
{
    /// <summary>
    /// Interaction logic for LottningWindow.xaml
    /// </summary>
    public partial class LottningWindow : Window
    {
        // Creating lists
        List<string> LottningSkill = new List<string>();
        List<string> LottningHcp = new List<string>();
        bool friLottning= false;
         
              

        public LottningWindow()
        {
            InitializeComponent();

            Players players = new Players();

            
            PlayersDataGrid.ItemsSource = result; 
            
            this.DataContext= players;
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MainWindow = new MainWindow();
            MainWindow.Show();
            this.Close();
        }


        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AddPlayer addPlayer = new AddPlayer();
            // addPlayer.DataContext = new Players();
             addPlayer.OldPlayer.ItemsSource = Players.Getall();
            addPlayer.Show();
        }

        private void LottningsButton_Click(object sender, RoutedEventArgs e)
        {
            FinalRandom FinalRandom = new FinalRandom();
            FinalRandom.DataContext = new Players();
            FinalRandom.ItemsSource = Players.Getall();
            FinalRandom.Show();

            if (Fri.IsChecked==true)
            {
                friLottning = true;
            }
        }
    }
}