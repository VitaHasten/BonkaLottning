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

namespace BonkaLottning
{
    /// <summary>
    /// Interaction logic for FinalRandom.xaml
    /// </summary>
    public partial class FinalRandom : Window
    {

        // Lista med objekt
        List<Object> team1 = new List<Object>();
        List<Object> team2 = new List<Object>();
        List<Object> team3 = new List<Object>();
        List<Object> team4 = new List<Object>();

        public FinalRandom()
        {
            InitializeComponent();

            PerformLottning();
        }

        void PerformLottning()
        {

            // Shuffle listan
            var rnd = new Random();
            int n = PlayerList.Count;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                Object value = PlayerList[k];
                PlayerList[k] = PlayerList[n];
                PlayerList[n] = value;
            }

            // Välj de första fyra elementen i shufflade listan
            PlayerList<Players> selectedObjects1 = PlayerList.Take(4).ToList(team1);

            // Ta bort de valda objekten från listan
            PlayerList.RemoveRange(0, 4);

            // Välj fyra till objekt från de kvarvarande objekten i listan
            PlayerList<Players> selectedObjects2 = PlayerList.Take(4).ToList(team2);

            // Ta bort de valda objekten från listan
            PlayerList.RemoveRange(0, 4);

            // Välj fyra till objekt från de kvarvarande objekten i listan
            PlayerList<Players> selectedObjects3 = PlayerList.Take(4).ToList(team3);

            // Ta bort de valda objekten från listan
            PlayerList.RemoveRange(0, 4);

            // Välj fyra till objekt från de kvarvarande objekten i listan
            PlayerList<Players> selectedObjects4 = PlayerList.Take(4).ToList(team4);

            // Ta bort de valda objekten från listan
            PlayerList.RemoveRange(0, 4);

            void drawPlayer1()
            {
                foreach (var team1player1 in team1)
                {

                }
            }

            void teamSkills()
            {
                for (int i = 0; i < team1.Length; i++)
                {
                    double driveSum = Player.Drive[i] =+;
                    double driveAvg = driveSum /[i];

                    double wedgeSum = Player.Drive[i] =+;
                    double wedgeAvg = driveSum /[i];

                    double chippingSum = Player.Drive[i] =+;
                    double chippingAvg = driveSum /[i];

                    double puttingSum = Player.Drive[i] =+;
                    double puttingAvg = driveSum /[i];

                    double vinnarskalleSum = Player.Drive[i] =+;
                    double vinnarskalleAvg = driveSum /[i];

                    double alcoholSum = Player.Drive[i] =+;
                    double alcoholAvg = driveSum /[i];

                    string styrka = "Styrka: ";
                    string svaghet = "Svaghet: ";

                    string Strength()

                    {

                        if (driveAvg > wedgeAvg && driveAvg > chippingAvg && driveAvg > puttingAvg && driveAvg > vinnarskalleAvg && driveAvg > alcoholAvg)
                        {
                            styrka = "Styrka: Spelet med drivern. Långt eller rakt, ofta både och. ";
                        }

                        else if (wedgeAvg > driveAvg && wedgeAvg > chippingAvg && wedgeAvg > puttingAvg && wedgeAvg > vinnarskalleAvg && wedgeAvg > alcoholAvg)
                        {
                            styrka = "Styrka: Längdkontroll i wedgarna, som att kasta dartpilar.";
                        }

                        else if (chippingAvg > driveAvg && chippingAvg > wedgeAvg && chippingAvg > puttingAvg && chippingAvg > vinnarskalleAvg && chippingAvg > alcoholAvg)
                        {
                            styrka = "Styrka: Chippar i världsklass, given up-and-down.";
                        }

                        else if (puttingAvg > driveAvg && puttingAvg > wedgeAvg && puttingAvg > chippingAvg && puttingAvg > vinnarskalleAvg && puttingAvg > alcoholAvg)
                        {
                            styrka = "Styrka: Kommer sänka metervis med puttar.";
                        }

                        else if (vinnarskalleAvg > driveAvg && vinnarskalleAvg > wedgeAvg && vinnarskalleAvg > chippingAvg && vinnarskalleAvg > puttingAvg && vinnarskalleAvg > alcoholAvg)
                        {
                            styrka = "Styrka: Målmedvetna och pushar varandra. Vinnarskallar.";
                        }

                        else if (alcoholAvg > driveAvg && alcoholAvg > wedgeAvg && alcoholAvg > chippingAvg && alcoholAvg > puttingAvg && alcoholAvg > vinnarskalleAvg)
                        {
                            styrka = "Styrka: Inte bäst på banan, men i baren. Roligaste laget!";
                        }

                        return styrka;
                    }

                    string Weakness()
                    {

                        if (driveAvg < wedgeAvg && driveAvg < chippingAvg && driveAvg < puttingAvg && driveAvg < vinnarskalleAvg && driveAvg < alcoholAvg)
                        {
                            svaghet = "Svaghet: Kort och snett från tee, oftast.";
                        }

                        else if (wedgeAvg < driveAvg && wedgeAvg < chippingAvg && wedgeAvg < puttingAvg && wedgeAvg < vinnarskalleAvg && wedgeAvg < alcoholAvg)
                        {
                            svaghet = "Svaghet: Floffad eller råtoppad wedge? På green hamnar den allt för sällan.";
                        }

                        else if (chippingAvg < driveAvg && chippingAvg < wedgeAvg && chippingAvg < puttingAvg && chippingAvg < vinnarskalleAvg && chippingAvg < alcoholAvg)
                        {
                            svaghet = "Svaghet: Chipgips ingår. Dubbelträff går ej att utesluta.";
                        }

                        else if (puttingAvg < driveAvg && puttingAvg < wedgeAvg && puttingAvg < chippingAvg && puttingAvg < vinnarskalleAvg && puttingAvg < alcoholAvg)
                        {
                            svaghet = "Svaghet: Luktar lite treputtar. Kanske även en fyrputt?";
                        }

                        else if (vinnarskalleAvg < driveAvg && vinnarskalleAvg < wedgeAvg && vinnarskalleAvg < chippingAvg && vinnarskalleAvg < puttingAvg && vinnarskalleAvg < alcoholAvg)
                        {
                            svaghet = "Svaghet: Hänger lätt med huvudena och saknar vinnarmentalitet.";
                        }

                        else if (alcoholAvg < driveAvg && alcoholAvg < wedgeAvg && alcoholAvg < chippingAvg && alcoholAvg < puttingAvg && alcoholAvg < vinnarskalleAvg)
                        {
                            svaghet = "Svaghet: Riktigt dåliga ölsinnen. Kan bli svajigt vid en dålig start.";
                        }

                        return svaghet;
                    }
                }
            }
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            LottningWindow LottningWindow = new LottningWindow();
            LottningWindow.Show();
            this.Close();
        }

        
    }
}
