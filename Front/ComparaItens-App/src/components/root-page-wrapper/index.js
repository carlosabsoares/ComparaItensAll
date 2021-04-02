import { Header } from 'components/admin/header/header'
import { SideBar } from 'components/admin/sidebar'
import { useAuthDataContext } from 'services/auth/auth-provider'

import './styles.css'

export function RootPageWrapper({ children }) {
  const { token } = useAuthDataContext()

  return (
    <div className="main-panel">
      {token ? <SideBar /> : null}

      <div className={`main-panel ${token ? 'has-sidebar' : ''}`}>
        <Header />
        {children}
      </div>
    </div>
  )
}
