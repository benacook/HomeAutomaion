using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Zwave
{
    public class OnOffSwitch
    {
        public string NodeId { get; set; }
        public string DeviceName { get; set; }
        private string onUrl;
        private string offUrl;
        private string getUrl;
        public string Level = "0";
        public int LevelInt = 0;

        public OnOffSwitch(int nodeId, string deviceName)
        {
            NodeId = nodeId.ToString();
            DeviceName = deviceName;
            onUrl = "http://192.168.0.17:8083/ZWaveAPI/Run/devices[" + NodeId + "].instances[0].Basic.Set(255)";
            offUrl = "http://192.168.0.17:8083/ZWaveAPI/Run/devices[" + NodeId + "].instances[0].Basic.Set(0)";
            getUrl = "http://192.168.0.17:8083/ZWaveAPI/Run/devices[" + NodeId + "].Basic.data.level.value";
        }

        public async Task SwitchOn()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(onUrl);
                }
            }
            catch { }
        }

        public async Task SwitchOff()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(offUrl);
                }
            }
            catch { }
        }

        public async Task GetValue()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(getUrl);
                    Level = await response.Content.ReadAsStringAsync();
                }
            }
            catch { }
            LevelInt = Convert.ToInt32(Level);
        }
    }
}