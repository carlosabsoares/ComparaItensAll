import React from 'react'
import { Link } from 'react-router-dom'
import {
  Collapse,
  Navbar,
  NavbarToggler,
  NavbarBrand,
  Nav,
  NavItem,
  Dropdown,
  DropdownToggle,
  DropdownMenu,
  DropdownItem,
  Container,
  InputGroup,
  InputGroupText,
  InputGroupAddon,
  Input,
} from 'reactstrap'
import './styles.css'

export function Header() {
  return (
    <Navbar
      //   color={
      //     this.props.location.pathname.indexOf('full-screen-maps') !== -1
      //       ? 'dark'
      //       : this.state.color
      //   }
      expand="lg"
      // className={
      //   //     this.props.location.pathname.indexOf('full-screen-maps') !== -1
      //   //       ? 'navbar-absolute fixed-top'
      //   //       : 'navbar-absolute fixed-top ' +
      //   //         (this.state.color === 'transparent' ? 'navbar-transparent ' : '')
      // }
      className="navbar-absolute navbar-transparent bg-transparent"
    >
      <Container fluid>
        <div className="navbar-wrapper">
          <div className="navbar-toggle">
            <button
              type="button"
              //ref={this.sidebarToggle}
              className="navbar-toggler"
              //onClick={() => this.openSidebar()}
            >
              <span className="navbar-toggler-bar bar1" />
              <span className="navbar-toggler-bar bar2" />
              <span className="navbar-toggler-bar bar3" />
            </button>
          </div>
          <NavbarBrand href="/">{/* {this.getBrand()} */}</NavbarBrand>
        </div>
        <NavbarToggler
        //onClick={this.toggle}
        >
          <span className="navbar-toggler-bar navbar-kebab" />
          <span className="navbar-toggler-bar navbar-kebab" />
          <span className="navbar-toggler-bar navbar-kebab" />
        </NavbarToggler>
        <Collapse
          //isOpen={this.state.isOpen}
          navbar
          className="justify-content-end"
        >
          {/* <form>
            <InputGroup className="no-border">
              <Input placeholder="Search..." />
              <InputGroupAddon addonType="append">
                <InputGroupText>
                  <i className="nc-icon nc-zoom-split" />
                </InputGroupText>
              </InputGroupAddon>
            </InputGroup>
          </form> */}
          <Nav navbar>
            {/* <NavItem>
              <Link to="#pablo" className="nav-link btn-magnify">
                <i className="nc-icon nc-layout-11" />
                <p>
                  <span className="d-lg-none d-md-block">Stats</span>
                </p>
              </Link>
            </NavItem> */}
            {/* <Dropdown
              nav
              //isOpen={this.state.dropdownOpen}
              //toggle={(e) => this.dropdownToggle(e)}
            >
              <DropdownToggle caret nav>
                <i className="nc-icon nc-bell-55" />
                <p>
                  <span className="d-lg-none d-md-block">Some Actions</span>
                </p>
              </DropdownToggle>
              <DropdownMenu right>
                <DropdownItem tag="a">Action</DropdownItem>
                <DropdownItem tag="a">Another Action</DropdownItem>
                <DropdownItem tag="a">Something else here</DropdownItem>
              </DropdownMenu>
            </Dropdown> */}
            <NavItem>
              <Link to="/login" className="nav-link btn-rotate">
                <i class="fas fa-user" style={{ color: '#717171' }}></i>
                <p>
                  <span className="d-lg-none d-md-block">Account</span>
                </p>
              </Link>
            </NavItem>
          </Nav>
        </Collapse>
      </Container>
    </Navbar>
  )
}
