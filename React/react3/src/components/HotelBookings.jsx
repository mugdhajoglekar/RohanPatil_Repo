import React from "react";
import handleAddFormChange from "../components/AdminTable";
import handleAddFormSubmit from "../components/AdminTable";

const HotelBookings= () => {
    
    return (
        <div className='container'>
      <h1 style={{ textAlign: 'center', margin: 10 }}>Book Your Rooms</h1><br />
      <div className='form'>
        <div className='row'>
          <div className='col'>
            <div className='mb-3'>
                <input
                type="text"
                name="fullName"
                required="required"
                placeholder="Enter a name..."
                onChange={handleAddFormChange}
                className='form-control'
                />
                </div></div>
                <div className='col'>
            <div className='mb-3'>
                <input
                type="text"
                name="address"
                required="required"
                placeholder="CheckIn..."
                onChange={handleAddFormChange}
                className='form-control'
                />
                </div></div></div>
                <div className='row'>
          <div className='col'>
            <div className='mb-3'>
                <input
                type="text"
                name="CheckOut"
                required="required"
                placeholder="CheckOut"
                onChange={handleAddFormChange}
                className='form-control'
                />
                </div></div>
                <div className='col'>
            <div className='mb-3'>
                <input
                type="email"
                name="email"
                required="required"
                placeholder="Enter an email..."
                onChange={handleAddFormChange}
                className='form-control'
                />
                </div>
                </div>
                </div>
                <br />
                <div align='center' className='row'>
                    <div className='col'>
                        <button onClick={handleAddFormSubmit} className='btn btn-success'>Book</button>
                    </div></div>
                </div></div>
    )
};

export default HotelBookings;