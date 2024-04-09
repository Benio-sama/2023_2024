import { useState, useEffect } from 'react'
import { Speaker } from './speaker';
import { SpeakerPost } from './components/SpeakerPost';
import './App.css'

function App() {
  const [speaker, setSpeaker] = useState([] as Speaker[]);
  const API = 'http://localhost:3000/speakers';
  async function load() {
    try {
      const response = await fetch(API);
      if (!response.ok) {
        alert('Error fetching');
      }
      const data = await response.json() as Speaker[];
      setSpeaker(data);
    } catch (error) {
      alert('Server error');
    }
  }
  useEffect(() => {
    load();
  }, [])

  return <div>
    <h1>Speakers</h1>
    <table>
      <th>ID</th>
      <th>Name</th>
      <th>Weight</th>
      <th>Waterproof</th>
      {
        speaker.map (speaker => <SpeakerPost id={speaker.id} name={speaker.name} weight={speaker.weight} waterproof={speaker.waterproof}/>)
      }
    </table>
    <form>
      <h3>New Speaker</h3>
      <label htmlFor='name'> Name: </label><br/>
      <input id='name' placeholder="Speaker's name"></input><br/>
      <label htmlFor='weight'> Weight: </label><br/>
      <input id='weight' placeholder="Speaker's weight in grams"></input><br/>
      <label htmlFor='waterproof'> Waterproof: </label><br/>
      <input id='waterproof' placeholder="Waterproof? yes/no"></input><br/>
      <button onClick={ async () => {
        let name = (document.getElementById('name') as HTMLInputElement).value;
        let weight = (document.getElementById('weight') as HTMLInputElement).valueAsNumber;
        let waterproof = (document.getElementById('waterproof') as HTMLInputElement).value;

        if (name !== '' && weight !== null) {
          if (waterproof.toLowerCase() == 'yes') {
            const speaker: Speaker = {
              name: name,
              weight: weight,
              waterproof: 1
            }
            const response = await fetch(API, {
              method: 'POST',
              body: JSON.stringify(speaker),
              headers: {
                'Content-Type': 'application/json'
              }
            });
            const data = await response.json();
            console.log(data);
            await load();
          } else if (waterproof.toLowerCase() == 'no') {
            const speaker: Speaker = {
              name: name,
              weight: weight,
              waterproof: 0
            }
            const response = await fetch(API, {
              method: 'POST',
              body: JSON.stringify(speaker),
              headers: {
                'Content-Type': 'application/json'
              }
            });
            const data = await response.json();
            console.log(data);
            await load();
          } else {
            alert("waterproof sould be yes or no");
          }
        } else {
          alert("name and/or weight cant be empty");
        }
      }}>Submit</button>
    </form>
  </div>
}

export default App
