using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BonkaLottning
{
    class Players
    {
        

        public static ObservableCollection<Player> PlayerList;

        // Constructor Declaration of Class
        public Players()
        {
            PlayerList = new ObservableCollection<Player>();
            
            PlayerList.Add(new Player("Dawwe", 5.3, 9, 5, 4, 4, 5, 5, 2, @"/sverige.png", @"/Dawe.png", 0));
            PlayerList.Add(new Player("Robin", 9.7, 5, 4, 2, 3, 4, 2, 3, @"/sverige.png", @"/Robin2.png", 0));
            PlayerList.Add(new Player("Fraes", 14.7, 6, 3, 3, 0, 3, 4, 5, @"/sverige.png", @"/Fraes.png", 0));
            PlayerList.Add(new Player("Sheiakh", 18.3, 7, 3, 3, 3, 4, 3, 4, @"/pakistan.png", @"/Sheiakh.png", 0));
            PlayerList.Add(new Player("Palle", 7.8, 7, 5, 4, 3, 3, 4, 3, @"/sverige.png", @"/Palle.png", 0));
            PlayerList.Add(new Player("Tet", 21.2, 6, 2, 3, 4, 3, 3, 3, @"/sverige.png", @"/Tet.png", 0));
            PlayerList.Add(new Player("Olle", 24.0, 6, 2, 3, 2, 4, 3, 4, @"/sverige.png", @"/Olle.png", 0));
            PlayerList.Add(new Player("Fedja", 24.8, 2, 2, 1, 2, 2, 2, 2, @"/bosnien.png", @"/Fedja.png", 0));
            PlayerList.Add(new Player("Per", 3.2, 7, 4, 4, 3, 4, 5, 2, @"/norge.png", @"/Per.png", 0));
            PlayerList.Add(new Player("Strandberg", 11.2, 7, 5, 3, 3, 3, 3, 3, @"/estland.png", @"/Strandberg.png", 0));
            PlayerList.Add(new Player("Boxer", 20.1, 5, 3, 2, 3, 2, 2, 3, @"/sverige.png", @"/Boxer.png", 0));
            PlayerList.Add(new Player("Klas", 3.5, 4, 5, 4, 3, 4, 3, 4, @"/italien.png", @"/Rocco.png", 0));
            PlayerList.Add(new Player("Konrad", 7.8, 3, 4, 4, 3, 3, 2, 1, @"/italien.png", @"/Rocco.png", 0));
            PlayerList.Add(new Player("Konny", 9.5, 7, 4, 3, 4, 2, 4, 1, @"/italien.png", @"/Rocco.png", 0));
            PlayerList.Add(new Player("Kristoffer", 22.8, 5, 2, 3, 1, 2, 1, 4, @"/italien.png", @"/Rocco.png", 0));
            PlayerList.Add(new Player("Kurt", 36.0, 2, 1, 2, 1, 4, 1, 2, @"/italien.png", @"/Rocco.png", 0));
                       
        }

        public ObservableCollection<Player> GetAll()
        {
            var result = PlayerList;
            return result;
        }

    }

    class Player
    {
        public string Name { get; set; }
        public int Skill { get; set; }
        public double Hcp { get; set; }
        public int Drives { get; set; }
        public int Wedges { get; set; }
        public int Chipping { get; set; }
        public int Puttning { get; set; }
        public int Vinnarskalle { get; set; }
        public int Alcohol { get; set; }
        // public string Intro { get; set; }
        public string PlayerFlag { get; set; }
        public string PlayerImage { get; set; }
        
        public int Team { get; set; }

        public Player(string name, double hcp, int skill, int drives, int wedges, int chipping, int puttning, int vinnarskalle, int alcohol, /* string intro, */ string playerFlag, string playerImage, int team)
        {
            Name = name;
            Hcp = hcp;
            Skill = skill;
            Drives = drives;
            Wedges = wedges;
            Chipping = chipping;
            Puttning = puttning;
            Vinnarskalle = vinnarskalle;
            Alcohol = alcohol;
            // Intro = intro;
            PlayerFlag = playerFlag;
            PlayerImage = playerImage;
            Team = team;
        }
    }
}
