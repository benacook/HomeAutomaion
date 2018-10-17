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

  //save data
  climate[req.params.id].humidity = req.params.hum;
  climate[req.params.id].temperature = req.params.temp;

  //echo back to client
  res.send(climate[req.params.id]);

  //get date time
  var dt = new Date().toMysqlFormat();
  dt = "'"+dt+"'";
  var HumQuery = "INSERT INTO Humidity (DateTime, Humidity, ID) VALUES ("+ 
    dt + ","+ req.params.hum + "," + req.params.id+")";
  var TempQuery = "INSERT INTO Temperature (DateTime, Temperature, ID) VALUES ("+
    dt + ","+ req.params.temp + "," + req.params.id+")";

  //MySQL Log Humidity
  con.query(HumQuery, function (err, result) {
    if (err) throw err;
    console.log("Humidity Logged to MySQL");
  });

  //MySQL Log Temperature
  con.query(TempQuery, function (err, result) {
    if (err) throw err;
    console.log("Temperature Logged to MySQL");
  });

}); // apt.get()

//=============================================================================
// Sends Climate data by id to a client
//=============================================================================
app.get('/api/climate/get/:id', function (req, res) {
  console.log('id = ' + req.params.id);
  //send data for id
  res.send(climate[req.params.id]);
}); // apt.get()

//=============================================================================
// Sends all Climate data to a client
//=============================================================================
app.get('/api/climate/get', function (req, res) {
  //send data for id
  res.send(climate);
}); // apt.get()

//=============================================================================
// Sends all MySQL Humidity data to client
//=============================================================================
app.get('/api/climate/get/mysql/hum', function (req, res) {
  //send data
  con.query("SELECT * FROM Humidity", function (err, result, fields) {
    if (err) throw err;
    res.send(result);
  });
}); // apt.get()

//=============================================================================
// Sends all MySQL Temperature data to client
//=============================================================================
app.get('/api/climate/get/mysql/temp', function (req, res) {
  //send data
  con.query("SELECT * FROM Temperature", function (err, result, fields) {
    if (err) throw err;
    res.send(result);
  });
}); // apt.get()

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
}); // apt.use()

//=============================================================================
// Start Express App Server
//=============================================================================
app.listen(3000);
console.log('App Server is listening on port 3000');

