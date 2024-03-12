import { useState, useEffect } from 'react'
import { Commission } from './commission'
import { CommissionPost } from './components/CommissionPost'
import './App.css'

function App() {
  const API = 'http://localhost:3000/commissions';
  const [commission, setCommission] = useState([] as Commission[]);

  async function load() {
    try {
      const response = await fetch(API);
      if (!response.ok) {
        alert('betoltesi hiba');
      }
      const data = await response.json() as Commission[];
      setCommission(data);

    } catch (error) {
      alert('server hiba');
    }
  }
  useEffect(() => {
    
    load();
  }, [])
  return <div>
    <h1>Commissions</h1>
    <table>
        <th>ID</th>
        <th>Description</th>
        <th>Price</th>
      {
        commission.map(commission => <CommissionPost id={commission.id} description={commission.description} price={commission.price}/>)
      }
    </table>
    <form>
      <h3>New Order</h3>
      <input id='desc' type='text' placeholder='Description'></input>
      <br/>
      <input id='product_price' type='number' placeholder='Price'></input>
      <br/>
      <br/>
      <button onClick={async () => {
        let description = (document.getElementById('desc') as HTMLInputElement).value;
        let price = (document.getElementById('product_price') as HTMLInputElement).valueAsNumber;

        if (description !== '' && !Number.isNaN(price)) {
          const comms: Commission = {
            description: description,
            price: price
          }
          const response = await fetch(API, {
            method: 'POST',
            body: JSON.stringify(comms),
            headers: {
              'Content-Type': 'application/json'
            }
          });
          const data = await response.json();
          console.log(data);
          await load();
        }
        else {
          alert('Description and/or price cannot be empty');
        }
      }
      }>Submit</button>
    </form>
  </div>
  
}

export default App
