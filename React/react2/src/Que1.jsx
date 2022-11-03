// 1. Create a login component to get email address and password from user. The component should
// contian a login button. The login button should print the user credentials on console.


import React from 'react'
import { useState } from 'react'

const Que1 = () => {
  const [email, setEmail] = useState('')
  const [password, setPassword] = useState('')

  const validateUser = () => {
    console.log(`email = ${email}`)
    console.log(`password = ${password}`)
  }
  const readEmail = (e) => {
    setEmail(e.target.value)
  }
  const readPassword = (e) => {
    setPassword(e.target.value)
  }
  return (
    <div className='container'>
      <h2 style={{ textAlign: 'center', margin: 10 }}>Login</h2>
      <div className='form'>
        <div className='row'>
          <div className='col'>
            <div className='mb-3'>
              <label htmlFor=''>Email</label>
              <input onChange={readEmail} type='email' className='form-control' />
            </div></div><br />
          <div className='col'>
            <div className='mb-3'>
              <label htmlFor=''>Password</label>
              <input onChange={readPassword} type='password' className='form-control'/>
            </div></div><br />
            <div className='row'>
              <div className='col'>
                <button onClick={validateUser} className='btn btn-success'>Login</button>
        </div>
        </div>
      </div>
      </div>
      <hr />
      </div>
  )
}

export default Que1