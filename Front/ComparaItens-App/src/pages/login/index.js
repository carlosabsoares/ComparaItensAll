import React, { useState } from 'react'
import { useHistory } from 'react-router-dom'
import { useAuthDataContext } from '../../services/auth/auth-provider'

import { fetchAuthToken } from '../../services/auth/auth-service'
import './style.css'

export default function LoginPage() {
  const { onLogin } = useAuthDataContext()
  const history = useHistory()
  const [username, setUsername] = useState('')
  const [password, setPassword] = useState('')

  async function onFormSubmit(event) {
    event.preventDefault()
    try {
      const response = await fetchAuthToken(username, password)
      const { data } = await response.json()
      onLogin(data)
      history.replace('/admin')
    } catch (error) {
      console.error(error)
    }
  }

  function onInputChanged(event, type) {
    switch (type) {
      case 'username':
        setUsername(event.target.value)
        break
      case 'password':
        setPassword(event.target.value)
        break
      default:
        break
    }
  }

  return (
    <div class="login-page">
      <form className="form" onSubmit={onFormSubmit}>
        <h2 className="text-center">Log in</h2>
        <div className="form-group">
          <input
            type="text"
            className="form-control"
            placeholder="Username"
            required="required"
            value={username}
            onChange={(event) => onInputChanged(event, 'username')}
          />
        </div>
        <div className="form-group">
          <input
            type="password"
            className="form-control"
            placeholder="Password"
            required="required"
            value={password}
            onChange={(event) => onInputChanged(event, 'password')}
          />
        </div>
        <div className="form-group">
          <button type="submit" className="btn btn-primary btn-block">
            Log in
          </button>
        </div>
      </form>
    </div>
  )
}
