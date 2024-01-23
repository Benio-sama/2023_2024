import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'
import { Konyv } from './Konyv';

const konyvek = [
  'gyuruk ura',
  'harry potter es az azkabani fogoly',
  'ecc pecc'
];

function App() {
  return <ul>
    {
      konyvek.map( konyv => <Konyv cim={konyv} szerzo="ismeretlen"/> )
    }
  </ul>;
}

export default App
