using Windows.UI.Xaml.Media;
using Windows.UI;
using System.Net;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Net.Sockets;
using System.Text;

namespace Sensors
{
    public class EnvironmentSensor
    {
        public string RoomName { get; set; }
        public SensorData RoomData { get; set; }
        public int TempAlarmVal { get; set; }
        public int HumidityAlarmVal { get; set; }
        public double LivingRoomScaledTemp { get; set; }
        public double BedroomScaledTemp { get; set; }
        public double MasterBedroomScaledTemp { get; set; }
        public int Port { get; set; }
        public IPAddress IP { get; set; }
        private string readResponse;

        public EnvironmentSensor(string roomName, int tAlarm, int hAlarm, string ipAddress, int port)
        {
            IP = IPAddress.Parse(ipAddress);
            Port = port;
            RoomName = roomName;
            TempAlarmVal = tAlarm;
            HumidityAlarmVal = hAlarm;
        }

        public async Task GetData()
        {
            try
            {
                TcpClient tcpClient = new TcpClient();
                await tcpClient.ConnectAsync(IP, Port);
                var networkStream = tcpClient.GetStream();
                byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes("getData");
                byte[] getData = new byte[tcpClient.ReceiveBufferSize]; ;
                await networkStream.WriteAsync(bytesToSend, 0, ASCIIEncoding.ASCII.GetByteCount("getData"));
                await networkStream.ReadAsync(getData, 0, tcpClient.ReceiveBufferSize);
                tcpClient.Dispose();
                readResponse = Encoding.ASCII.GetString(getData);
                RoomData = (SensorData)JsonConvert.DeserializeObject(readResponse, typeof(SensorData));
                LivingRoomScaledTemp = RoomData.Livingroom.Temp > 0 ?
                    ScaleTemp(RoomData.Livingroom.Temp) : 0;
                MasterBedroomScaledTemp = RoomData.MasterBedroom.Temp > 0 ?
                    ScaleTemp(RoomData.MasterBedroom.Temp) : 0;
                BedroomScaledTemp = RoomData.Bedroom.Temp > 0 ?
                    ScaleTemp(RoomData.Bedroom.Temp) : 0;
            }
            catch { }
        }

        public double ScaleTemp(double temp)
        {
            double maxTemp = 40.0;
            if (temp > 0.0 && temp <= maxTemp)
            {
                double scaleFactor = 100 / maxTemp;
                return temp * scaleFactor;
            }
            else if (temp > maxTemp)
            {
                return 100.0;
            }
            else return 0.0;
        }

        public bool TempAlarm( double temperature)
        {
            if (temperature < TempAlarmVal)
            {
                return true;
            }
            return false;
        }

        public bool HumidityAlarm(double humidity)
        {
            if (humidity > HumidityAlarmVal)
            {
                return true;
            }
            return false;
        }

        public class SensorData
        {
            [JsonProperty("bedroom")]
            public Room Bedroom { get; set; }

            [JsonProperty("livingroom")]
            public Room Livingroom { get; set; }

            [JsonProperty("masterBedroom")]
            public Room MasterBedroom { get; set; }
        }

        public partial class Room
        {
            [JsonProperty("humidity")]
            public double Humidity { get; set; }

            [JsonProperty("temp")]
            public double Temp { get; set; }
        }
    }
}