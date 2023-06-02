using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmos.System.Graphics;
using System.Drawing;
using Sys = Cosmos.System;
using Cosmos.System;
using System.Linq.Expressions;
using Cosmos.System.Graphics.Fonts;

namespace RuneOS.Graphics
{
    public class GUITEST
    {

            private Canvas canvas;
            private Pen pen;
            private List<Tuple<Sys.Graphics.Point, Color>> savedPixles;

            private MouseState prevMouseState;

            private Tabbar tabBar;


            private UInt32 pX, pY;


            public GUITEST()
            {

                this.canvas = FullScreenCanvas.GetFullScreenCanvas();
                this.canvas.Clear(Color.White);

                this.pen = new Pen(Color.Black);
                this.prevMouseState = MouseState.None;

                this.pX=3;
                this.pY=3;
                this.savedPixles = new List<Tuple<Sys.Graphics.Point, Color>>();


            


                this.tabBar = new Tabbar(this.canvas);

                MouseManager.ScreenHeight = (UInt32)this.canvas.Mode.Rows;
                MouseManager.ScreenWidth = (UInt32)this.canvas.Mode.Columns;

            }

            public void handleGUInputs()
            {

                if (this.pX != MouseManager.X && this.pY != MouseManager.Y)
                {

                    if (MouseManager.X < 2 || MouseManager.Y < 2 || MouseManager.X > (MouseManager.ScreenWidth - 2) || MouseManager.Y > (MouseManager.ScreenWidth - 2))
                        return;


                    pX = MouseManager.X;
                    this.pY = MouseManager.Y;

                    Sys.Graphics.Point[] points = new Sys.Graphics.Point[]
                    {
                        new Sys.Graphics.Point((Int32)MouseManager.X,(Int32)MouseManager.Y),
                        new Sys.Graphics.Point((Int32)MouseManager.X+1,(Int32)MouseManager.Y),
                        new Sys.Graphics.Point((Int32)MouseManager.X-1,(Int32)MouseManager.Y),
                        new Sys.Graphics.Point((Int32)MouseManager.X,(Int32)MouseManager.Y+1),
                        new Sys.Graphics.Point((Int32)MouseManager.X,(Int32)MouseManager.Y-1)

                    };

                    foreach (Tuple<Sys.Graphics.Point, Color> pixelData in this.savedPixles)
                    {
                        this.canvas.DrawPoint(new Pen(pixelData.Item2), pixelData.Item1);
                    }
               
                    this.savedPixles.Clear();

                    foreach (Sys.Graphics.Point p in points)
                    {
                        this.savedPixles.Add(new Tuple<Sys.Graphics.Point, Color>(p, this.canvas.GetPointColor(p.X, p.Y)));
                        this.canvas.DrawPoint(this.pen, p);


                    }


                }
                if (MouseManager.MouseState == MouseState.Left && this.prevMouseState!=MouseState.Left)
                    System.Console.Beep();

                this.prevMouseState = MouseManager.MouseState;

                this.canvas.Display();


        }   
        



    }
}
