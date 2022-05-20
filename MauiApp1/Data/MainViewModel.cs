﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Data
{
    public class MainViewModel
    {
        public int ContainerX { get; set; } = 0;
        public int ContainerY { get; set; } = 0;
        public int ElementX { get; set; } = 0;
        public int ElementY { get; set; } = 0;
        public int ContainerMouseX { get; set; } = 0;
        public int ContainerMouseY { get; set; } = 0;
        public bool OverChild { get; set; } = false;
        public int SelectedItem { get; set; } = -1;
        public List<Rectangle> Rectangles { get; set; }
        public MainViewModel()
        {
            Initialize();
        }
        public void Initialize()
        {
            Random rnd = new Random();

            Rectangles = new List<Rectangle>();

            for (int i = 0; i < 10; i++)
            {
                var r = new Rectangle
                {
                    RectangleId = i + 1,
                    X = (int)rnd.Next(0, 600),
                    Y = (int)rnd.Next(0, 600),
                    Width = 20 * (int)rnd.Next(5, 10),
                    Height = 20 * (int)rnd.Next(5, 10),
                    R = rnd.Next(0, 255),
                    G = rnd.Next(0, 255),
                    B = rnd.Next(0, 255),
                };

                Rectangles.Add(r);
            }
        }
    }
}
