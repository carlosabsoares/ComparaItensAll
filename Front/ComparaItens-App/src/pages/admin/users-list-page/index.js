import React, { useEffect, useState } from 'react'
import { Link } from 'react-router-dom'
import { useAuthDataContext } from '../../../services/auth/auth-provider'
import { findAll } from '../../../services/user/user-service'

export default function AdminUserList() {
  const { token } = useAuthDataContext()
  const [users, setUsers] = useState([])

  useEffect(() => {
    async function fetchUsers() {
      console.log('token', token)
      try {
        const response = await findAll(token)
        setUsers(response)
        console.log('response', response)
      } catch (error) {
        console.error(error)
      }
    }

    fetchUsers()
  }, [])

  return (
    <div className="user-list-container">
      <Link to="/admin/user/add">
        <button> add user</button>
      </Link>

      <table class="table">
        <thead>
          <tr>
            <th scope="col">Nome</th>
            <th scope="col">Email</th>
            <th scope="col">Perfil</th>
            <th scope="col">Opções</th>
          </tr>
        </thead>
        <tbody>
          {users.map((user) => {
            return (
              <tr>
                <th scope="row">{user.name}</th>
                <td>{user.email}</td>
                <td>{user.role}</td>
                <td></td>
              </tr>
            )
          })}
        </tbody>
      </table>
    </div>
  )
}
