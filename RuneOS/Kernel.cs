using System.IO;
using System.Linq.Expressions;
using System.Text;
using Sys = Cosmos.System;
using RuneOS.Commands;
using Cosmos.System.FileSystem;
using System;
using RuneOS.Graphics;
using System.ComponentModel;
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
       // private CosmosVFS vfs;
       // public static GUITEST gui;


        public static string CurrentDirectory = @"0:\";
        public static string CurrentVolume = @"0:\";

        public static CosmosVFS fs = new Sys.FileSystem.CosmosVFS();
        
        public static byte Second { get; }

        public static byte Hour { get; }

        public static byte Minute { get; }

        //public static GUI gui;
        public static PrisimGUI gui;
      
        protected override void BeforeRun()
        {
            //VGAScreen.SetGraphicsMode(VGADriver.ScreenSize.Size720x480, ColorDepth.ColorDepth16);
            //VGAScreen.SetTextMode(VGADriver.TextSize.Size40x50);
            //Console.OutputEncoding = Cosmos.System.ExtendedASCII.CosmosEncodingProvider.Instance.GetEncoding(437);

            // var fs = new Sys.FileSystem.CosmosVFS();
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);

            
var logo =@"
 ________________________________________________________
|     ____  _   _ _   _ _____    ___  ____       ___     |
|    |  _ \| | | | \ | | ____|  / _ \/ ___|     / \ \    |
|    | |_) | | | |  \| |  _|   | | | \___ \    / / \ \   |
|    |  _ <| |_| | |\  | |___  | |_| |___) |  / /   \_\  |
|    |_| \_\\___/|_| \_|_____|  \___/|____/   \ \   / /  |
|                            THE CYBERDECK OS  \ \ / /   |
|    STARVVOID STUDIOS V0.4.0                   \_/_/    |
 -------------------------------------------------------- ";
            
            
            var freeDiskspace =fs.GetAvailableFreeSpace(@"0:\");
            var fs_type = fs.GetFileSystemType(@"0:\");
            var mbSpace = freeDiskspace / 1000000;
            var diskspace = fs.GetTotalSize(@"0:\");
            var mbSpace1 = diskspace / 1000000;

            // Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(logo);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Press Enter to boot");

            Console.ReadKey();


            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine(logo);
            Console.ForegroundColor = ConsoleColor.Gray;
     

            Console.ForegroundColor = ConsoleColor.White;
            this.commandManager = new CommandManager();
           
            Console.WriteLine(" -------------------------------------------------- ");
            Console.WriteLine("| Disk Space: " + mbSpace + "MB / "+ mbSpace1+"MB                        |");
            Console.WriteLine("| Type 'help' for a list of commands               |");
            Console.WriteLine(" -------------------------------------------------- ");
            Console.ForegroundColor = ConsoleColor.Magenta;


            Console.WriteLine("==================================================================");
            Console.WriteLine("                     CYBER DECK INFO SCREEN");
            Console.WriteLine("==================================================================");
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
            try
            {
                //if (Kernel.gui != null)
                //{
                //    Kernel.gui.handleGUIInputs();
                //    return;

                //}

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






                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(response);
            }
            catch (Exception ex)
            {
                return;

            }

           
        }
    }
}