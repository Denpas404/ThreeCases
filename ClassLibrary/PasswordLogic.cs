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

        public void PasswordLogicInput(string name, string pass)
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

        public ErrorRespons checkPass(string pass)
        {
            char c;

            bool upper, lower, symbol, space, notName;
            upper = lower = symbol = space = notName = false;

            if (pass.Length < 12)
            {
                return new ErrorRespons() { ErrorMessege = "Password is to short", Succes = false };                
                //return false; 
            }

            if (char.IsDigit(pass[0]))
            {
                return new ErrorRespons() { ErrorMessege = "First letter can not be a number", Succes = false };
                //return false;
            }

            if (char.IsDigit(pass[pass.Length - 1]))
            {
                return new ErrorRespons() { ErrorMessege = "Last letter can not be a number", Succes = false };
                //return false;
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
                
            }
            if (upper && lower && symbol && space && notName)
            {
                return new ErrorRespons() { ErrorMessege = "upper && lower && symbol && space && notName = ok ", Succes = false };
                //return true;
            }
            return new ErrorRespons() { ErrorMessege = "", Succes = false };
            //return true;
        }

        public String changeName(String name)
        {
            inputName = name.ToLower();
            save = inputName + ";" + controllPass;
            fileSteam.WriteToFile(save);

            return "Username changed";
        }

        public String changePass(String pass)
        {
            String save = "";
            String status = checkPass(pass).ErrorMessege;

            if (checkPass(pass).Equals(true))
            {            
                save = controllName + ";" + pass;
                fileSteam.WriteToFile(save);
                status = "Password changed";
            }
            else  
            {
                Console.WriteLine(status);
            }

            return status ;
        }
    }
}
