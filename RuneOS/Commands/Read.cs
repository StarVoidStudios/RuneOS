using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RuneOS.Commands
{
    public class Read: Command
    {
        public Read(String name) : base(name) { }

        public override string execute(string[] args)
        {
            
            //Console.WriteLine("File Name:");
            //var name = Console.ReadLine();
            var directory_list = Directory.GetFiles(@"0:\");

            try
            {
                Console.WriteLine(File.ReadAllText(Kernel.CurrentDirectory +args[0]));
            }
            catch(Exception e) 
            { 
                Console.WriteLine(e.ToString());
            }









            return "";
        }
    }   
}
