import React from 'react'
import { NavLink } from 'react-router-dom'
import { Nav } from 'reactstrap'
// javascript plugin used to create scrollbars on windows
//import PerfectScrollbar from 'perfect-scrollbar'

import logo from 'logo.svg'
import './styles.css'

export function SideBar() {
  return (
    <div className="sidebar" data-color={'red'} data-active-color={'blue'}>
      <div className="logo">
        <a
          href="https://www.creative-tim.com"
          className="simple-text logo-mini"
        >
          <div className="logo-img">
            {/* <img src={logo} alt="react-logo" /> */}
          </div>
        </a>
        <a
          href="https://www.creative-tim.com"
          className="simple-text logo-normal"
        >
          Compara App
        </a>
      </div>
      <div
        className="sidebar-wrapper"
        //ref={this.sidebar}
      >
        <Nav>
          {/* {this.props.routes.map((prop, key) => {
            return (
              <li
                // className={
                //   this.activeRoute(prop.path) + (prop.pro ? ' active-pro' : '')
                // }
                key={key}
              >
                <NavLink
                //   to={prop.layout + prop.path}
                  className="nav-link"
                  activeClassName="active"
                >
                  <i className={prop.icon} />
                  <p>{'prop.name'}</p>
                </NavLink>
              </li>
            )
          })} */}
        </Nav>
      </div>
    </div>
  )
}
