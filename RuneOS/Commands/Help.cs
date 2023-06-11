using Cosmos.System;
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
            return " " + "\n" + "Rune OS Help:" + "\n" +

            "=================================================="+"\n"+
            "Help: Brings up this text" + "\n" +
            "About: List info about the Operating System" + "\n" +
            "PWR: <Args: -r -p> Controls power to the computer" + "\n" +
            "DIR: List the files and directorys on the root of the drive" + "\n" +
            "Mkfile <Filename.Ext>: Creates a file with the given name and extension"+ "\n" +
            "Rmfile <Filename>: Removes the chosen file from the drive" + "\n" +
            "Mkdir <Dir Name>: Creates a directory with the given name" + "\n" +
            "Rmdir <Dir Name>: Removes the chosen directory" + "\n" +
            "Peek <Dir Name/path>: Shows Files inside a diretory or path" + "\n" +
            "Cat <Filename>: Prints out the contents of a given file" + "\n" +
            "Miv: Launches the MIV text editor" + "\n" +
            "CLS: Clears the screen and reprints the logo" + "\n"+
            "==================================================";

            


        }



    }
}
