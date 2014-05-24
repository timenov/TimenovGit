using System;

namespace _01.DefiningSomeClasses
{
    class Display
    {
        private int width;
        private int height;
        private uint colors;

        public int Width 
        { 
            get 
            { 
                return this.width; 
            } 
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The width can not be less than 1!");
                }
                this.width = value; 
            } 
        }
        public int Height 
        { 
            get 
            { 
                return this.height; 
            } 
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The height can not be less than 1!");
                }
                this.height = value; 
            } 
        }
        public uint Colors 
        { 
            get 
            { 
                return this.colors; 
            } 
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The colors can not be less than 1!");
                }
                this.colors = value; 
            } 
        }

        public Display() { }

        public Display(int width, int height, uint colors)
        {
            this.Width = width;
            this.Height = height;
            this.Colors = colors;
        }

        public override string ToString()
        {
            return "Display info" +
                "\nheight, width: " + this.Height + ", " + this.Width +
                "\ncolors: " + this.Colors;
        }
    }
}
