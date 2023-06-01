using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sys = Cosmos.System;

namespace RuneOS.Commands
{
    public class Power : Command
    {
        public Power(String name): base(name) { }


        public override string execute(string[] args)

        {

            if (args[0] == "-r")
            {
                Sys.Power.Reboot();
                return "Restarting...";

            }
            else if (args[0] == "-p")
            {
                Sys.Power.Shutdown();
                return "Shutting Down...";
            }
            return "";
        }




    }
}
