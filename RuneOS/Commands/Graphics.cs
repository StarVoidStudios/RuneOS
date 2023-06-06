using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Cosmos.Core.IOGroup;
using Cosmos.HAL;
using Cosmos.System.Graphics;
using Cosmos.System.Graphics.Fonts;
using IL2CPU.API.Attribs;
using Sys = Cosmos.System;
using RuneOS.Commands;
using Cosmos.System;


namespace RuneOS.Commands
{

    
    public class Graphics : Command
    {
        //private Pen pen;
        Canvas canvas;
        private CommandManager cmd;
        public static class MouseManager {   

        public static uint X;
        public static uint Y;
        public static MouseState MouseState;
        public static uint ScreenHeight;
        public static uint ScreenWidth;



        };

  


        [ManifestResourceStream(ResourceName = "RuneOS.images.Cursor.bmp")] static byte[] cursorimg;
        [ManifestResourceStream(ResourceName = "RuneOS.images.testback.bmp")] static byte[] testback;

        public static Bitmap bmp = new Bitmap(cursorimg);
        public static Bitmap background = new Bitmap(testback);
        public Graphics(String name) : base(name) { }

       

        ConsoleKeyInfo cki;


        public override string execute(string[] args)
        {

            canvas = FullScreenCanvas.GetFullScreenCanvas(new Mode(640, 480, ColorDepth.ColorDepth32));
            canvas.Clear(Color.Black);

            
     

            try
            {
                MouseManager.ScreenWidth = 640;
                MouseManager.ScreenHeight = 480;
                
                Pen pen = new Pen(Color.Aqua);
                canvas.DrawImageAlpha(background,0,0);

                //canvas.DrawFilledRectangle(new Pen(Color.Gray), 0, 0, 638, 20);
                //canvas.DrawFilledRectangle(new Pen(Color.DarkGray), 1, 1, 120 , 18);

                //canvas.DrawString("RUNE OS", PCScreenFont.Default, new Pen(Color.White), 320, 5);
                //canvas.DrawString("10:00", PCScreenFont.Default, new Pen(Color.Black), 40, 4);


                //canvas.DrawString("", PCScreenFont.Default, new Pen(Color.Gold), 5, 400); 
               // canvas.DrawImageAlpha(bmp,(int)MouseManager.X,(int)MouseManager.Y); // drawing mouse

                canvas.Display(); // Required for something to be displayed when using a double buffered driver


                System.Console.ReadKey();
                Sys.Power.Reboot();

                //Console.ReadKey();
               // Sys.Power.Reboot();
            }
            catch (Exception e)
            {

                Sys.Power.Shutdown();
            }

            return "";













        }











    }
}
