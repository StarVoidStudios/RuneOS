using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuneOS.Commands
{
    public class Mkfile : Command
    {
        public Mkfile(String name) : base(name) { }

        public override string execute(string[] args)
        {

            //Console.WriteLine("File Name:");
            //var name = Console.ReadLine();
            var directory_list = Directory.GetFiles(@"0:\");

            try
            {
                var file_stream = File.Create(@"0:\" + args[0]);
                Console.WriteLine("File "+ args[0]+ " Was Created");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }









            return "";


        }
    }
}
