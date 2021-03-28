import React from 'react'
import { BrowserRouter as Router, Switch, Route } from 'react-router-dom'
import LoginPage from 'pages/login'
import AdminUsersListPage from 'pages/admin/users-list-page'
import ManufacturerListPage from 'pages/admin/manufacturer/list'
import { AdminProductListPage } from 'pages/admin/product/list'
import AuthDataProvider from 'services/auth/auth-provider'
import { RootPageWrapper } from 'components/root-page-wrapper'

import './App.css'

function App() {
  return (
    <AuthDataProvider>
      <Router>
        {/* <Header />
        <SideBar /> */}

        <RootPageWrapper>
          <Switch>
            <Route path="/login">
              <LoginPage />
            </Route>

            <Route path="/admin/users" component={AdminUsersListPage} />

            <Route path="/admin/manufacturers">
              <ManufacturerListPage />
            </Route>

            <Route path="/admin/manufacturers">
              <ManufacturerListPage />
            </Route>

            <Route path="/admin/products">
              <AdminProductListPage />
            </Route>
          </Switch>
        </RootPageWrapper>
      </Router>
    </AuthDataProvider>
  )
}

export default App
