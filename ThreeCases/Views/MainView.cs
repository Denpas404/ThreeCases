using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeCases.Views
{
    internal class MainView
    {

        public MainView()
        {
            Console.WriteLine("Please choose:\n\nPress 1 for soccer: \nPress 3 for dance: \nPress 5 for password: ");

            Char choice = Console.ReadKey().KeyChar;

            switch (choice)
            {
                case '1':
                    var soc = new SoccerView();                    
                    break;
                case '3':
                    var dan = new DanceView();
                    break;
                case '5':
                    var pas = new PassWordView();
                    break;
                default:
                    break;
            }
        }
    }
}
