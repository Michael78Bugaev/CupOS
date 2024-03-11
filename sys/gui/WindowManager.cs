using Cosmos.System.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cup.sys.gui
{
    public class Window
    {
        public string Name;
        public int X;
        public int Y;
        public int Width;
        public int Height;
        bool was_wh;
        public Window(int x, int y, string name) // 577, 368
        {
            X = x;
            Y = y;
            Name = name;
            was_wh = false;
            Width = 577;
            Height = 368;
        }
        public Window(int x, int y, int height, int width, string name)
        {
            X=x;
            Y=y;
            Width = width;
            Height = height;
            Name = name;
            was_wh = true;
        }
        public void DrawWindow()
        {
            if (was_wh)
            {
                GUI.canvas.DrawFilledRectangle(new(Color.Black), 0, 678, 171, 342);
                GUI.canvas.DrawRectangle(new(Color.DarkGray), 0, 678, 171, 342);
            }
            else
            {

            }
        }
    }
}
