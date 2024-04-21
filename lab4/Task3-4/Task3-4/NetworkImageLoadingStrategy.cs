using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_4
{
    public class NetworkImageLoadingStrategy : IImageLoadingStrategy
    {
        private static readonly HttpClient _httpClient = new HttpClient();

        public async Task<string> LoadImage(string url)
        {
            var imageData = await _httpClient.GetByteArrayAsync(url);
            var base64Image = Convert.ToBase64String(imageData);
            return base64Image;
        }
    }
}
