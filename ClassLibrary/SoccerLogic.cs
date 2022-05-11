using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class SoccerLogic
    {
        public string Calculate(int inputPass, String inputGoal)
        {
            int pass = inputPass;
            String goal = inputGoal;
            StringBuilder sb = new StringBuilder();


            if (goal.ToLower() == "goal" || goal.ToLower() == "yes")
            {
                sb.Append("Olé olé olé");
            }
            else if (pass < 1)
            {
                sb.Append("Shh");
            }
            else if (pass > 1 && pass <= 9)
            {                
                    for (int i = 0; i < pass; i++)
                    {
                        sb.Append("Huh! ");
                    }              
            }
            else if (pass > 9 )
            {
                sb.Append("*High FIVE* - Juhuuu ");
            }
            
            String jubel = sb.ToString();
            return jubel;
        }
    }
}
