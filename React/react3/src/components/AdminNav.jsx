import React from 'react';
import Container from 'react-bootstrap/Container';
import Nav from 'react-bootstrap/Nav';
import Navbar from 'react-bootstrap/Navbar';
import { Link } from 'react-router-dom';
function AdminNav() {
  return (<div>
    <Navbar bg="light" expand="lg">
      <Container>
        <Navbar.Brand href="/">Baratie</Navbar.Brand>
        <Navbar.Toggle aria-controls="basic-navbar-nav" />
        <Navbar.Collapse id="basic-navbar-nav">
          <Nav className="me-auto">
            <Link className="nav-link active" to="/Reservation">Reserved Rooms</Link>
            <Link className="nav-link active" to="/AdminTable">User Details</Link>
            <Link className="nav-link active" to="/">Log Out</Link>
          </Nav>
        </Navbar.Collapse>
      </Container>
    </Navbar>
    <h1 style={{ textAlign: 'center', margin: 10 }}>Welcome Admin</h1><br />
    </div>
  );
}

export default AdminNav;