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
        <a href="#" className="simple-text logo-mini">
          <div className="logo-img">
            {/* <img src={logo} alt="react-logo" /> */}
          </div>
        </a>
        <a href="#" className="simple-text logo-normal">
          <i class="fab fa-searchengin"></i>
          Busca Especificações
        </a>
      </div>
      <div
        className="sidebar-wrapper"
        //ref={this.sidebar}
      >
        <Nav>
          <li>
            <NavLink to="/login" className="nav-link" activeClassName="active">
              <p>Login</p>
            </NavLink>
          </li>
          <li>
            <NavLink
              to="/admin/manufacturers"
              className="nav-link"
              activeClassName="active"
            >
              <p>Fabricantes</p>
            </NavLink>
          </li>

          <li>
            <NavLink
              to="/admin/products"
              className="nav-link"
              activeClassName="active"
            >
              <p>Produtos</p>
            </NavLink>
          </li>

          <li>
            <NavLink
              to="/admin/categories"
              className="nav-link"
              activeClassName="active"
            >
              <p>Categorias</p>
            </NavLink>
          </li>
        </Nav>
      </div>
    </div>
  )
}
