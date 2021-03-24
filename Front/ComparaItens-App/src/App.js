import React, {useContext, useEffect} from 'react'
import {
  BrowserRouter as Router,
  Switch,
  Route,
  Link
} from "react-router-dom";
import LoginPage from './pages/login'
import AdminUsersListPage from './pages/admin/users-list-page'
import ManufacturerListPage from './pages/admin/manufacturer-list'
import {AuthProvider,AuthContext} from './services/auth/auth-context'
import SetTokenComponent from './set-token-component'
import './App.css';



function App() {

  return (
    <AuthProvider>
      <SetTokenComponent />
      <Router>
        <Switch>
          <Route path="/login">
            <LoginPage />
          </Route>

          <Route path="/admin/users" component={AdminUsersListPage}/>

          <Route path="/admin/manufacturers">
            <ManufacturerListPage />
          </Route>

          <Route path="/admin/manufacturers">
            <ManufacturerListPage />
          </Route>


        </Switch>
      </Router>
    </AuthProvider>
  );
}

export default App;
