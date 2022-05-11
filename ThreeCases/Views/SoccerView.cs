using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ThreeCases.Views
{
    internal class SoccerView
    {
        int passes;
        String goals;

        public void userInput()
        {
            bool isValid = false;
            Console.Clear();

            while (!isValid)
            {
                Console.WriteLine("How many passes: ");
                isValid = int.TryParse(Console.ReadLine(), out passes);
            }

            Console.WriteLine("Are there any goals? ");
            goals = Console.ReadLine();

        }

        SoccerLogic _soccerLogic;

        public SoccerView()
        {
            userInput();

            _soccerLogic = new SoccerLogic();

            String text = _soccerLogic.Calculate(passes, goals);

            Console.WriteLine(text);

            Console.ReadKey();
        }
    }
}
