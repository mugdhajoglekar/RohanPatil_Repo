// 4. Update the above list by creating a separate component named Post which will accept userId, id,
// title and body as props.

import React, { useState } from 'react'
const Post = (props) => {
    const { userId, id, title, body} = props
    return (
      <tr>
        <td>{userId}</td>
        <td>{id}</td>
        <td>{title}</td>
        <td>{body}</td>
      </tr>
    )
  }

const Que4 = (props) => {
    const [userId, setUserId] = useState('')
    const [id, setId] = useState('')
    const [title, setTitle] = useState('')
    const [body, setBody] = useState('')
    const [posts, setPosts] = useState([...props.posts])
    const createPost = () => {
        const post = {
          userId,
          id,
          title,
          body,
        }
        setPosts([...posts, post])
    }
  return (
    <div className='container'>
      <h2 style={{ textAlign: 'center', margin: 10 }}>Question no 4</h2>
      <br />
      <div className='form'>
        <div className='row'>
         <div className='col'>
          <div className='mb-3'>
            <label htmlFor=''>User Id</label>
            <input
              onChange={(e) => setUserId(e.target.value)}
              type='text'
              className='form-control'
            />
          </div>
        </div>
        <div className='col'>
          <div className='mb-3'>
            <label htmlFor=''>Id</label>
            <input
              onChange={(e) => setId(e.target.value)}
              type='text'
              className='form-control'
            />
          </div>
        </div>
        <div className='col'>
          <div className='mb-3'>
            <label htmlFor=''>Title</label>
            <input
              onChange={(e) => setTitle(e.target.value)}
              type='text'
              className='form-control'
            />
          </div>
        </div>
        <div className='col'>
          <div className='mb-3'>
            <label htmlFor=''>Body</label>
            <input
              onChange={(e) => setBody(e.target.value)}
              type='text'
              className='form-control'
            />
          </div>
        </div>
      </div>
      <div className='row'>
          <div className='col'>
            <button onClick={createPost} className='btn btn-success'>
              Add
            </button>
          </div>
        </div>
        {posts.length === 0 && <h3>No posts</h3>}

        {posts.length > 0 && (
        <table className='table table-striped'>
          <thead>
            <tr>
              <th>User Id</th>
              <th>Id</th>
              <th>Title</th>
              <th>Body</th>
            </tr>
          </thead>
          <tbody>
            {posts.map((post) => {
              return (
                <Post
                  userId={post.userId}
                  id={post.id}
                  title={post.title}
                  body={post.body}
                />
              )
            })}
          </tbody>
        </table>
      )}
    </div>
    </div>
  )
}

export default Que4