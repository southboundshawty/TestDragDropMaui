﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Data
{
    public class Rectangle
    {
        public int RectangleId { get; set; }
        public int OriginalX { get; set; }
        public int OriginalY { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }

        public string Position
        {
            get
            {
                return $"{X},{Y}";
            }
        }
    }
}
