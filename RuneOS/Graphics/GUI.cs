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
using PrismAPI.Hardware.GPU;

using Cosmos.Core.Memory;


namespace RuneOS.Graphics
{
    public class GUI
    {

        public Canvas canvas;
        //private Pen pen;


        private MouseState prevMouseState;
        private UInt32 pX, pY;

        [ManifestResourceStream(ResourceName = "RuneOS.images.Cursor.bmp")] static byte[] cursorimg;
        [ManifestResourceStream(ResourceName = "RuneOS.images.testimg.bmp")] static byte[] testback;

        public static Bitmap bmp = new Bitmap(cursorimg);
        public static Bitmap background = new Bitmap(testback);



        public void Init()
        {
            
            canvas = FullScreenCanvas.GetFullScreenCanvas(new Mode(640, 480, ColorDepth.ColorDepth32));
            canvas.Clear(Color.Black);

            
            prevMouseState = MouseState.None;

            MouseManager.ScreenHeight = 480;
            MouseManager.ScreenWidth = 640;

            
        }



        public void draw()
        {
            // Draws the Main Screen for the GUI
            canvas.DrawImageAlpha(background, 0, 0);
            canvas.DrawFilledRectangle(Color.Gray, 0, 0, 638, 20);
            canvas.DrawFilledRectangle(Color.DarkGray, 1, 1, 120, 18);
            //canvas.DrawFilledRectangle(new Pen(Color.Red), 630, 0, 10, 20);
            canvas.DrawFilledRectangle(Color.Gray, 620, 460, 640, 20);

            //DRAWS THE TEXT AND TIME
            var time = "" + DateTime.Now;
            canvas.DrawString("RUNE OS HOME", PCScreenFont.Default, (Color.White), 300, 5);
            canvas.DrawString(time, PCScreenFont.Default, Color.Black, 1, 1);

            //Draws a ICON

            canvas.DrawFilledRectangle(Color.Blue, 50, 50, 40, 40);

            

            // Sets Mouse Image

            canvas.DrawImageAlpha(bmp, (int)MouseManager.X, (int)MouseManager.Y);
            canvas.Display();

        }

        public void run()
        {
            Init();
            while (true)
            {

                draw();
                Heap.Init();
                Heap.Collect();
                

            }


        }
               


        public GUI()
        {
            run();
        }







            
             




           







 

            

                
               
          









               

            


        }



        
    }



 

