using Cosmos.System.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Sys = Cosmos.System;


namespace RuneOS.Graphics
{
    public class Tabbar
    {
        private Pen pen;
        private Pen pen2;
        private Pen pen3;
        private Int32 rows, columns;




        public Tabbar(Canvas canvas)
        {
            this.pen = new Pen(Color.Blue);
            this.pen2 = new Pen(Color.Green);
            this.pen3 = new Pen(Color.Red);
            this.rows = canvas.Mode.Rows;
            this.columns = canvas.Mode.Columns;

            canvas.DrawFilledRectangle(this.pen, 0, this.rows - 40, this.columns, 40);
            canvas.DrawFilledRectangle(this.pen2, 0, this.rows - 40, 100, 40);
            //canvas.DrawLine(this.pen3, 25, this.rows - 90, 40, this.rows - 10);


        }
        
        public void tryProcessTabBarClick(Int32 mouseX, Int32 mouseY) 
        {
            if (new Rectangle(mouseX, mouseY, 1, 1).IntersectsWith(new Rectangle(0, this.rows - 40, 100, 40)))
            {
                Console.Beep();
                Sys.Power.Shutdown();

            }
        
        
        
        
        
        
        
        
        
        
        }










    }
}
