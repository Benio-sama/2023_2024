import { useState, useEffect } from 'react'
import { Commission } from './commission'
import { CommissionPost } from './components/CommissionPost'
import './App.css'

function App() {
  const API = 'http://localhost:3000/commissions';
  const [error, setError] = useState('');
  const [commission, setCommission] = useState([] as Commission[]);




  useEffect(() => {
    async function load() {
      try {
        const response = await fetch(API);
        if (!response.ok) {
          setError('betoltesi hiba');
        }
        const data = await response.json() as Commission[];
        setCommission(data);

      } catch (error) {
        setError('server hiba');
      }

    }
    load();
  }, [])
  return <div>
      <table>
      {
        commission.map(commission => <CommissionPost id={commission.id} description={commission.description} price={commission.price}/>)
      }
    </table>
    <input id='desc' type='text' placeholder='Description'></input>
    <input id='product_price' type='number' placeholder='Price'></input>
    <button onClick={() => {
      let description = (document.getElementById('desc') as HTMLInputElement).value;
      let price = (document.getElementById('product_price') as HTMLInputElement).valueAsNumber;

      const data: Commission = {
        description: description,
        price: price
      }


      const response = await fetch(API), {
        method: 'POST',
        body: JSON.stringify(data),
        headers: {
          'Content-Type': 'application/json'
        }
      });
    }
    }></button>
  </div>
  
}

export default App
