import React from 'react'
import { Route } from 'react-router-dom'
import LoginPage from 'pages/login'
import { useAuthDataContext } from 'services/auth/auth-provider'

export const PrivateRoute = ({ component, ...options }) => {
  const { user } = useAuthDataContext()
  const finalComponent = user ? component : LoginPage

  return <Route {...options} component={finalComponent} />
}
