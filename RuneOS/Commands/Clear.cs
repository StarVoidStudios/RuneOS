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
║                                              \ \ / /   ║
║    STARVVOID STUDIOS V0.3.10                  \_/_/    ║
╚════════════════════════════════════════════════════════╝";

            Console.WriteLine(logo);
            var diskspace = Kernel.fs.GetAvailableFreeSpace(@"0:\");
            var fs_type = Kernel.fs.GetFileSystemType(@"0:\");
            var mbSpace = diskspace / 1000000;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("RuneOS Boot Menu");
            //Console.WriteLine("FileSystem: " + fs_type);
            Console.WriteLine("Free Disk: " + mbSpace + "MB");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
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
