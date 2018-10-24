/**
 * homehubapi.js
 *  
 * @version 1.0.0 - initial
 *
 * DESCRIPTION:
 * node.js server for Raspberry Pi to collect data from sensors and serve 
 * a web based user interface to allow control of light switches and
 * reading data 
 * @author Ben Cook
 */

var http      = require('http');
var express   = require('express');
var mysql = require('mysql'); 

var app       = express();

var climate = [ {humidity: '0', temperature: '0'},
                {humidity: '0', temperature: '0'},
                {humidity: '0', temperature: '0'},
                {humidity: '0', temperature: '0'}
              ];
var loggedData = function(t,h,ti) {
                  this.temperature = t;
                  this.humidity = h;
                  this.hour = ti;
                };

var lastLogged = [new loggedData(0,0,0),
                  new loggedData(0,0,0),
                  new loggedData(0,0,0),
                  new loggedData(0,0,0)]

//=============================================================================
// COnnect to MySQL Database
//=============================================================================
var con = mysql.createConnection({
  host: "localhost",
  user: "",
  password: "",
  database: ""
});
//MySQL Connect
con.connect(function(err) {
  if (err) throw err;
  console.log("Connected to MySQL database");})

//=============================================================================
// js date format to MySQL format
//=============================================================================
function twoDigits(d) {
  if(0 <= d && d < 10) return "0" + d.toString();
  if(-10 < d && d < 0) return "-0" + (-1*d).toString();
  return d.toString();
}

Date.prototype.toMysqlFormat = function() {
  return this.getUTCFullYear() + "-" + twoDigits(1 + this.getUTCMonth()) +
   "-" + twoDigits(this.getUTCDate()) + " " + twoDigits(this.getUTCHours()) + 
   ":" + twoDigits(this.getUTCMinutes()) + ":" + twoDigits(this.getUTCSeconds());
};

//=============================================================================
// configure Express to serve index.html and any other static pages stored 
// in the home directory
//=============================================================================
app.use(express.static(__dirname));

//=============================================================================
// Receives Climate data from a client
//=============================================================================
app.get('/api/climate/set/:id/humidity=:hum&temperature=:temp', function (req, res) {
  console.log('id: ' + req.params.id + ' hum:' + req.params.hum +
  ' temp:' + req.params.temp);
  //copy to vars for ease of use
  var id = req.params.id;
  var temp = req.params.temp;
  var hum = req.params.hum;

  //save data
  climate[req.params.id].humidity = hum;
  climate[req.params.id].temperature = temp;



  //echo back to client
  res.send(climate[id]);

  //get date time
  var dt = new Date().toMysqlFormat();
  //surround datetime with inverted commas
  //as is required for MySQL datetime
  dt = "'"+dt+"'";
  //construct query strings
  var HumQuery = "INSERT INTO Humidity (DateTime, Humidity, ID) VALUES ("+ 
    dt + ","+ hum + "," + id+")";
  var TempQuery = "INSERT INTO Temperature (DateTime, Temperature, ID) VALUES ("+
    dt + ","+ temp + "," + id+")";

  //point dt to new date object
  dt = new Date();
  //only log once an hour or if the data changes
  if(  lastLogged[id].hour != dt.getUTCHours() ||
       lastLogged[id].humidity != hum||
       lastLogged[id].temperature != temp ){
    //set dt to null. dt set to new object in first
    //query, then used to log last logged time in
    //second query, this will fail in the second query
    //if the first query threw error. this means if either
    //query fails, lastLogged time will not be updated.
    dt = null;
    //MySQL Log Humidity     
    con.query(HumQuery, function (err, result) {
      if (err) throw err;
      console.log("Humidity Logged to MySQL");
      lastLogged[id].humidity = hum;
      dt = new Date();
    });
    //MySQL Log Temperature
    con.query(TempQuery, function (err, result) {
      if (err) throw err;
      console.log("Temperature Logged to MySQL");
      lastLogged[id].temperature = temp;
      lastLogged[id].hour = dt.getUTCHours();
    });
  }

}); 

//=============================================================================
// Sends Climate data by id to a client
//=============================================================================
app.get('/api/climate/get/:id', function (req, res) {
  console.log('id = ' + req.params.id);
  //send data for id
  res.send(climate[req.params.id]);
}); 

//=============================================================================
// Sends all Climate data to a client
//=============================================================================
app.get('/api/climate/get', function (req, res) {
  //send data for id
  res.send(climate);
}); 

//=============================================================================
// Sends all MySQL Humidity data to client
//=============================================================================
app.get('/api/climate/get/mysql/hum', function (req, res) {
  //send data
  con.query("SELECT * FROM Humidity", function (err, result, fields) {
    if (err) throw err;
    res.send(result);
  });
}); 

//=============================================================================
// Sends all MySQL Temperature data to client
//=============================================================================
app.get('/api/climate/get/mysql/temp', function (req, res) {
  //send data
  con.query("SELECT * FROM Temperature", function (err, result, fields) {
    if (err) throw err;
    res.send(result);
  });
}); 

//=============================================================================
// Sends MySQL Humidity data to client for specified ID
//=============================================================================
app.get('/api/climate/get/mysql/hum/:id', function (req, res) {
  //send data
  con.query("SELECT * FROM Humidity WHERE ID = "+req.params.id,
  function (err, result, fields) {
    if (err) throw err;
    res.send(result);
  });
}); 

//=============================================================================
// Sends MySQL Temperature data to client for specified ID
//=============================================================================
app.get('/api/climate/get/mysql/temp/:id', function (req, res) {
  //send data
  con.query("SELECT * FROM Temperature WHERE ID = "+req.params.id,
  function (err, result, fields) {
    if (err) throw err;
    res.send(result);
  });
}); 

//=============================================================================
// Unrecognised requests
//=============================================================================
app.get('*', function (req, res) {
  res.status(404).send('Unrecognised API call');
});

//=============================================================================
// Error Hadling
//=============================================================================
app.use(function (err, req, res, next) {
  if (req.xhr) {
    res.status(500).send('Error!');
  } else {
    next(err);
  }
});

//=============================================================================
// Start Express App Server
//=============================================================================
app.listen(3000);
console.log('App Server is listening on port 3000');

