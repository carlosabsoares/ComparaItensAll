import React, {useEffect, useContext, useState} from 'react'
import { Link } from "react-router-dom";
import {AuthContext} from '../../../services/auth/auth-provider'
import {findAll} from '../../../services/user/user-service'

export default function AdminUserAddPage() {
    const {state, dispatch} = useContext(AuthContext)
    const [formData, setFormData] = useState({name: '', email: '', role: ''})
    

    return (
        <div className="user-list-container">
            
            <Link to="/admin/user/add" >
                <button> add user</button>
            </Link>

            <table class="table">
                <thead>
                    <tr>
                    <th scope="col">name</th>
                    <th scope="col">email</th>
                    <th scope="col">role</th>
                    <th scope="col"></th>
                    </tr>
                </thead>
                <tbody>
                    {users.map(user => {
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