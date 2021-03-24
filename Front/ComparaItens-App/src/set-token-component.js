import React, {useContext, useEffect} from 'react'
import {AuthContext} from './services/auth/auth-context'


export function SetTokenComponent() {
  const {state, dispatch} = useContext(AuthContext);

  useEffect(() => {
    async function getToken() {
      const token = await localStorage.getItem('token')
      if (token) dispatch({type: 'SET_TOKEN', value: token})
    }
    getToken()
  }, [])

 return null
}

export default SetTokenComponent;
