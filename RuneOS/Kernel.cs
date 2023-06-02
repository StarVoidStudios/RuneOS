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

        private static Canvas canvas;

        [ManifestResourceStream(ResourceName = "testimg.bmp")] public static byte[] test_image;
        public static Bitmap bmp = new Bitmap(test_image);






        protected override void BeforeRun()
        {
            
            var fs = new Sys.FileSystem.CosmosVFS();
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);

            var logo = @" 
  ____  _   _ _   _ _____    ___  ____  
 |  _ \| | | | \ | | ____|  / _ \/ ___| 
 | |_) | | | |  \| |  _|   | | | \___ \ 
 |  _ <| |_| | |\  | |___  | |_| |___) |
 |_| \_\\___/|_| \_|_____|  \___/|____/   
    Property of StarVoid Studios: #0001A
            ";

            var diskspace =fs.GetAvailableFreeSpace(@"0:\");
            var fs_type = fs.GetFileSystemType(@"0:\");
            var mbSpace = diskspace / 1000000;
           
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine(logo);
            
        
            this.commandManager = new CommandManager();

            Console.WriteLine("RuneOS Boot Menu");
            Console.WriteLine("FileSystem: " + fs_type);
            Console.WriteLine("Free Disk: " + mbSpace + "MB");
            

        }

        protected override void Run()
        {

            canvas = FullScreenCanvas.GetFullScreenCanvas();
            canvas.DrawFilledRectangle(new Pen(Color.White), 0, 0, 1920, 1080);
            canvas.DrawImage(bmp, 50, 50);

            Heap.Collect();

            canvas.Display();

            var userFiles = @"0:\users.dat";

            if (!File.Exists(userFiles))
            {
                File.Create(userFiles);
            }


            Console.Write("$:" + ">");
            String response;
            response = commandManager.input(Console.ReadLine().ToLower());
            //if (response == "read")
            //{
            //    Console.WriteLine("File Name: ");
            //    var nameFile = Console.ReadLine();
            //}
            Console.WriteLine(response);


        }
    }
}