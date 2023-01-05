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

        ObservableCollection<Player> GridList1 = new ObservableCollection<Player>();
        ObservableCollection<Player> GridList2 = new ObservableCollection<Player>();




        public LottningWindow()
        {
            InitializeComponent();

            Players players = new Players();
                        
            this.DataContext = players;

            UpdatePlayerGrids();

            void UpdatePlayerGrids()
            {
                GridList1 = new ObservableCollection<Player>();
                GridList2 = new ObservableCollection<Player>();
                GridList1.Clear();
                GridList2.Clear();

                foreach (Player player in Players.PlayerList.Take(8))
                {
                    GridList1.Add(player);
                }

                foreach (Player player in Players.PlayerList.Skip(8))
                {
                    GridList2.Add(player);
                }

                PlayersDataGrid1.ItemsSource = GridList1;
                PlayersDataGrid2.ItemsSource = GridList2;
            }

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
            addPlayer.OldPlayer.ItemsSource = Players.PlayerList;
            addPlayer.Show();
        }

        private void LottningsButton_Click(object sender, RoutedEventArgs e)
        {
            FinalRandom FinalRandom = new FinalRandom();
            FinalRandom.Show();

            if (Fri.IsChecked==true)
            {
                friLottning = true;
            }
        }
    }
}