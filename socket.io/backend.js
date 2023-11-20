/*import http from "http";
import express from "express";
import socketIo from "socket.io";*/

const http = require('http');
const express = require('express');
const socketIo = require('socket.io');

const app = express();
const server = http.createServer(app);
const io = socketIo(server);
app.use(express.static(__dirname + '/public'));

io.on('connection', (socket) => {
  console.log('egy kliens csatlakozott');

  socket.on('disconnect', () => {
    console.log('kliens lecsatlakozott');
  });

  socket.on('login', login_data => {
    if (login_data.admin === "FelhasznaloNev" && login_data.password === "Jelszo") {
      socket.join("logged_in");
    }
    else {
      console.log("hibas adatok");
    }
  });
});

server.listen(3000, () => {
  console.log('a szerver fut a 3000-es porton');
});