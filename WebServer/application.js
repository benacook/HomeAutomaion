

$(document).ready(function()

{
  ///////////////////////////////////////////////////////////////////////////////
  //DEC VAR
  ///////////////////////////////////////////////////////////////////////////////
  var
      Background  = $("svg#Background");
      LivingOn = $(document).find("#LivingOn");
      LivingOff = $(document).find("#LivingOff");
      TempOut = $(document).find("#TempOut");
  ///////////////////////////////////////////////////////////////////////////////

    setInterval(GetWeather, 10000);

    LivingOn.on('click', function (event)
    {

      var url = "http://192.168.0.17:8083/ZWaveAPI/Run/devices%5B2%5D.instances%5B0%5D.Basic.Set(255)";
      var xhttp = new XMLHttpRequest();
      xhttp.open("POST", url, false);
      xhttp.send();
    });

    LivingOff.on('click', function (event)
    {

      var url = "http://192.168.0.17:8083/ZWaveAPI/Run/devices%5B2%5D.instances%5B0%5D.Basic.Set(0)";
      var xhttp = new XMLHttpRequest();
      xhttp.open("POST", url, false);
      xhttp.send();
    });

    function GetWeather()
    {
      var url = "http://api.openweathermap.org/data/2.5/weather?q=Liverpool,uk&units=metric&appid=85fca04eed49d2054facb2000d1ae927";
      var xhttp = new XMLHttpRequest();
      xhttp.open("GET", url, false);
      xhttp.onload = function()
      {
        if (xhttp.readyState == XMLHttpRequest.DONE)
        {
           var Weather = JSON.parse(xhttp.response);
           //alert(Weather.main.temp);
           TempOut.textContext = Weather.main.temp;
        }
      }
      xhttp.send();
    }
});