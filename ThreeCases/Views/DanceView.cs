using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ThreeCases.Views
{
    internal class DanceView
    {
        String p1Name;
        String p2Name;
        int p1Score;
        int p2Score;

        bool isValid = false;

        public void danceInput()
        {
            Console.Clear();

            Console.WriteLine("First contestant name: ");
            p1Name = Console.ReadLine();

            while (!isValid)
            {
                Console.WriteLine("First contestant score: ");
                isValid = Int32.TryParse(Console.ReadLine(), out p1Score);
            }

            isValid = false;

            Console.WriteLine("Second contestant name: ");
            p2Name = Console.ReadLine();

            while (!isValid)
            {
                Console.WriteLine("Second contestant score: ");
                isValid= Int32.TryParse(Console.ReadLine(),out p2Score);
            }

        }


        ClassLibrary.DanceLogic _danceLogic;

        public DanceView()
        {

            danceInput();   

            DanceLogic dancer1 = new DanceLogic(p1Name, p1Score);
            DanceLogic dancer2 = new DanceLogic(p2Name, p2Score);

            Console.WriteLine(_danceLogic.Calculate(dancer1 , dancer2));


            Console.ReadKey();

        }
    }
}
