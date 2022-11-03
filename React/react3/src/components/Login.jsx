import React, { useState } from "react";
import Form from "react-bootstrap/Form";
import Button from "react-bootstrap/Button";
import {useNavigate} from "react-router-dom";


function Login() {
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");
  const navigate = useNavigate();
  function validateForm() {
    return email.length > 0 && password.length > 0;
  }

  function handleSubmit(event) {
    event.preventDefault();
  }
  const navigateUsNav = () => {
    navigate('/Navbar');
  };
  return (
    <div className='container'>
      <h1 style={{ textAlign: 'center', margin: 10 }}>Login</h1><br />
      <Form onSubmit={handleSubmit}>
        <Form.Group size="lg" controlId="email">
          <Form.Label>Email</Form.Label>
          <Form.Control
            autoFocus
            type="email"
            value={email}
            onChange={(e) => setEmail(e.target.value)}
          />
        </Form.Group>
        <Form.Group size="lg" controlId="password">
          <Form.Label>Password</Form.Label>
          <Form.Control
            type="password"
            value={password}
            onChange={(e) => setPassword(e.target.value)}
          />
        </Form.Group>
        </Form>
        <br />
        <div classname="row" align="center">
        <Button block size="lg" onClick={navigateUsNav} type="submit" className='btn btn-success' disabled={!validateForm()}>
          Login
        </Button>
        </div>
        </div>
  );
}
export default Login;