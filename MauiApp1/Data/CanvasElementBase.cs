namespace MauiApp1.Data
{
    internal class CanvasElementBase : ICanvasElement
    {
        public int Id { get; set; }
        public int OriginalX { get; set; }
        public int OriginalY { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public string Position
        {
            get
            {
                return $"{X},{Y}";
            }
        }
    }
}
