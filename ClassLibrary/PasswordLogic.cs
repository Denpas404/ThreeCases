using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary
{
    public class PasswordLogic
    {
        String inputName;
        String inputPass;
        String controllName;
        String controllPass;


        public PasswordLogic (string name, string pass)
        {
            inputName = name.ToLower();
            inputPass = pass;   
        }

        public void import()
        {
            String import = File.ReadAllText(@"C:\Users\denpaa\source\repos\ThreeCases\ThreeCases\infobase.txt");
            var splitted = import.Split(';');
            controllName = splitted[0].ToLower();
            controllPass = splitted[1];
        }

        public bool Login()
        {
            bool ok = false;

            if (inputName == controllName && inputPass == controllPass)
            {
                ok = true;
            }
            return ok;
        }

        public string changeName(String name)
        {
            import();

            inputName = name.ToLower();
            String save = inputName + ";" + controllPass;
            File.WriteAllText(@"C:\Users\denpaa\source\repos\ThreeCases\ThreeCases\infobase.txt", save);

            return save;
        }

        public bool checkPass(string pass)
        {
            char c;

            bool upper, lower, number, symbol, space, notName;
            upper = lower = number = symbol = space = notName = false;

            if (pass.Length < 12)
            {
                return false;
            }

            if (char.IsDigit(pass[0]) == true)
            {
                return true;
            }

            if (char.IsDigit(pass[pass.Length - 1]) == true)
            {
                return true;
            }

            for (int i = 0; i < pass.Length; i++)
            {
                c = pass[i];

                if (char.IsUpper(c))
                {
                    upper = true;
                }
                if (char.IsLower(c))
                {
                    lower = true;
                }
                //if (char.IsNumber(c))
                //{
                //    number = true;
                //}
                if (char.IsSymbol(c))
                {
                    symbol = true;
                }
                if(!char.Equals(c, " "))
                {
                    space = true;
                }
                if (controllName.ToLower() != pass.ToLower())
                {
                    notName=  true;
                }
                if (upper && lower && symbol && space && notName)
                {
                    return true;
                }               
            }            
            return true;
        }
        public string changePass(String pass)
        {
            String save = "";
            import();
            if (checkPass(pass) == true)
            {                
                save = controllName + ";" + pass;
                File.WriteAllText(@"C:\Users\denpaa\source\repos\ThreeCases\ThreeCases\infobase.txt", save);
            }
            return save;
        }
    }
}
