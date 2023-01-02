using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BonkaLottning
{
    public class Players
    {
        

        // Instance Variables
        public string Name { get; set; }
        public int Skill { get; set; }
        public double Hcp { get; set; }
        public string PlayerImage { get; set; }


        // Constructor Declaration of Class
        public Players(string name, double hcp, int skill, string playerImage)
        {
            Name = name;
            Skill = skill;
            Hcp = hcp;
            PlayerImage = playerImage;
        }
    }
}