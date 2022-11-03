// 2. Create a registration component to get the user details. The component should contian a register
// button. The button should print the user credentials on console.


import React from 'react'
import { useState } from 'react'

const Que2 = () => { 
  const [name, setName] = useState('')
  const [email, setEmail] = useState('')
  const [address, setAddress] = useState('')

  const validateUser = () => {
    console.log(`name = ${name}`)
    console.log(`email = ${email}`)
    console.log(`address = ${address}`)
  }

  const readName = (e) => {
    setName(e.target.value)
  }
  const readEmail = (e) => {
    setEmail(e.target.value)
  }

  const readAddress = (e) => {
    setAddress(e.target.value)
  }
  return (
    <div className='container'>
      <h2 style={{ textAlign: 'center', margin: 10 }}>Registration</h2>
      <div className='form'>
        <div className='row'>
          <div className='col'>
            <div className='mb-3'>
              <label htmlFor=''>Name</label>
              <input onChange={readName} type='name' className='form-control'/>
            </div>
          </div><br />
          <div className='col'>
            <div className='mb-3'>
              <label htmlFor=''>Email</label>
              <input onChange={readEmail} type='email' className='form-control'/>
              </div>
            </div><br />
            <div className='col'>  
              <div className='mb-3'>
                <label htmlFor=''>Address</label>
                <input onChange={readAddress} type='address' className='form-control'/>
              </div> 
            </div>
            <div className='row'>
              <div className='col'>
                <button onClick={validateUser} className='btn btn-success'>Registration</button>
              </div>
            </div>
          </div>
          </div>
      <hr />
    </div>
  )
}

export default Que2