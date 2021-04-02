import React, {
  createContext,
  useContext,
  useEffect,
  useMemo,
  useState,
} from 'react'

export const AuthContext = React.createContext()

export const AuthDataContext = createContext(null)

const initialAuthData = {}

const AuthDataProvider = (props) => {
  const [authData, setAuthData] = useState(initialAuthData)

  useEffect(() => {
    async function getAuthDataFromStorage() {
      const data = await localStorage.getItem('authData')
      if (data) setAuthData(data)
    }

    getAuthDataFromStorage()
  }, [])

  const onLogout = () => setAuthData(initialAuthData)

  const onLogin = (newAuthData) => {
    setAuthData(newAuthData)
    localStorage.setItem('authData', JSON.stringify(newAuthData))
  }

  const authDataValue = useMemo(() => ({ ...authData, onLogin, onLogout }), [
    authData,
  ])
  console.log('authDataValue', authDataValue)
  return <AuthDataContext.Provider value={authDataValue} {...props} />
}

export const useAuthDataContext = () => useContext(AuthDataContext)

export default AuthDataProvider
