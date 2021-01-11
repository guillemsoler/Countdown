using CountdownWebAPP.Data_Access.DTOS;
using CountdownWebAPP.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CountdownWebAPP.Data_Access.GetData
{
    public class FechTimeFromApi
    {
        public static async void GetCountdown(int CountdownId)
        {
            string baseURL = $"http://pokeapi.co/api/v2/pokemon/{CountdownId}/";
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync(baseURL))
                    {
                        using (HttpContent content = res.Content)
                        {
                            string data = await content.ReadAsStringAsync();
                            if (data != null)
                            {
                                var dataObj = JObject.Parse(data);
                                CountdownModel countdown = new CountdownModel(remainingTime: Int32.Parse($"{dataObj["RemainingTime"]}"));
                            }
                            else
                            {
                                Console.WriteLine("Data is null!");
                            }
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }
    }
}
