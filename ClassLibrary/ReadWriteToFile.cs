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
        //Path on work pc
        private const string _path = @"C:\Users\denpaa\source\repos\ThreeCases\ThreeCases\infobase.txt";

        //Path on home pc
        //private const string _path = @"C:/Users/dpaas/source/repos/ThreeCases/ThreeCases/infobase.txt";
        
        public ReadWriteToFile()
        { 
        }

        public (string, string) ReadFile()
        {
            String import = File.ReadAllText(_path);
            var splitted = import.Split(';');
            String controllName = splitted[0].ToLower();
            String controllPass = splitted[1];

            return (controllName, controllPass);
        }



        public void WriteToFile(String input)
        {

            File.WriteAllText(_path, input);
        }
    }
}
