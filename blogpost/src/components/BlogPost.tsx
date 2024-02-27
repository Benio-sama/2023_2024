import { Blog } from "../blog"

interface Props {
    blog: Blog
}
export function BlogPost({blog}: Props) {
    return <article>
    <h2>{blog.title}</h2>
    <img src={blog.image} alt={blog.title}></img>
    <p>{blog.content}</p>
    <p>{blog.date}</p>
    <button onClick={() =>}></button>
  </article>
}