import React from 'react';
import { Link } from 'react-router-dom';
import { Glyphicon, Nav, Navbar, NavItem } from 'react-bootstrap';
import { LinkContainer } from 'react-router-bootstrap';
import './NavMenu.css';
import SearchTitle from './SearchTitle';

export default props => (

  <Navbar   fixedTop fluid >
    <Navbar.Header>
      <Navbar.Brand>
        <Link to={'/'}>Warner Medie Title Search</Link>
      </Navbar.Brand>
      <Navbar.Toggle />
    </Navbar.Header>
    <Navbar.Collapse>
      <Nav>

        <div>
          <SearchTitle/>
        </div>
        
      </Nav>
    </Navbar.Collapse>
  </Navbar>
);

