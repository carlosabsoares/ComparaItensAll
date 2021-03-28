import { Header } from 'components/admin/header/header'
import { SideBar } from 'components/admin/sidebar'

import './styles.css'

export function RootPageWrapper({ children }) {
  return (
    <div className="root-page-wrapper">
      <SideBar />

      <div className="main-panel">
        <Header />
        {children}
      </div>
    </div>
  )
}
