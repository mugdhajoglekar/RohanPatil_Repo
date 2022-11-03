import React from 'react';
import Container from 'react-bootstrap/Container';
import Nav from 'react-bootstrap/Nav';
import Navbar from 'react-bootstrap/Navbar';
import HotelBookings from './HotelBookings';
import { Link } from 'react-router-dom';
function NavbarUser() {
  return (
    <div>
    <Navbar bg="light" expand="lg">
      <Container>
        <Navbar.Brand href="/">Baratie</Navbar.Brand>
        <Navbar.Toggle aria-controls="basic-navbar-nav" />
        <Navbar.Collapse id="basic-navbar-nav">
          <Nav className="me-auto">
            <Link className="nav-link active" to="/">Log Out</Link>
          </Nav>
        </Navbar.Collapse>
      </Container>
    </Navbar>
      <HotelBookings />
    </div>
  );
}

export default NavbarUser;