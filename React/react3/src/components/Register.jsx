import React from "react";
import ReadOnlyRow from "./ReadOnlyRow";
import EditableRow from "./EditableRow";
import handleAddFormChange from "../components/AdminTable";
import handleAddFormSubmit from "../components/AdminTable";

const Register= () => {
    
    return (
        <div className='container'>
      <h1 style={{ textAlign: 'center', margin: 10 }}>Register</h1><br />
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
                type="password"
                name="address"
                required="required"
                placeholder="Enter password..."
                onChange={handleAddFormChange}
                className='form-control'
                />
                </div></div></div>
                <div className='row'>
          <div className='col'>
            <div className='mb-3'>
                <input
                type="text"
                name="phoneNumber"
                required="required"
                placeholder="Enter a phone number..."
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
                        <button onClick={handleAddFormSubmit} className='btn btn-success'>Submit</button>
                    </div></div>
                </div></div>
    )
};

export default Register;