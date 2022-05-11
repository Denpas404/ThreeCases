using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ThreeCases.Views
{
    public class DanceView
    {          
        ClassLibrary.DanceLogic _danceLogic;

        public DanceView()
        {
            _danceLogic = new DanceLogic();

            String name;
            int score = 0;

            bool isValid = false;

            Console.Clear();

            Console.WriteLine("First contestant name: ");
            name = Console.ReadLine();

            while (!isValid)
            {
                Console.WriteLine("First contestant score: ");
                isValid = Int32.TryParse(Console.ReadLine(), out score);
            }

            DanceLogic dancer1 = new DanceLogic(name, score);

            isValid = false;

            Console.WriteLine("\nSecond contestant name: ");
            name = Console.ReadLine();

            GetDanseObject(ref score, ref isValid);
            DanceLogic dancer2 = new DanceLogic(name, score);

            DanceLogic dancer3 = dancer1 + dancer2;

            Console.WriteLine(dancer3.name + ": " + dancer3.score);


            Console.ReadKey();

        }

        private static void GetDanseObject(ref int score, ref bool isValid)
        {
            while (!isValid)
            {
                Console.WriteLine("Second contestant score: ");
                isValid = Int32.TryParse(Console.ReadLine(), out score);
            }
        }



    }
}
