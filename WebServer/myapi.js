/**
 * myapi.js
 * 
 * 
 * @version 1.0.0 - initial
 *
 * 
 * DESCRIPTION:
 * 
 * 
 * @throws none
 * @see nodejs.org
 * @see express.org
 * 
 * @author Ben Cook
 */

var http      = require('http');
var express   = require('express');

var app       = express();

var climate = [ {humidity: '0', temperature: '0'},
                {humidity: '0', temperature: '0'},
                {humidity: '0', temperature: '0'},
                {humidity: '0', temperature: '0'}
              ];

//=============================================================================
// configure Express to serve index.html and any other static pages stored 
// in the home directory
//=============================================================================
app.use(express.static(__dirname));

//=============================================================================
// Receives Climate data from a client
//=============================================================================
app.get('/api/climate/set/:id/humidity=:hum&temperature=:temp', function (req, res) {
  console.log('id = ' + req.params.id);
  //save data
  climate[req.params.id].humidity = req.params.hum;
  climate[req.params.id].temperature = req.params.temp;
  //echo back to client
  res.send(climate[req.params.id]);
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
// Express route for any other unrecognised incoming requests
//=============================================================================
app.get('*', function (req, res) {
  res.status(404).send('Unrecognised API call');
});

//=============================================================================
// Express route to handle errors
//=============================================================================
app.use(function (err, req, res, next) {
  if (req.xhr) {
    res.status(500).send('Oops, Something went wrong!');
  } else {
    next(err);
  }
}); // apt.use()

//=============================================================================
// Start Express App Server
//=============================================================================
app.listen(3000);
console.log('App Server is listening on port 3000');

