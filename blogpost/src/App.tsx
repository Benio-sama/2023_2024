import { useEffect, useState } from 'react'
import './App.css'
import { Blog } from './blog'

import { BlogPost } from './components/BlogPost'
import { Search } from './components/Search'

function App() {
  const [ blogs, setBlogs ] = useState([
    { title: 'asd', content: 'asd', date: '2024.02.20', image: 'https://picsum.photos/id/10/200' }
  ] as Blog[]);
  const [ searchTerm, setSearchTerm ] = useState('');
  const [ errorMessage, setErrorMessage ] = useState('');
  console.log(blogs);

  useEffect(() => {
    async function loadBlog() {
      try {
        const response = await fetch('/blogposts.json');
        if (!response.ok) {
          setErrorMessage('betoltesi hiba')
        }
        const data = await response.json() as Blog[];
        
        data.sort((a, b) => -a.date.localeCompare(b.date));
        setBlogs(data);
      } catch {
        setErrorMessage('halozati hiba');
      }
    }
    loadBlog();
  }, []);
  const kereses = blogs.filter(blog => blog.content.toLocaleLowerCase().includes(searchTerm.toLocaleLowerCase()));

  return <div>
    <Search onChange={} />
    <p>{errorMessage}</p>
    { <div>
      {
        kereses.map(blog => 
          <BlogPost blog={blog} />
          
        )
      }
    </div> }
  </div>
}

export default App
