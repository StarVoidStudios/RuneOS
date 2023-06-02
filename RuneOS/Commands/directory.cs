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
                foreach (var file in directory_list)
                { 
                    Console.WriteLine("<FILE> " + file);
                }
                foreach (var dir in directory)
                {
                    Console.WriteLine("<DIR> " + dir);
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
