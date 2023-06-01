using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RuneOS.Application;

namespace RuneOS.Commands
{
    public class miv : Command
    {
        public miv(String name) : base(name) { }

        public override string execute(string[] args)
        {

            MIV.StartMIV();
            return "";

        }

    }
}
