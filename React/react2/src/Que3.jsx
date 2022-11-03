// 3. Create a counter component with two buttons and one label. One button will increment while
// another button will decrement the counter. The label should show the current value of counter.

import React from 'react'
import { useState } from 'react'

const Que3 = () => {
  const [counter, setCounter] = useState(0)

  const setIncrement = () => {
    setCounter(counter + 1)
  }

  const setDecrement = () => {
    setCounter(counter - 1)
  }

  return (
    <div className='container'>
      <h2 style={{ textAlign: 'center', margin: 10 }}>Counter</h2>
      <div className='form'>
        <div className='row'>
          <div className='col'>
            <div className='mb-3'>
              <button onClick={setIncrement} className='btn btn-success'>+</button>
              <h5>{counter}</h5>
              <button onClick={setDecrement} className='btn btn-success'>-</button>
              <hr />
            </div>
          </div>
        </div>
      </div>
    </div>
  )
}

export default Que3