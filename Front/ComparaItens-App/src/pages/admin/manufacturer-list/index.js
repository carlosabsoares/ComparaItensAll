import React, {useEffect, useContext, useState} from 'react'
import { Link } from "react-router-dom";
import {AuthContext} from '../../../services/auth/auth-context'
import {findAll} from '../../../services/manufacturer/manufacturer-service'
import AddManufactorer from './add'

export default function ManufacturerListPage() {
    const {state, dispatch} = useContext(AuthContext)
    const [manufacturers, setManufacturers] = useState([])
    const [showModal, setShowModal] = useState(false)
    
    useEffect(() => {
        async function fetchManufacturers() {
            console.log("token",state.token)
            try {
                const response = await findAll(state.token)
                setManufacturers(response)
                console.log('response',response)
            } catch (error) {
                console.error(error)
            }
        }
        fetchManufacturers()
    }, [])

    function handleModal()
    {
        setShowModal(!showModal);
    }

    return (
        <div className="user-list-container">
            
            <button onClick={handleModal} >add manufacturer</button>

            <table class="table">
                <thead>
                    <tr>
                    <th scope="col">id</th>
                    <th scope="col">description</th>
                    <th scope="col"></th>
                    </tr>
                </thead>
                <tbody>
                    {manufacturers.map(manufacturer => {
                        return (
                            <tr>
                                <th scope="row">{manufacturer.id}</th>
                                <td>{manufacturer.description}</td>
                                <td></td>
                            </tr>
                        )
                    })}
                </tbody>
            </table>

            {showModal && <AddManufactorer valores = {handleModal}/>}

        </div>
    )
}

