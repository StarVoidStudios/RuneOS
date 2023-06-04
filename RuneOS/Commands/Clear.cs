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

            Console.ForegroundColor = ConsoleColor.Red;
            var logo = @"
╔════════════════════════════════════════════════════════╗
║     ____  _   _ _   _ _____    ___  ____       ___     ║
║    |  _ \| | | | \ | | ____|  / _ \/ ___|     / \ \    ║
║    | |_) | | | |  \| |  _|   | | | \___ \    / / \ \   ║
║    |  _ <| |_| | |\  | |___  | |_| |___) |  / /   \_\  ║
║    |_| \_\\___/|_| \_|_____|  \___/|____/   \ \   / /  ║
║                            THE CYBERDECK OS  \ \ / /   ║
║    STARVVOID STUDIOS V0.3.10                  \_/_/    ║
╚════════════════════════════════════════════════════════╝";

            var freeDiskspace = Kernel.fs.GetAvailableFreeSpace(@"0:\");
            var fs_type = Kernel.fs.GetFileSystemType(@"0:\");
            var mbSpace = freeDiskspace / 1000000;
            var diskspace = Kernel.fs.GetTotalSize(@"0:\");
            var mbSpace1 = diskspace / 1000000;

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine(logo);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.White;
           
            Console.WriteLine("╔══════════════════════════════════════════════════╗");
            Console.WriteLine("║ Disk Space: " + mbSpace + "MB / " + mbSpace1 + "MB                        ║");
            Console.WriteLine("║ Type 'help' for a list of commands               ║");
            Console.WriteLine("╚══════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("CyberDeck Home Screen");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;

            return "";

        }




    } 
    
}
