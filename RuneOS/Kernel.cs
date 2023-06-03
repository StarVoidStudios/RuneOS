using System.IO;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Sys = Cosmos.System;
using RuneOS.Commands;
using Cosmos.System.FileSystem;
using System;
using RuneOS.Graphics;
using System.ComponentModel;
using System.IO.Enumeration;
using Cosmos.System.Graphics;
using Cosmos.HAL;
using Cosmos.HAL.BlockDevice.Registers;
using RuneOS.Utils;
using IL2CPU.API.Attribs;
using Cosmos.Core.Memory;
using System.Drawing;

namespace RuneOS
{
    public class Kernel : Sys.Kernel
    {

        private CommandManager commandManager;
        private CosmosVFS vfs;
        public static GUITEST gui;


        public static string CurrentDirectory = @"0:\";
        public static string CurrentVolume = @"0:\";

        public static CosmosVFS fs = new Sys.FileSystem.CosmosVFS();
        

        protected override void BeforeRun()
        {
            Console.OutputEncoding = Cosmos.System.ExtendedASCII.CosmosEncodingProvider.Instance.GetEncoding(437);

            // var fs = new Sys.FileSystem.CosmosVFS();
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);

            
var logo =@"
╔════════════════════════════════════════════════════════╗
║     ____  _   _ _   _ _____    ___  ____       ___     ║
║    |  _ \| | | | \ | | ____|  / _ \/ ___|     / \ \    ║
║    | |_) | | | |  \| |  _|   | | | \___ \    / / \ \   ║
║    |  _ <| |_| | |\  | |___  | |_| |___) |  / /   \_\  ║
║    |_| \_\\___/|_| \_|_____|  \___/|____/   \ \   / /  ║
║                                              \ \ / /   ║
║    STARVVOID STUDIOS V0.3.10                  \_/_/    ║
╚════════════════════════════════════════════════════════╝";


            var diskspace =fs.GetAvailableFreeSpace(@"0:\");
            var fs_type = fs.GetFileSystemType(@"0:\");
            var mbSpace = diskspace / 1000000;
            
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine(logo);
            Console.ForegroundColor = ConsoleColor.Gray;
     

            Console.ForegroundColor = ConsoleColor.White;
            this.commandManager = new CommandManager();

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
            //Console.ForegroundColor = ConsoleColor.White;

        }

        protected override void Run()
        {

            var userFiles = @"0:\users.dat";

            if (!File.Exists(userFiles))
            {
                File.Create(userFiles);
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("RuneOS$");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(CurrentDirectory);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(">");
            Console.ForegroundColor = ConsoleColor.Yellow;
            String response;
            response = commandManager.input(Console.ReadLine().ToLower());
            //if (response == "read")
            //{
            //    Console.WriteLine("File Name: ");
            //    var nameFile = Console.ReadLine();
            //}
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(response);


        }
    }
}