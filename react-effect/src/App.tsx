import { useEffect, useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'
import { User, Users} from './user'

function App() {
  console.log('app rendeer');
  const [ users, setUsers ] = useState([] as User[]);
  const [ newUser,setNewUser ] = useState('');
  const [ searchTerm, setSearchTerm] = useState('');
  console.log(users);

  //1 komonenes betoltesekor lecsatlakozaskor
  useEffect(() => {
    async function load() {
      const response = await fetch('/users.json');
      const users = await response.json() as Users;
      setUsers(users.users);
    }
    load();
  }, []);

  //2 ha az adott valtozo megvaltozasahoz szeretnenk kotni
  useEffect(() => {
    console.log('title');
    document.title = `Users (${users.length})`
  }, [ users ]);
  const kivalogatott = users.filter(user => user.username.includes(searchTerm))

  return <div>
    <input type="text" placeholder='kereses' onInput={e => {setSearchTerm(e.currentTarget.value)}} />
    <ul>
      {
        kivalogatott.map(user => <li>{user.firstName}-{user.lastName}-{user.username}</li>)
      }
    </ul>
    <input type="text" onChange={ e =>setNewUser(e.currentTarget.value)} />
    <button onClick={() => {
      setUsers([
        ...users,
        { firstName: 'test', lastName: 'test', username: newUser }
      ]);
    }}>katt ide</button>
  </div>
}

export default App
