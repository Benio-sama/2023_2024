import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'

function Szoveg() {
  const [ szoveg, setSzoveg] = useState('');
  
  
  
  return <div>
    <input type="text" onInput={e => {
      setSzoveg(e.currentTarget.value);
      document.title = e.currentTarget.value;
      }}></input>
    <p>a szoveg hossza: {szoveg.length}</p>
  </div>
}

function App() {
  const [ db, setDb ] = useState(0);
  const [ lista, setLista ] = useState('egy elem');
  console.log('app re-render');
  return <div>
    <button onClick={() => { 
      setDb(db + 1);
      console.log(db);
      }}>katt ide</button>
    <p>kattintasok szamok: {db}</p>
    <Szoveg />
  </div>
}

export default App
