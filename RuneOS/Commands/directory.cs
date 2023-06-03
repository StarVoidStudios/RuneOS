using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RuneOS.Commands
{
    public class directory : Command
    {
        public directory(string name) : base(name) { }


        public override string execute(string[] args)
        {
            var directory_list = Directory.GetFiles(Kernel.CurrentDirectory);
            var directory = Directory.GetDirectories(Kernel.CurrentDirectory);

            try
            {

                Console.WriteLine("<ITEMS IN:" + Kernel.CurrentDirectory + ">");
                foreach (var dir in directory)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("<DIR> ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(dir);
                    Console.Write("\n");
                }                
                foreach (var file in directory_list)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("<FILE> ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(file);
                    Console.Write("\n");
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return "";


        }




    }
}
