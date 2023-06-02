using Cosmos.System.Graphics;
using IL2CPU.API.Attribs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Cosmos.Core.Memory;

namespace RuneOS.Graphics
{
    public class GUI
    {

        private static Canvas canvas;

        [ManifestResourceStream(ResourceName = "testimg.bmp")] public static byte[] test_image;
        public static Bitmap bmp = new Bitmap(test_image);


        public void gui()
        {



            canvas = FullScreenCanvas.GetFullScreenCanvas();
            canvas.DrawFilledRectangle(new Pen(Color.White), 0, 0, 1920, 1080);
            canvas.DrawImage(bmp,50,50);

            Heap.Collect();



            canvas.Display();

            
        }
        



    }
}
