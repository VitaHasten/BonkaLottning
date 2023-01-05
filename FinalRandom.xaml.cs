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
using System.Windows.Shapes;

namespace BonkaLottning
{
    /// <summary>
    /// Interaction logic for FinalRandom.xaml
    /// </summary>
    public partial class FinalRandom : Window
    {

        // Lista med objekt
        List<Player> team1 = new List<Player>();
        List<Player> team2 = new List<Player>();
        List<Player> team3 = new List<Player>();
        List<Player> team4 = new List<Player>();

        List<int> siffror = new List<int>();
        
                    
        

        public FinalRandom()
        {
            InitializeComponent();

            DataContext = Players.PlayerList; 

            PerformLottning();
        }

        void Slumptal()
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    siffror.Add(i);
                }
            }
            siffror = siffror.OrderBy(x => Guid.NewGuid()).ToList();
        }


        void PerformLottning()
        {
            LagTilldelning();
            
        }

        void LagTilldelning()
        {
            Slumptal();
            foreach (var slumpa in Players.PlayerList)
            {
                if (slumpa.Team < 1)
                {
                    for (int i = 0; i < 16; i++)
                    {
                        slumpa.Team = siffror[i];

                    }

                }

                else
                {
                    Console.WriteLine("Något är fel.");
                }
                
                if (slumpa.Team == 1)
                {
                    team1.Add(slumpa);
                    Snitt(slumpa,1);
                }
                else if (slumpa.Team == 2)
                {
                    team2.Add(slumpa);
                    Snitt(slumpa,2);
                }
                else if (slumpa.Team == 3)
                {
                    team3.Add(slumpa);
                    Snitt(slumpa,3);
                }
                else if (slumpa.Team == 4)
                {
                    team4.Add(slumpa);
                    Snitt(slumpa,4);
                }
            }
        }

        void Snitt(Player spelare, int lag)
        {

        }





        void teamSkills()
            {
                for (int i = 0; i < team1.Count; i++)
                {
                    double driveSum =+ team1[i].Drives;
                    double driveAvg = driveSum / i;

                    double wedgeSum =+ team1[i].Wedges;
                    double wedgeAvg = wedgeSum / i;

                    double chippingSum =+ team1[i].Chipping ;
                    double chippingAvg = wedgeSum /i;

                    double puttingSum =+ team1[i].Puttning;
                    double puttingAvg = puttingSum /i;

                    double vinnarskalleSum =+ team1[i].Vinnarskalle;
                    double vinnarskalleAvg = vinnarskalleSum /i;

                    double alcoholSum = team1[i].Alcohol;
                    double alcoholAvg = alcoholSum /i;

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
