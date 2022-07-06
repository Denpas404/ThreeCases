using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary
{
    internal class ReadWriteToFile
    {       

        string fileName = "infobase.txt";
        string _path;


        public ReadWriteToFile()
        {
            _path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);
        }

        public (string, string) ReadFile()
        {
            String import = File.ReadAllText(Path.Combine(Environment.CurrentDirectory, @"Data\", fileName));
            var splitted = import.Split(';');
            String controllName = splitted[0].ToLower();
            String controllPass = splitted[1];

            return (controllName, controllPass);
        }



        public void WriteToFile(String input)
        {
            File.WriteAllText(Path.Combine(Environment.CurrentDirectory, @"Data\", fileName), input);
        }
    }
}
