using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Zwave
{
    class ZwaveHomeHub
    {
        public Rootobject HomeHub = new Rootobject();
        public string GetUrl { get; set; }

        public ZwaveHomeHub(string ipAddress)
        {
         GetUrl = "http://" + ipAddress + ":8083/ZWaveAPI/Data/0";   
        }

        public async Task GetAsync()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response =
                        await client.GetAsync(GetUrl);
                    string data = await response.Content.ReadAsStringAsync();
                    HomeHub =(Rootobject)JsonConvert.DeserializeObject(
                        data, typeof(Rootobject));

                }
            }
            catch { }
        }
    }
}
