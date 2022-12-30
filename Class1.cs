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
        String Name;
        int Skill;
        double Hcp;
        String PlayerImage;


        // Constructor Declaration of Class
        public Players(String name, double hcp, int skill, string playerImage)
        {
            Name = name;
            Skill = skill;
            Hcp = hcp;
            PlayerImage = playerImage;
        }
    }
}