using Cosmos.System.FileSystem;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuneOS.Commands
{
    public class rmdir : Command
    {

        public rmdir(String name) : base(name) { }

        public override string execute(string[] args)
        {

            //Console.WriteLine("File Name:");
            //var name = Console.ReadLine();
            var directory_list = Directory.GetFiles(@"0:\");

            try
            {
                Directory.Delete(Kernel.CurrentDirectory + args[0]);
                Console.WriteLine("Directory " + args[0] + " Was Removed");

                if (Kernel.CurrentDirectory == args[0])
                {
                    return "CANNOT DELETE DIR YOU ARE CURRENTLY IN PLEASE BACK OUT AND TRY AGIAN";
                }

                


            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }


            return "";

            



        }
    }
}