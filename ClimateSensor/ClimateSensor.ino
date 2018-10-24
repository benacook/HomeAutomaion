
// Including the ESP8266 WiFi library
#include <ESP8266WiFi.h>
#include <ESP8266HTTPClient.h>
#include "DHT.h"

#define DHTTYPE DHT22   // DHT 22  (AM2302), AM2321

// network details
const char* ssid = "";
const char* password = "";

// DHT Sensor
const int DHTPin = 5;
// Initialize DHT sensor.
DHT dht(DHTPin, DHTTYPE);

// Temporary variables
static char celsiusTemp[7];
static char humidityTemp[7];

// Web Server on port 80
//WiFiServer server(80);

// only runs once on boot
void setup() {
  // Initializing serial port for debugging purposes
  Serial.begin(115200);
  delay(10);

  dht.begin();
  
  // Connecting to WiFi network
  Serial.println();
  Serial.print("Connecting to ");
  Serial.println(ssid);


  WiFi.begin(ssid, password);
  
  while (WiFi.status() != WL_CONNECTED) {
    delay(500);
    Serial.print(".");
  }
  Serial.println("");
  Serial.println("WiFi connected");

  IPAddress ip(192,168,1,101);   
  IPAddress gateway(192,168,1,254);   
  IPAddress subnet(255,255,255,0);   
  WiFi.config(ip, gateway, subnet);
  
  // Printing the ESP IP address
  Serial.println(WiFi.localIP());
}

// runs over and over again
void loop() {
  // Read humidity
  float h = dht.readHumidity();
  // Read temperature as Celsius (the default)
  float t = dht.readTemperature();

  if (isnan(h) || isnan(t)) {
    h = -1.0;
    t = -1.0;
    strcpy(celsiusTemp,"Failed");
    strcpy(humidityTemp, "Failed"); 
  }
  else{
      float hic = dht.computeHeatIndex(t, h, false);       
      dtostrf(hic, 1, 0, celsiusTemp);                      
      dtostrf(h, 1, 0, humidityTemp);
  }

  if (WiFi.status() == WL_CONNECTED){
    HTTPClient http;
    //http.begin("http://192.168.1.8:10000");
    //http.addHeader("Content-Type", "text/plain");
    char url[256] = "http://homehub:3000/api/climate/set/0/humidity=";
    strcat(url,humidityTemp);
    strcat(url, "&temperature=");
    strcat(url, celsiusTemp);
    http.begin(url);
    http.GET();
    //char toSend[100] = "masterBedroom";
    //strcat(toSend, celsiusTemp);
    //strcat(toSend, "%%");
    //strcat(toSend, humidityTemp);
    Serial.println(url);
    //int httpCode = http.POST(toSend);
    String payload = http.getString(); //Get the response payload
 
   //Serial.println(httpCode);   //Print HTTP return code
   Serial.println(payload);    //Print request response payload
 
   http.end();  //Close connection
    }
  else{
    Serial.println("error connecting to wifi");
  }
  delay(60000);
}   
