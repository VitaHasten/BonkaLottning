using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace BonkaLottning
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        // Creating lists
        List<string> LottningSkill = new List<string>();
        List<string> LottningHcp = new List<string>();
        ObservableCollection<Players> PlayerList = new ObservableCollection<Players>();


        public MainWindow()
        {
            InitializeComponent();

            this.Closing += new System.ComponentModel.CancelEventHandler(MainWindow_Closing);

            DataContext = this.GetPlayers();


        }
        public ObservableCollection<Players> GetPlayers()
        {
            // Creating object, Name, hcp, skill
            Players Player1 = new Players("Dawwe", 5.3, 9, @"Dawe.png");
            Players Player2 = new Players("Robin", 9.7, 5, @"Robin.jpg");
            Players Player3 = new Players("Fraes", 14.7, 6, @"Fraes.png");
            Players Player4 = new Players("Sheiakh", 18.3, 7, @"Sheiakh.png");
            Players Player5 = new Players("Palle", 7.8, 7, @"Palle.png");
            Players Player6 = new Players("Tet", 21.2, 6, @"Tet.png");
            Players Player7 = new Players("Olle", 24.0, 6, @"Olle.png");
            Players Player8 = new Players("Fedja", 24.8, 1, @"Fedja.png");
            Players Player9 = new Players("Per", 3.2, 7, @"Per.png");
            Players Player10 = new Players("Strandberg", 11.2, 7, @"Strandberg.png");
            Players Player11 = new Players("Boxer", 20.1, 5, @"Boxer.png");
            Players Player12 = new Players("Klas", 3.5, 4, @"Rocco.png");
            Players Player13 = new Players("Konrad", 7.8, 3, @"Rocco.png");
            Players Player14 = new Players("Konny", 9.5, 7, @"Rocco.png");
            Players Player15 = new Players("Kristoffer", 22.8, 5, @"Rocco.png");
            Players Player16 = new Players("Kurt", 36.0, 2, @"Rocco.png");

            return PlayerList;
        }

        private void lottningButton_Click(object sender, RoutedEventArgs e)
        {
            lottningWindow LottningWindow = new LottningWindow();
            LottningWindow.Show();
            this.Close();
        }
        
        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
