$(document).ready(function()

{
    ///////////////////////////////////////////////////////////////////////////////
    //Dec Var
    ///////////////////////////////////////////////////////////////////////////////
    var 
        topRightHumidity = document.getElementById("topRightHumidity");
        bottomLeftTemp = document.getElementById("bottomLeftTemp");
        bottomRightButtons = document.getElementById("bottomRightButtons");
        menuButton = $(document).find("#menu");
        livingLight = $(document).find("#livingLight");

    ///////////////////////////////////////////////////////////////////////////////
    //Timed events
    ///////////////////////////////////////////////////////////////////////////////
        //setInterval(GetWeather, 10000);

    ///////////////////////////////////////////////////////////////////////////////
    //Show Menu
    ///////////////////////////////////////////////////////////////////////////////
    menuButton.on('click',function (event){
        if (topRightHumidity.style.display != "none") {
            topRightHumidity.style.display = "none";
        }
        else{
            topRightHumidity.style.display = "initial";
        }

        if (bottomLeftTemp.style.display != "none") {
            bottomLeftTemp.style.display = "none";
        }
        else{
            bottomLeftTemp.style.display = "initial";
        }

        if (bottomRightButtons.style.display != "none") {
            bottomRightButtons.style.display = "none";
        }
        else{
            bottomRightButtons.style.display = "initial";
        }
    });

    ///////////////////////////////////////////////////////////////////////////////
    //Toggle Living Room Light
    ///////////////////////////////////////////////////////////////////////////////
    livingLight.on('click', function(event){
        livingLightOn();
    });

    ///////////////////////////////////////////////////////////////////////////////
    //Living Room Light On
    ///////////////////////////////////////////////////////////////////////////////
    function livingLightOn(){
        var url = "http://raspberrypi:8083/ZWaveAPI/Run/devices%5B2%5D.instances%5B0%5D.Basic.Set(255)";
        var xhttp = new XMLHttpRequest();
        xhttp.open("POST", url, false);
        xhttp.send();
    }

    ///////////////////////////////////////////////////////////////////////////////
    //Living Room Light Off
    ///////////////////////////////////////////////////////////////////////////////
    function livingLightOff(){
        var url = "http://raspberrypi:8083/ZWaveAPI/Run/devices%5B2%5D.instances%5B0%5D.Basic.Set(0)";
        var xhttp = new XMLHttpRequest();
        xhttp.open("POST", url, false);
        xhttp.send();
    }

    function GetWeather()
    {
      var url = "http://api.openweathermap.org/data/2.5/weather?q=Congleton,uk&units=metric&appid=85fca04eed49d2054facb2000d1ae927";
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