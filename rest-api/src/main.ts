import './style.css'
import {User} from './user.js'

const API_URL = 'https://retoolapi.dev/HycTkA/data';

console.log(API_URL);

async function LoadUsers() {
  const response = await fetch(API_URL);
  const users = await response.json() as User[];
  const userlista = document.getElementById('userlista')!;
  userlista.textContent = '';
  for (const user of users) {
    const tr = document.createElement('tr');

    const tdnev = document.createElement('td');
    tdnev.textContent = `${user.full_name}`;

    const tdage = document.createElement('td');
    tdage.textContent = `${user.age}`;
    
    const tddelete = document.createElement('td');
    const deletebutton = document.createElement('button');
    deletebutton.textContent = 'Delete';
    tddelete.appendChild(deletebutton);

    tr.appendChild(tdnev);
    tr.appendChild(tdage);
    tr.appendChild(deletebutton);

    userlista.appendChild(tr);

    deletebutton.addEventListener('click', async () => {
      console.log(user.id);
      const response = await fetch(API_URL + '/' + user.id, {
        method: 'DELETE',
      });
      LoadUsers();
    });
  }

}

document.addEventListener('DOMContentLoaded', () => {
  LoadUsers();
  document.getElementById("UjAdatForm")?.addEventListener("submit", async e => {
    e.preventDefault();
    
    const name = (document.getElementById("nev") as HTMLInputElement).value;
    const age = (document.getElementById("kor") as HTMLInputElement).valueAsNumber;

    const user: User = {
      full_name: name,
      age: age
    };

    const response = await fetch(API_URL, {
      method: 'POST',
      body: JSON.stringify(user),
      headers: {
        'Content-Type': 'application/json'
      }
    });
    const data = await response.json();
    console.log(data);
    await LoadUsers();
  });
});