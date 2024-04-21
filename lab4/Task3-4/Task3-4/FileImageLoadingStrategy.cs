using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_4
{
    public class FileImageLoadingStrategy : IImageLoadingStrategy
    {
        public async Task<string> LoadImage(string filePath)
        {
            var imageData = await File.ReadAllBytesAsync(filePath);
            var base64Image = Convert.ToBase64String(imageData);
            return base64Image;
        }
    }
}
