using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuneOS.Commands
{
    public class Clear : Command
    {
        public Clear(String name) : base(name) { }

        public override string execute(string[] args)
        {

            Console.Clear();

            var logo = @" 
  ____  _   _ _   _ _____    ___  ____  
 |  _ \| | | | \ | | ____|  / _ \/ ___| 
 | |_) | | | |  \| |  _|   | | | \___ \ 
 |  _ <| |_| | |\  | |___  | |_| |___) |
 |_| \_\\___/|_| \_|_____|  \___/|____/ 
    Property of StarVoid Studios: #0001A
            ";

            Console.WriteLine(logo);
            Console.WriteLine("RuneOS Boot Menu");
            return "";

        }




    } 
    
}
