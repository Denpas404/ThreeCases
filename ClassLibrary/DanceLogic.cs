using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class DanceLogic
    {
        String name;
        int score;


        public DanceLogic(String inputName, int inputScore)
        {
            name = inputName;
            score = inputScore;
        }

        public static DanceLogic operator +(DanceLogic dancer1, DanceLogic dancer2)
        {


            return new DanceLogic(dancer1.score + dancer2.score);
        }

        
    }
}
