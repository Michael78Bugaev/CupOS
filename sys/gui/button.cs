using Cosmos.System;
using Cosmos.System.Graphics;
using System.Drawing;

namespace Cup.sys.gui
{
    public class Button
    {
        public enum State
        {
            None,
            MouseIsOver,
            MouseIsPressed
        }
        public bool des = false;
        bool q = false;
        bool IsImage;
        public string text;
        Bitmap image;
        public int X;
        public int Y;
        public int height = 8 + 16 + 8;
        public int width;
        public bool was_clicked = false;
        public State state;
        public Button(string text, int x, int y, bool desmenu)
        {
            des = desmenu;
            this.text = text;
            X = x;
            Y = y;
            //if (text.Length < 4) { width = 40; }
            //else if (text.Length > 4 && text.Length < 9) { width = 100; }
            //else if (text.Length == 9) { width = 100; }
            //else if (text.Length == 10) { width = 120; }
            //else if (text.Length == 11) { width = 140; }
            //else if (text.Length == 12) { width = 180; }
            width = text.Length * 10 + 8;
            IsImage = false;
        }
        public Button(int x, int y, Bitmap image, bool desmenu)
        {
            this.image = image;
            X = x;
            Y = y;
            IsImage = true;
            des = desmenu;
            width = (int)image.Width + 4;
            height = (int)image.Height + 4;
        }
        // None
        //  GUI.canvas.DrawFilledRectangle(new (Color.FromArgb(0, 48, 48, 48)), X, Y, width, height);
        //  GUI.canvas.DrawRectangle(new (Color.FromArgb(0, 30, 30, 30)), X, Y, width, height);
        //
        //  BitFont.DrawBitFontString("Ordinary Font", Color.White, text, X + 8, Y + 8);

        // Mouse over
        // GUI.canvas.DrawFilledRectangle(new(Color.FromArgb(0, 30, 30, 48)), X, Y, width, height);
        // GUI.canvas.DrawRectangle(new (Color.FromArgb(0, 30, 30, 100)), X, Y, width, height);

        // BitFont.DrawBitFontString("Ordinary Font", Color.White, text, X + 8, Y + 8);

        // Was clicked
        // GUI.canvas.DrawFilledRectangle(new(Color.FromArgb(0, 30, 30, 60)), X, Y, width, height);
        // GUI.canvas.DrawRectangle(new (Color.FromArgb(0, 30, 30, 100)), X, Y, width, height);

        // BitFont.DrawBitFontString("Ordinary Font", Color.White, text, X + 8, Y + 8);

        public void Draw() // 8
        {
            if (!IsImage)
            {
                if (des)
                {
                    if (!q)
                    {
                        if (!IsMouseOver())
                        {
                            GUI.canvas.DrawFilledRectangle(new(Color.FromArgb(0, 48, 48, 48)), X, Y, width, height);
                            GUI.canvas.DrawRectangle(new(Color.FromArgb(0, 30, 30, 30)), X, Y, width, height);

                            BitFont.DrawBitFontString("Ordinary Font", Color.White, text, X + 8, Y + 8);
                        }
                        else if (IsMouseOver())
                        {
                            GUI.canvas.DrawFilledRectangle(new(Color.FromArgb(0, 30, 30, 48)), X, Y, width, height);
                            GUI.canvas.DrawRectangle(new(Color.FromArgb(0, 30, 30, 100)), X, Y, width, height);

                            BitFont.DrawBitFontString("Ordinary Font", Color.White, text, X + 8, Y + 8);
                        }
                        else if (WasClicked())
                        {
                            GUI.canvas.DrawFilledRectangle(new(Color.FromArgb(0, 30, 30, 60)), X, Y, width, height);
                            GUI.canvas.DrawRectangle(new(Color.FromArgb(0, 30, 30, 100)), X, Y, width, height);

                            BitFont.DrawBitFontString("Ordinary Font", Color.White, text, X + 8, Y + 8);
                            was_clicked = true;
                            q = true;
                        }
                    }
                    else
                    {
                        if (!IsMouseOver())
                        {
                            GUI.canvas.DrawFilledRectangle(new(Color.FromArgb(0, 30, 30, 60)), X, Y, width, height);
                            GUI.canvas.DrawRectangle(new(Color.FromArgb(0, 30, 30, 100)), X, Y, width, height);

                            BitFont.DrawBitFontString("Ordinary Font", Color.White, text, X + 8, Y + 8);
                        }
                        else if (IsMouseOver())
                        {
                            GUI.canvas.DrawFilledRectangle(new(Color.FromArgb(0, 30, 30, 60)), X, Y, width, height);
                            GUI.canvas.DrawRectangle(new(Color.FromArgb(0, 30, 30, 100)), X, Y, width, height);

                            BitFont.DrawBitFontString("Ordinary Font", Color.White, text, X + 8, Y + 8);
                        }

                        else if (WasClicked())
                        {
                            was_clicked = false;
                            q = false;
                            GUI.canvas.DrawFilledRectangle(new(Color.FromArgb(0, 30, 30, 48)), X, Y, width, height);
                            GUI.canvas.DrawRectangle(new(Color.FromArgb(0, 30, 30, 100)), X, Y, width, height);

                            BitFont.DrawBitFontString("Ordinary Font", Color.White, text, X + 8, Y + 8);
                        }
                    }
                }
                else
                {
                    if (!IsMouseOver())
                    {
                        GUI.canvas.DrawFilledRectangle(new(Color.FromArgb(0, 48, 48, 48)), X, Y, width, height);
                        GUI.canvas.DrawRectangle(new(Color.FromArgb(0, 30, 30, 30)), X, Y, width, height);

                        BitFont.DrawBitFontString("Ordinary Font", Color.White, text, X + 8, Y + 8);
                    }
                    if (IsMouseOver())
                    {
                        GUI.canvas.DrawFilledRectangle(new(Color.FromArgb(0, 30, 30, 48)), X, Y, width, height);
                        GUI.canvas.DrawRectangle(new(Color.FromArgb(0, 30, 30, 100)), X, Y, width, height);

                        BitFont.DrawBitFontString("Ordinary Font", Color.White, text, X + 8, Y + 8);
                    }
                    if (WasClicked())
                    {
                        GUI.canvas.DrawFilledRectangle(new(Color.FromArgb(0, 30, 30, 60)), X, Y, width, height);
                        GUI.canvas.DrawRectangle(new(Color.FromArgb(0, 30, 30, 100)), X, Y, width, height);

                        BitFont.DrawBitFontString("Ordinary Font", Color.White, text, X + 8, Y + 8);
                    }
                }
            }
            else
            {
                if (des)
                {
                    if (!q)
                    {
                        if (!IsMouseOver())
                        {
                            GUI.canvas.DrawFilledRectangle(new(Color.FromArgb(0, 48, 48, 48)), X, Y, width, height);
                            GUI.canvas.DrawRectangle(new(Color.FromArgb(0, 30, 30, 30)), X, Y, width, height);
                            GUI.canvas.DrawImageAlpha(image, X + 2, Y + 2);
                        }
                        else if (IsMouseOver())
                        {
                            GUI.canvas.DrawFilledRectangle(new(Color.FromArgb(0, 30, 30, 48)), X, Y, width, height);
                            GUI.canvas.DrawRectangle(new(Color.FromArgb(0, 30, 30, 100)), X, Y, width, height);
                            GUI.canvas.DrawImageAlpha(image, X + 2, Y + 2);
                        }
                        else if (WasClicked())
                        {
                            GUI.canvas.DrawFilledRectangle(new(Color.FromArgb(0, 30, 30, 60)), X, Y, width, height);
                            GUI.canvas.DrawRectangle(new(Color.FromArgb(0, 30, 30, 100)), X, Y, width, height);
                            GUI.canvas.DrawImageAlpha(image, X + 2, Y + 2);
                            was_clicked = true;
                            q = true;
                        }
                    }
                    else
                    {
                        if (!IsMouseOver())
                        {
                            GUI.canvas.DrawFilledRectangle(new(Color.FromArgb(0, 30, 30, 60)), X, Y, width, height);
                            GUI.canvas.DrawRectangle(new(Color.FromArgb(0, 30, 30, 100)), X, Y, width, height);
                            GUI.canvas.DrawImageAlpha(image, X + 2, Y + 2);
                        }
                        else if (IsMouseOver())
                        {
                            GUI.canvas.DrawFilledRectangle(new(Color.FromArgb(0, 30, 30, 60)), X, Y, width, height);
                            GUI.canvas.DrawRectangle(new(Color.FromArgb(0, 30, 30, 100)), X, Y, width, height);
                            GUI.canvas.DrawImageAlpha(image, X + 2, Y + 2);
                        }

                        else if (WasClicked())
                        {
                            was_clicked = false;
                            q = false;
                            GUI.canvas.DrawFilledRectangle(new(Color.FromArgb(0, 30, 30, 48)), X, Y, width, height);
                            GUI.canvas.DrawRectangle(new(Color.FromArgb(0, 30, 30, 100)), X, Y, width, height);
                            GUI.canvas.DrawImageAlpha(image, X + 2, Y + 2);
                        }
                    }
                }
                else
                {
                    if (!IsMouseOver())
                    {
                        GUI.canvas.DrawFilledRectangle(new(Color.FromArgb(0, 48, 48, 48)), X, Y, width, height);
                        GUI.canvas.DrawRectangle(new(Color.FromArgb(0, 30, 30, 30)), X, Y, width, height);
                        GUI.canvas.DrawImageAlpha(image, X + 2, Y + 2);
                    }
                    if (IsMouseOver())
                    {
                        GUI.canvas.DrawFilledRectangle(new(Color.FromArgb(0, 30, 30, 48)), X, Y, width, height);
                        GUI.canvas.DrawRectangle(new(Color.FromArgb(0, 30, 30, 100)), X, Y, width, height);
                        GUI.canvas.DrawImageAlpha(image, X + 2, Y + 2);
                    }
                    if (WasClicked())
                    {
                        GUI.canvas.DrawFilledRectangle(new(Color.FromArgb(0, 30, 30, 60)), X, Y, width, height);
                        GUI.canvas.DrawRectangle(new(Color.FromArgb(0, 30, 30, 100)), X, Y, width, height);
                        GUI.canvas.DrawImageAlpha(image, X + 2, Y + 2);
                    }
                }
            }
            
        }
        public bool IsMouseOver()
        {
            if (MouseManager.X > X && 
                MouseManager.Y > Y && 
                MouseManager.X < X + width && 
                MouseManager.Y < Y + height) 
            { 
                state = State.MouseIsOver; 
                return true; 
            } 
            else 
                state = State.None; 
                return false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Кнопка нажата - true, кнопка не нажата - false</returns>
        public bool WasClicked()
        {
            if (IsMouseOver() && MouseManager.LastMouseState == MouseState.Left)
            {
                was_clicked = true;
            }
            if (MouseManager.MouseState == MouseState.None && was_clicked)
            {
                return true;
            }
            else return false;
        }
    }
}
