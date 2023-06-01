using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuneOS.Commands
{
    public class Help : Command
    {
        public Help (String name) :base(name) { }

        public override string execute(string[] args)
        {
            return "Rune OS Help:" + "\n" +
             "HELP: SHOWS THIS SCREEN" + "\n" +
             "ABOUT: SHOWS THE ABOUT SCREEN" + "\n" +
             "PWR: -P: SHUTS DOWN THE COMPUTER -R: REBOOTS THE COMPUTER" + "\n" +
             "DIR: LIST FILES" + "\n" +
             "CLS: CLEAR SCREEN" + "\n" +
             "STARTX: LAUNCHES GRAPHICAL USER INTERFACE TEST" + "\n" +
             "MKFILE (FILE NAME): CREATES FILE WITH GIVEN NAME" + "\n" +
             "READ (FILE NAME): READ FILE " + "\n" +
             "WRITE (FILE NAME): ALLOWS YOU TO WRITE TEXT TO GIVEN FILE" + "\n" +
             "DELFILE (FILE NAME): REMOVES THE CHOSEN FILE FROM THE SYSTEM" + "\n" +
             "DEBUG: ADMIN INFO ONLY (REMOVE FROM FINAL BUILD)";



        }



    }
}
