using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sys = Cosmos.System;
using Cosmos.System;
using System.Drawing;
using Cosmos.System.Graphics;
using IL2CPU.API.Attribs;
using Cosmos.System.Graphics.Fonts;

namespace RuneOS.Graphics
{
    public class GUI
    {

        public Canvas canvas;
        private Pen pen;


        private MouseState prevMouseState;
        private UInt32 pX, pY;

        [ManifestResourceStream(ResourceName = "RuneOS.images.Cursor.bmp")] static byte[] cursorimg;
        [ManifestResourceStream(ResourceName = "RuneOS.images.testimg.bmp")] static byte[] testback;

        public static Bitmap bmp = new Bitmap(cursorimg);
        public static Bitmap background = new Bitmap(testback);

        public GUI()
        {



            canvas = FullScreenCanvas.GetFullScreenCanvas(new Mode(640, 480, ColorDepth.ColorDepth32));
            canvas.Clear(Color.Black);

            pen = new Pen(Color.Black);
            prevMouseState = MouseState.None;

            canvas.DrawImageAlpha(background, 0, 0);

            canvas.DrawFilledRectangle(new Pen(Color.Gray), 0, 0, 638, 20);
            canvas.DrawFilledRectangle(new Pen(Color.DarkGray), 1, 1, 120, 18);

            canvas.DrawString("RUNE OS", PCScreenFont.Default, new Pen(Color.White), 320, 5);
            canvas.DrawString("10:00", PCScreenFont.Default, new Pen(Color.Black), 40, 4);

            


            MouseManager.ScreenHeight = (UInt32)canvas.Mode.Rows;
            MouseManager.ScreenWidth = (UInt32)canvas.Mode.Columns;


            this.pX = MouseManager.X;
            this.pY = MouseManager.Y;

            canvas.DrawImageAlpha(bmp, (Int32)MouseManager.X, (Int32)MouseManager.Y);


            if (MouseManager.MouseState == MouseState.Left && this.prevMouseState != MouseState.Left)
            {

                System.Console.Beep(500, 500);
                Sys.Power.Reboot();
            }




            canvas.Display();

        }




    }



 }

