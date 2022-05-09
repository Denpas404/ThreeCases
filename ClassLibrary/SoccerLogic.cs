using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class SoccerLogic
    {
        public string Calculate(int inputPass, int inputGoal)
        {
            int pass = inputPass;
            int goal = inputGoal;
            StringBuilder sb = new StringBuilder();

            if (pass < 1)
            {
                Console.WriteLine("Shh");
            }
            else if (pass >= 1)
            {
                Console.WriteLine("*High FIVE* - Juhuuu ");
                if (pass >= 1 && pass <= 10)
                {
                    for (int i = 0; i < pass; i++)
                    {
                        sb.Append("Huh! ");
                    }
                }
            }
            if (goal > 0 )
            {
                sb.Append("Olé olé olé");
            }


            String jubel = sb.ToString();
            return jubel;
        }
    }
}
