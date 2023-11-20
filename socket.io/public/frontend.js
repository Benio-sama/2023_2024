const socket = io();

socket.on('connect', () => {
    console.log("kapcsolodva a szerverhez");
});

document.addEventListener("DOMContentLoaded", async() => {
    await LoadLogin();

    document.getElementById("login").addEventListener("click", () => {
        let admin = document.getElementById("admin").value;
        let password = document.getElementById("password").value;
        data = { admin, password };
        socket.emit('login', data);
    });
});
async function LoadLogin() {
    fetch()
    .then(response => response.text())
    .then(data => {
        document.getElementById("container").innerHTML = data;
    });
};

/*document.addEventListener('DOMContentLoaded', () => {
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
});*/
