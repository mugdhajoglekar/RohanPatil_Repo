import React from "react";
import Form from "react-bootstrap/Form";
import Button from "react-bootstrap/Button";
import {useNavigate} from "react-router-dom";
const Home = () => {
    const navigate = useNavigate();
    const navigateLog = () => {
        navigate('/Login');
      };
      const navigateReg = () => {
        navigate('/Register');
      };
      const navigateAdLog = () => {
        navigate('/AdminLogin');
      };
    return (
        <div  className='container'>
            <h1 style={{ textAlign: 'center', margin: 10 }}>Welcome To Baratie</h1><br />
            <div align="center" classname="row">
            <div classname="col">
                <div classname="mb-3">
            <Button block size="lg" onClick={navigateLog} type="submit" className='btn btn-success'>Login</Button><span>  </span>
            <Button block size="lg" onClick={navigateReg} type="submit" className='btn btn-success'>Register</Button><span>  </span>
            <Button block size="lg" onClick={navigateAdLog} type="submit" className='btn btn-success'>Admin Login</Button><span>  </span>
            </div>
            </div>
            </div>
        </div>
    )
}
export default Home;