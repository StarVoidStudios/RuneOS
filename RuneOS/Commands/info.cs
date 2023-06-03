using Cosmos.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RuneOS.Commands
{
    public class info : Command
    {

        public info(String name) : base(name) { }

        public override string execute(string[] args)
        {
            var RAM = CPU.GetAmountOfRAM();
            var cpu = CPU.GetCPUVendorName();
            var uptime = CPU.GetCPUUptime();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("SYSTEM INFORMATION");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("CPU: " + cpu);
            Console.WriteLine("RAM: " + RAM);
            Console.WriteLine("UPTIME: " + uptime);
            Console.WriteLine("OS: RUNE OS");

            return"";
        }
                   
    }
}

