$(document).ready(function()

{
    ///////////////////////////////////////////////////////////////////////////////
    //Dec Var
    ///////////////////////////////////////////////////////////////////////////////
    var 
        //UI Vars
        topRightHumidity    = document.getElementById("topRightHumidity");
        bottomLeftTemp      = document.getElementById("bottomLeftTemp");
        bottomRightButtons  = document.getElementById("bottomRightButtons");
        //Humidity vars
        MasterBedHumidity   = document.getElementById("MasterBedHumidity");
        BedroomHumidity     = document.getElementById("BedroomHumidity");
        HallwayHumidity     = document.getElementById("HallwayHumidity");
        LivingRoomHumidity  = document.getElementById("LivingRoomHumidity");
        //Temperature vars
        MasterBedTemperature   = document.getElementById("MasterBedTemperature");
        BedroomTemperature     = document.getElementById("BedroomTemperature");
        HallwayTemperature     = document.getElementById("HallwayTemperature");
        LivingRoomTemperature  = document.getElementById("LivingRoomTemperature");
        //
        MenuButton  = $(document).find("#menu");
        LivingLight = $(document).find("#livingLight");

    ///////////////////////////////////////////////////////////////////////////////
    //Timed events
    ///////////////////////////////////////////////////////////////////////////////
        setInterval(GetClimate, 10000);

    ///////////////////////////////////////////////////////////////////////////////
    //Show Menu
    ///////////////////////////////////////////////////////////////////////////////
    MenuButton.on('click',function (event){
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
    LivingLight.on('click', function(event){
        // var state = GetLightState(2);
        // alert(state)
        // if (state == '0' || state == 0)
        // {
        //     alert("turing on")
        //     livingLightOn();
        // }
        // else{alert("turning off"); livingLightOff();}
        ToggleLight(2);
    });

    ///////////////////////////////////////////////////////////////////////////////
    //Living Room Light On
    ///////////////////////////////////////////////////////////////////////////////
    function LightOn(nodeId){
        var url = "http://raspberrypi:8083/ZWaveAPI/Run/devices[" + nodeId + "].instances[0].Basic.Set(255)";
        var xhttp = new XMLHttpRequest();
        xhttp.open("POST", url, false);
        xhttp.send();
    }

    ///////////////////////////////////////////////////////////////////////////////
    //Living Room Light Off
    ///////////////////////////////////////////////////////////////////////////////
    function LightOff(nodeId){
        var url = "http://raspberrypi:8083/ZWaveAPI/Run/devices[" + nodeId + "].instances[0].Basic.Set(0)";
        var xhttp = new XMLHttpRequest();
        xhttp.open("POST", url, false);
        xhttp.send();
    }

    function GetLightState(nodeId)
    {
        var  url = "http://raspberrypi:8083/ZWaveAPI/Run/devices[" + nodeId + "].Basic.data.level.value";
        var xhttp = new XMLHttpRequest();
        xhttp.open("GET", url, false);
        xhttp.onload = function()
        {
            if (xhttp.readyState == XMLHttpRequest.DONE)
            {
            var value = JSON.parse(xhttp.response);
            return value;
            }
        }
        xhttp.send();
    }

    function ToggleLight(nodeId)
    {
        var  url = "http://raspberrypi:8083/ZWaveAPI/Run/devices[" + nodeId + "].Basic.data.level.value";
        var xhttp = new XMLHttpRequest();
        xhttp.open("GET", url, false);
        xhttp.onload = function()
        {
            if (xhttp.readyState == XMLHttpRequest.DONE)
            {
                var value = JSON.parse(xhttp.response);
                if (value == 0)
                {
                    LightOn(2);
                }
                else{LightOff(2);}
            }
        }
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

    function GetClimate()
    {
      var url = document.URL + 'api/climate/get';
      var xhttp = new XMLHttpRequest();
      xhttp.open("GET", url, false);
      xhttp.onload = function()
      {
        if (xhttp.readyState == XMLHttpRequest.DONE)
        {
            //get response
            var climate = JSON.parse(xhttp.response);

            //update humidity bars
            MasterBedHumidity.style.width  = climate[0].humidity + '%';
            BedroomHumidity.style.width    = climate[1].humidity + '%';
            HallwayHumidity.style.width    = climate[2].humidity + '%';
            LivingRoomHumidity.style.width = climate[3].humidity + '%';

            //update temperature bars
            MasterBedTemperature.style.width  =
            GetScaledValue(climate[0].temperature, 40, 100, 0, 0) + '%';
            BedroomTemperature.style.width    =
            GetScaledValue(climate[1].temperature, 40, 100, 0, 0) + '%';
            HallwayTemperature.style.width    =
            GetScaledValue(climate[2].temperature, 40, 100, 0, 0) + '%';
            LivingRoomTemperature.style.width =
            GetScaledValue(climate[3].temperature, 40, 100, 0, 0) + '%';
        }
      }
      xhttp.send();
    }

    function GetScaledValue(value, maxIn, maxOut, minIn, minOut)
    {
            if (value > minIn && value <= maxIn)
            {
                scaleFactor = 100 / maxIn;
                return value * scaleFactor;
            }
            else if (value > maxIn)
            {
                return 100.0;
            }
            else return 0.0;
    }

    

});