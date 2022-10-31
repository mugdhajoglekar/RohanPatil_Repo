import React, {useState} from 'react'

const Que4 = () => {

  let [rating, setRating] = useState(0)
  let [str, setStr] = useState('')
  
  const readRating = (e) => {
    setRating(e.target.value)
  }
  const showRating = () => {
    if(rating <=5 && rating >0){
      let i=0;
      while(i<rating) {
        str += '*'
        i+=1
      }
      setStr(str)
      str=''
      }
    else{
      alert('Invalid value')
    }    
  }
    return(
      <div className='container'>
        <h2 style={{ textAlign: 'center', margin: 10 }}>Rating</h2>
          <div className='form'>
            <div className='row'>
              <div className='col'>
                <div className='mb-3'>
                  <label htmlFor=''>Enter Rating Number</label>
                  <input onChange={readRating} type='number' className='form-control'/>
                </div>
              </div>
              <div className='row'>
                <div className='col'>
                  <div className='mb-3'>
                    <button onClick={showRating} className='btn btn-success'>Star Rating</button>
                    <h1>{str}</h1>
                  </div>
                </div>
                <h1>{str=''}</h1>
                </div>
            </div>
          </div>
          <hr />
      </div>
    )
}
export default Que4