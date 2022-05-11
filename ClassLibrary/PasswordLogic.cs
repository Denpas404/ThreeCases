using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary
{
    public class ErrorRespons
    {
        public string ErrorMessege { get; set; }
        public bool Succes { get; set; }
    }

    public class PasswordLogic
    {
        String inputName;
        String inputPass;
        String controllName;
        String controllPass;
        String save = "";
        ReadWriteToFile fileSteam = new ReadWriteToFile();

        public PasswordLogic (string name, string pass)
        {
            inputName = name.ToLower();
            inputPass = pass;

            var fileRead = new ReadWriteToFile().ReadFile();
            controllName = fileRead.Item1;
            controllPass = fileRead.Item2;

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

        public bool checkPass(string pass)
        {
            char c;

            bool upper, lower, symbol, space, notName;
            upper = lower = symbol = space = notName = false;

            if (pass.Length < 12)
            {
                return true; //new ErrorRespons() { ErrorMessege = "", Succes = false };
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

        public String changeName(String name)
        {
            inputName = name.ToLower();
            save = inputName + ";" + controllPass;
            fileSteam.WriteToFile(save);

            return save;
        }

        public void changePass(String pass)
        {
            String save = "";
                        
            if (checkPass(pass) == true)
            {                
                save = controllName + ";" + pass;
                fileSteam.WriteToFile(save);               
            }
            
        }
    }
}
