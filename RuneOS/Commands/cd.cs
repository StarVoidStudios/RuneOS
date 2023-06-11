using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RuneOS.Commands;
using RuneOS.Utils;


namespace RuneOS.Commands
{
    public class cd : Command
    {

        public cd(String name) : base(name) { }

        public override string execute(string[] args)
        {

            var dir = args[0];
            var lastDir = Directory.GetCurrentDirectory();

            try
            {

                if (args[0] == "..")
                {

                    Directory.SetCurrentDirectory(Kernel.CurrentDirectory);
                    var root = Kernel.fs.GetDirectory(Kernel.CurrentDirectory);

                    if (Kernel.CurrentDirectory != Kernel.CurrentVolume)
                    {
                        Kernel.CurrentDirectory = root.mParent.mFullPath;
                    }


                }
                else if (dir == Kernel.CurrentVolume)
                {
                    Kernel.CurrentDirectory = Kernel.CurrentVolume;
                }
                else
                {
                    if (Directory.Exists(Kernel.CurrentDirectory + dir))
                    {
                        Directory.SetCurrentDirectory(Kernel.CurrentDirectory);
                        Kernel.CurrentDirectory = Kernel.CurrentDirectory + dir + @"\";
                    }
                    else if (File.Exists(Kernel.CurrentDirectory + dir))
                    {
                        return "ERROR: THIS IS A FILE NOT A DIR";
                    }
                    else
                    {
                        return "ERROR: DIR NOT FOUND";
                    }
                }

                return " ";

            }

            catch (Exception ex)
            {
                Debug.ErrorScreen(" ");
                return " ";
            }

         }



    }

}


