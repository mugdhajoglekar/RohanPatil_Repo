import React, { useState } from "react";
import Form from "react-bootstrap/Form";
import Button from "react-bootstrap/Button";
import {useNavigate} from "react-router-dom";


function AdminLogin() {
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");
  const navigate = useNavigate();
  function validateForm() {
    return email.length > 0 && password.length > 0;
  }

  function handleSubmit(event) {
    event.preventDefault();
  }
  const navigateAdNav = () => {
    navigate('/AdminNav');
  };
  return (
    <div className='container'>
      <h1 style={{ textAlign: 'center', margin: 10 }}>Admin Login</h1><br />
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
        <br />
        <div align="center" classname="row">
        <Button block size="lg" onClick={navigateAdNav} type="submit" className='btn btn-success' disabled={!validateForm()}>
          Login
        </Button>
        </div>
      </Form>
    </div>
  );
}
export default AdminLogin;