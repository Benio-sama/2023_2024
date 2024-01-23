import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'

import { Header } from './components/Header'
import { Main } from './components/Main'
import { Footer } from './components/Footer'
import { Picture } from './components/Picture'


function App() {
  return  <div>
    <Header />
    <Main />
    <Footer />
    <Picture imageUrl='HZYPeVG.jpeg' description='Best Friend, Ellie'/>
  </div>
}

export default App
