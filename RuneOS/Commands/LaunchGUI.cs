using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmos.System.Graphics;
using RuneOS.Graphics;

namespace RuneOS.Commands
{
    public class LaunchGUI : Command
    {
        public LaunchGUI(String name) : base(name) { }

        public override String execute(String[] args)
        {

            if (Kernel.gui != null)
                return "GUI ALREADY ACTIVE";

            Kernel.gui = new GUI();
            






            return"GUI LAUNCHED";
        }

    }
}
