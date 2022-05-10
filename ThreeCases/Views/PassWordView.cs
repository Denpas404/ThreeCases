using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ThreeCases.Views
{
    internal class PassWordView
    {
        String inputName;
        String inputPass;


        public PassWordView()
        {                      
            Console.Clear();

            //ClassLibrary.PasswordLogic _passwordLogic;
            

                        
            Console.WriteLine("Username: ");
            inputName = Console.ReadLine();

            Console.WriteLine("Passwerod: ");
            Console.ForegroundColor = ConsoleColor.Black;
            inputPass = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

            PasswordLogic obj = new PasswordLogic(inputName, inputPass);

            obj.import();

            if (obj.Login() == true)
            {
                loggedin();
            }
            else
            {
                Console.WriteLine("Username or password did not match");
            }

            Console.ReadKey();
        }

        public void loggedin()
        {            
           PasswordLogic obj = new PasswordLogic(inputName,inputPass);
            obj.import();

            Console.WriteLine("1: Change username.\n3: Change password.");
            Char choice = Console.ReadKey().KeyChar;

            switch (choice)
            {
                case '1':
                    Console.WriteLine("Input new username: ");
                    String newName = Console.ReadLine();
                    Console.WriteLine(obj.changeName(newName));
                    break;
                case '3':
                    Console.WriteLine("Input new password: ");
                    String newPass = Console.ReadLine();
                   obj.changePass(newPass);
                    break;
                default:
                    break;
            }
        }

    }
}
