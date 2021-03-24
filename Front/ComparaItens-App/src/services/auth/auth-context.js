import * as React from 'react'

export const AuthContext = React.createContext()

function authReducer(state, action) {
  switch (action.type) {
    case 'SET_TOKEN': {
      return {token: action.value}
    }
    case 'REMOVE_TOKEN': {
      return {token: null}
    }
    default: {
      throw new Error(`Unhandled action type: ${action.type}`)
    }
  }
}

export function AuthProvider({children}) {
  const [state, dispatch] = React.useReducer(authReducer, {token: null})
  const value = {state, dispatch}
  return <AuthContext.Provider value={value}>{children}</AuthContext.Provider>
}

