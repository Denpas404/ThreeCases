using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class DanceLogic
    {
        public String name;
        public int score;

        public DanceLogic()
        {
        }               

        public DanceLogic(String name, int score)
        {
            this.name = name;
            this.score = score;
        }

        public static DanceLogic operator +(DanceLogic dancer1, DanceLogic dancer2)
        {
            return new DanceLogic(dancer1.name + " & " + dancer2.name, dancer1.score + dancer2.score);
        }
    }
}
