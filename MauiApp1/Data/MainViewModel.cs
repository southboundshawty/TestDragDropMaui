namespace MauiApp1.Data
{
    public class MainViewModel
    {
        public int ContainerX { get; set; } = 0;
        public int ContainerY { get; set; } = 0;
        public int ContainerMouseX { get; set; } = 0;
        public int ContainerMouseY { get; set; } = 0;
        public bool OverChild { get; set; } = false;
        public ICanvasElement SelectedItem { get; set; }
        public List<ICanvasElement> CanvasElements { get; set; }
        public MainViewModel()
        {
            Initialize();
        }
        public void Initialize()
        {
            Random rnd = new Random();

            CanvasElements = new List<ICanvasElement>();

            for (int i = 0; i < 5; i++)
            {
                var width = 200;
                var heigth = 200;

                var r = new CanvasElementBase
                {
                    Id = i + 1,
                    X = (int)rnd.Next(0, 1000 - width),
                    Y = (int)rnd.Next(0, 1000 - heigth),
                    Width = 200,
                    Height = 200
                };

                CanvasElements.Add(r);
            }
        }
    }
}
