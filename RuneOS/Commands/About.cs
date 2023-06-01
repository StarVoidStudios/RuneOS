using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuneOS.Commands
{
    public class About : Command
    {
        public About(String name) : base(name) { }

        public override string execute(string[] args)
        {
            return "RUNE OS V0.3.0|| CODED BY: ENDERGAMES@STARVOIDSTUDIOS" + "\n" +
                "CODENAME: APOLLO ||| VERSION 0.3.0.61230001(NR)" + "\n" +
                "NOT FOR RELEASE || PROPERTY OF STARVOID STUDIOS";


        }




    }
}
