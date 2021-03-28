import React from 'react'
import { BrowserRouter as Router, Switch, Route } from 'react-router-dom'
import LoginPage from 'pages/login'
import AdminUsersListPage from 'pages/admin/users-list-page'
import ManufacturerListPage from 'pages/admin/manufacturer/list'
import AuthDataProvider from 'services/auth/auth-provider'
import './App.css'
import { Header } from 'components/admin/header/header'
import { SideBar } from 'components/admin/sidebar'
import { RootPageWrapper } from 'components/root-page-wrapper'

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
          </Switch>
        </RootPageWrapper>
      </Router>
    </AuthDataProvider>
  )
}

export default App
