using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;

namespace CountdownWebAPP.Data_Access.PostData
{
    public class PostTimeToApi
    {
        private static readonly HttpClient client = new HttpClient();
        public Dictionary<string, string> GetDataFromUI()
        {
            //Recoger los datos de la interficie (tiempo restante) y poner aqui
            string time = "0";//coger los datos de la interficie
            var value = new Dictionary<string, string>
            {
                { "time", time },
            };
            //-----------------
            return value;
        }
        public async void SendTimeToApi(Dictionary<string, string> value)
        {
            var content = new FormUrlEncodedContent(value);

            var response = await client.PostAsync("https://localhost:44354/api/CountdownModels", content);

            var responseString = await response.Content.ReadAsStringAsync();
        }

    }
}
