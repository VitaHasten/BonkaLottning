using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
    /// Interaction logic for Lottning.xaml
    /// </summary>
    public partial class Lottning : Window
    {
        // Creating lists
        List<string> LottningSkill = new List<string>();
        List<string> LottningHcp = new List<string>();

        public ObservableCollection<Players> PlayerList = new ObservableCollection<Players>();

        public Lottning()
        {
            InitializeComponent();

            DataContext = new AddPlayer();

            Players Player1 = new Players("Dawwe", 5.3, 9, @"/Dawe.png");
            Players Player2 = new Players("Robin", 9.7, 5, @"/Robin2.png");
            Players Player3 = new Players("Fraes", 14.7, 6, @"/Fraes.png");
            Players Player4 = new Players("Sheiakh", 18.3, 7, @"/Sheiakh.png");
            Players Player5 = new Players("Palle", 7.8, 7, @"/Palle.png");
            Players Player6 = new Players("Tet", 21.2, 6, @"/Tet.png");
            Players Player7 = new Players("Olle", 24.0, 6, @"/Olle.png");
            Players Player8 = new Players("Fedja", 24.8, 1, @"/Fedja.png");
            Players Player9 = new Players("Per", 3.2, 7, @"/Per.png");
            Players Player10 = new Players("Strandberg", 11.2, 7, @"/Strandberg.png");
            Players Player11 = new Players("Boxer", 20.1, 5, @"/Boxer.png");
            Players Player12 = new Players("Klas", 3.5, 4, @"/Rocco.png");
            Players Player13 = new Players("Konrad", 7.8, 3, @"/Rocco.png");
            Players Player14 = new Players("Konny", 9.5, 7, @"/Rocco.png");
            Players Player15 = new Players("Kristoffer", 22.8, 5, @"/Rocco.png");
            Players Player16 = new Players("Kurt", 36.0, 2, @"/Rocco.png");
                     
            PlayerList.Add(Player1);
            PlayerList.Add(Player2);
            PlayerList.Add(Player3);
            PlayerList.Add(Player4);
            PlayerList.Add(Player5);
            PlayerList.Add(Player6);
            PlayerList.Add(Player7);
            PlayerList.Add(Player8);
            PlayerList.Add(Player9);
            PlayerList.Add(Player10);
            PlayerList.Add(Player11);
            PlayerList.Add(Player12);
            PlayerList.Add(Player13);
            PlayerList.Add(Player14);
            PlayerList.Add(Player15);
            PlayerList.Add(Player16);

            foreach (var item in PlayerList)
            {
                PlayersDataGrid.Items.Add(item);
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
            addPlayer.Show();
        }
    }
}
