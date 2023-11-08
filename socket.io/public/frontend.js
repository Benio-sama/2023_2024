const socket = io();


document.addEventListener('DOMContentLoaded', () => {
    document.getElementById('sendbutton').addEventListener('click', () => {

        let message = document.getElementById('messageinput').value;
        socket.emit('message', message);
    });
});


socket.on('connect', () => {
    console.log("kapcsolodva a szerverhez");
});
socket.on('message', (data) => {
    console.log("uzenet erkezett", data);
});
socket.on('disconnect', () => {
    console.log('kapcsolat megszakatt');
});


