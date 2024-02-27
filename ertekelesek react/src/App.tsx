import { useState, useEffect } from 'react'
import { ReviewPost } from './components/ReviewPost'
import { Review } from './Review'
import './App.css'

function App() {
  const [ reviews, setReviews ] = useState([
    {reviewer: 'asd', review: 'nice', rating: 5, date: '2024-01-01'}
  ] as Review[]);
  const [ error, setError ] = useState('');
  const [ search, setSearch ] = useState(1);
  const [ search2, setSearch2 ] = useState(10);
  console.log(reviews);

  useEffect(() => {
    async function load() {
      try {
        const response = await fetch('./reviews.json');
        if (!response.ok) {
          setError('error in loading');
        }
        const data = await response.json() as Review[];
        data.sort((a, b) => -a.rating + b.rating);
        setReviews(data);
      } catch {
        setError('hiba tortent');
      }
    }
    load();
  }, []);
  const kereses = reviews.filter(review => {
    return review.rating <= search2 || review.rating >= search;
  })

  return <div>
    <input type='number' placeholder='also ertek' defaultValue={1} onInput={e => {
      if (search > search2) {
        setError('az also ertek nem lehet nagyobb a felsonel')
      }
      setSearch(e.currentTarget.valueAsNumber)
    }}></input>
    <input type='number' placeholder='felso ertek' defaultValue={10} onInput={e => {
      if (search > search2) {
        setError('az also ertek nem lehet nagyobb a felsonel')
      }
      setSearch2(e.currentTarget.valueAsNumber)
    }}></input>
    <div>
      {
        kereses.map(review => <ReviewPost reviewer={review.reviewer} rating={review.rating} date={review.date} review={review.review}/>)
      }
    </div>
  </div>
}

export default App
