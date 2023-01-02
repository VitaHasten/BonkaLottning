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
    /// Interaction logic for Random.xaml
    /// </summary>
    public partial class Random : Window
    {

        // Lista med objekt
        List<Object> list = new List<Object>();

        public Random()
        {
            InitializeComponent();

            PerformLottning();
        }

        void PerformLottning() 
        {
            
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

            // Lägg till objekt i listan
            list.Add(new Players("Dawwe", 5.3, 9, @"/Dawe.png"));
            list.Add(new Players("Robin", 9.7, 5, @"/Robin2.png"));
            list.Add(new Players("Fraes", 14.7, 6, @"/Fraes.png"));
            list.Add(new Players("Sheiakh", 18.3, 7, @"/Sheiakh.png"));
            list.Add(new Players("Palle", 7.8, 7, @"/Palle.png"));
            list.Add(new Players("Tet", 21.2, 6, @"/Tet.png"));
            list.Add(new Players("Olle", 24.0, 6, @"/Olle.png"));
            list.Add(new Players("Fedja", 24.8, 1, @"/Fedja.png"));
            list.Add(new Players("Per", 3.2, 7, @"/Per.png"));
            list.Add(new Players("Strandberg", 11.2, 7, @"/Strandberg.png"));
            list.Add(new Players("Boxer", 20.1, 5, @"/Boxer.png"));
            list.Add(new Players("Klas", 3.5, 4, @"/Rocco.png"));
            list.Add(new Players("Konrad", 7.8, 3, @"/Rocco.png"));
            list.Add(new Players("Konny", 9.5, 7, @"/Rocco.png"));
            list.Add(new Players("Kristoffer", 22.8, 5, @"/Rocco.png"));
            list.Add(new Players("Kurt", 36.0, 2, @"/Rocco.png"));

           
            
            //// Shuffle listan
            //Random rnd = new Random();
            //int n = list.Count;
            //while (n > 1)
            //{
            //    n--;
            //    int k = rnd.Next(n + 1);
            //    Object value = list[k];
            //    list[k] = list[n];
            //    list[n] = value;
            //}

            //// Välj de första fyra elementen i shufflade listan
            //List<Object> selectedObjects1 = list.Take(4).ToList();

            //// Ta bort de valda objekten från listan
            //list.RemoveRange(0, 4);

            //// Välj fyra till objekt från de kvarvarande objekten i listan
            //List<Object> selectedObjects2 = list.Take(4).ToList();

            //// Ta bort de valda objekten från listan
            //list.RemoveRange(0, 4);

            //// Välj fyra till objekt från de kvarvarande objekten i listan
            //List<Object> selectedObjects3 = list.Take(4).ToList();

            //// Ta bort de valda objekten från listan
            //list.RemoveRange(0, 4);

            //// Välj fyra till objekt från de kvarvarande objekten i listan
            //List<Object> selectedObjects4 = list.Take(4).ToList();

            //// Ta bort de valda objekten från listan
            //list.RemoveRange(0, 4);
        }
    }
}
