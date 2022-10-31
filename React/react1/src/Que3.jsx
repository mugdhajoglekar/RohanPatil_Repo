// 3. Create a component to render table and unordered list for the following array.

import React from 'react'
const Que3 = () => {
    const posts = [
        {
        userId: 1,
        id: 1,
        title:'sunt aut facere repellat provident occaecati excepturi optio reprehenderit',
        body: 'quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto',
        },
        {
        userId: 1,
        id: 2,
        title: 'qui est esse',
        body: 'est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla',
        },
        {
        userId: 1,
        id: 3,
        title: 'ea molestias quasi exercitationem repellat qui ipsa sit aut',
        body: 'et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut',
        },
        {
        userId: 1,
        id: 4,
        title: 'eum et est occaecati',
        body: 'ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit',
        },
        {
        userId: 1,
        id: 5,
        title: 'nesciunt quas odio',
        body: 'repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque',
        },
        {
        userId: 1,
        id: 6,
        title: 'dolorem eum magni eos aperiam quia',
        body: 'ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae',
        },
        {
        userId: 1,
        id: 7,
        title: 'magnam facilis autem',
        body: 'dolore placeat quibusdam ea quo vitae\nmagni quis enim quiquis quo nemo aut saepe\nquidem repellat excepturi ut quia\nsunt ut sequi eos ea sed quas',
        },
        {
        userId: 1,
        id: 8,
        title: 'dolorem dolore est ipsam',
        body: 'dignissimos aperiam dolorem qui eum\nfacilis quibusdam animi sint suscipit qui sint possimus cum\nquaerat magni maiores excepturi\nipsam ut commodi dolor voluptatum modi aut vitae',
        },
        {
        userId: 1,
        id: 9,
        title: 'nesciunt iure omnis dolorem tempora et accusantium',
        body: 'consectetur animi nesciunt iure dolore\nenim quia ad\nveniam autem ut quam aut nobis\net est aut quod aut provident voluptas autem voluptas',
        },
       ]
       
  return (
    <div>
      <h2 style={{ textAlign: 'center', margin: 10 }}>Question no 3</h2><hr />
      <h4 style={{ textAlign: 'center', margin: 10 }}>Unordered List</h4>
        <div>
        <ul>
            {posts.map((post) => (
            <li>userId: {post.userId}
            <p>Id: {post.id}</p>
            <p>Title: {post.title}</p>
            <p>Body: {post.body}</p>
            </li>
            ))}
        </ul>
        </div><hr />
        <div>
          <hr />
        <h4 style={{ textAlign: 'center', margin: 10 }}>Table</h4>
        <table className='table table-striped'>
        <tbody>
          <tr>
            <th>UserId</th>
            <th>Id</th>
            <th>Title</th>
            <th>Body</th>
          </tr>
          {posts.map((post) => (
            <tr>
            <td>{post.userId}</td>
            <td>{post.id}</td>
            <td>{post.title}</td>
            <td>{post.body}</td>
            </tr>
            ))}
        </tbody>
        </table>
        </div>
    </div>
  )
}

export default Que3