using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuneOS.Commands
{
    public class Write : Command
    {
        public Write(String name) : base(name) { }

        public override string execute(string[] args)
        {

            //Console.WriteLine("File Name:");
            //var name = Console.ReadLine();
            var directory_list = Directory.GetFiles(@"0:\");

            try
            {   
                var file = Kernel.CurrentDirectory + args[0];
                Console.WriteLine("Input Text");
                var text = Console.ReadLine();
                File.WriteAllText(file, text);
                Console.WriteLine("File Saved");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }









            return "";
        }









    }
}
