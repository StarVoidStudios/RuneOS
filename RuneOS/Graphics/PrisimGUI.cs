using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmos.Core.Memory;
using Cosmos.System;
using IL2CPU.API.Attribs;
using PrismAPI.Graphics;
using PrismAPI.Hardware.GPU;

namespace RuneOS.Graphics
{
    public class PrisimGUI
    {
        //public Canvas canvas;
        public Display canvas;


        

        private MouseState prevMouseState;
        private UInt32 pX, pY;

        [ManifestResourceStream(ResourceName = "RuneOS.images.Cursor.bmp")] static byte[] cursorimg;
        [ManifestResourceStream(ResourceName = "RuneOS.images.testimg.bmp")] static byte[] testback;




        public void init()
        {
        

        canvas = Display.GetDisplay(800, 600);

        MouseManager.ScreenWidth = 800;
		MouseManager.ScreenHeight = 600;

		
          


        }

        public void Draw() 
        {


            canvas.Clear(Color.Cyan);

            canvas.DrawFilledRectangle((int)MouseManager.X, (int)MouseManager.Y, 16, 16, 0, Color.White); // Draw the mouse.
            canvas.DrawString(15, 15, $"{canvas.GetFPS()} FPS", default, Color.White); // The default value will become the default font.


            canvas.Update();
            
            


        }


        public void Run()
        {
            init();

            while (true)
            {
                
                Draw();
                
                Heap.Collect();

            }



        }



        public PrisimGUI() 
        { 
        
        
        
            Run();  
        
        
        }




    }
}
