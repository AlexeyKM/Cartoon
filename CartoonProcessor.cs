using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartoon
{

    internal class CartoonProcessor
    {
        private static HttpClient client = new HttpClient();
        public static async Task<CartoonModel> LoadSunInfo(float lat = 0, float lng = 0)
        {
            string url = $"https://rickandmortyapi.com/json?lat={lat}&lng={lng}";

            using (HttpResponseMessage response = await client.GetAsync(url))
            {
                string responceString = await response.Content.ReadAsStringAsync();

                SunResultModel sunResultModel =
                    JsonConvert.DeserializeObject<SunResultModel>(responceString);

                return sunResultModel;
            }
        }
    }
}
