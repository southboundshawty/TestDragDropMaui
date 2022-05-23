using MauiApp1.Data;

using System.Collections.Generic;

namespace MauiApp1.DB
{
    internal static class MyContext
    {
        public static List<ICanvasElement> CanvasElements { get; set; } = new List<ICanvasElement>
        {
            new CanvasContent
            {
                Height = 300,
                Width = 300,
                X = 30,
                Y = 30,
                ContentUrl = "https://lh3.googleusercontent.com/iCC9WEcAOxIpS_bDztwlctYfNNVW0CfyZkreEV19h0dUtlIzBSXFx9KO5rHBsNn5RJdhsYyrCFUp8skpLZUZrsJRZQ=w640-h400-e365-rj-sc0x00ffffff"
            },
            new CanvasContent
            {
                Height = 200,
                Width = 300,
                X = 700,
                Y = 30,
                ContentUrl = "https://lh3.googleusercontent.com/iCC9WEcAOxIpS_bDztwlctYfNNVW0CfyZkreEV19h0dUtlIzBSXFx9KO5rHBsNn5RJdhsYyrCFUp8skpLZUZrsJRZQ=w640-h400-e365-rj-sc0x00ffffff"
            },
            new CanvasMultiContent
            {
                Height = 200,
                Width = 600,
                X = 550,
                Y = 300,
                ContentUrls = new string[] { "https://lh3.googleusercontent.com/iCC9WEcAOxIpS_bDztwlctYfNNVW0CfyZkreEV19h0dUtlIzBSXFx9KO5rHBsNn5RJdhsYyrCFUp8skpLZUZrsJRZQ=w640-h400-e365-rj-sc0x00ffffff",
                "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6e/Google_Authenticator_for_Android_icon.svg/1200px-Google_Authenticator_for_Android_icon.svg.png"}
            },
        };
    }
}
