const socket = io();
document.addEventListener("DOMContentLoaded", async() => {
    await LoadLogin();

    document.getElementById("login").addEventListener("click", () => {
        let admin = document.getElementById("admin").value;
        let password = document.getElementById("password").value;
        
    });
});
async function LoadLogin() {
    fetch()
    .then(response => response.text())
    .then(data => {
        document.getElementById("container").innerHTML = data;
    });
};