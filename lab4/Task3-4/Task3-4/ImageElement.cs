using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_4
{
    public class ImageElement : LightNode
    {
        public string Href { get; }
        public IImageLoadingStrategy LoadingStrategy { get; }

        public ImageElement(string href, IImageLoadingStrategy loadingStrategy)
        {
            Href = href;
            LoadingStrategy = loadingStrategy;
        }

        public async Task LoadAndDisplayImage()
        {
            Console.WriteLine($"Loading image from {Href}...");
            var imageBase64 = await LoadingStrategy.LoadImage(Href);
            Console.WriteLine($"Loaded image data (base64): {imageBase64}");
        }
    }
}
