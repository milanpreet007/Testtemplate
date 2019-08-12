using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*STUDENT NAME: MILANPREET SINGH
 * STUDENT ID:301044674
 * DESCRIPTION : THIS IS THE MAIN CHARACTER CLASS FOR THE APPLICATION 
  */

namespace Finaltest.Objects
{
   public class CharacterPortfolio
    {
        //identity
        public Identity Identity { get; set; }

        //charaateristics
        public string Strength { get; set; }
        public string Dexterity { get; set; }
        public string Endurance { get; set; }
        public string Intellect { get; set; }
        public string Education { get; set; }
        public string SocialStanding{ get; set; }

        //Skill list
        List<Skill> Skills;

        //constructor
        CharacterPortfolio()
        {
            this.Skills = new List<Skill>();
            this.Identity = new Identity();
        }


    }
}
