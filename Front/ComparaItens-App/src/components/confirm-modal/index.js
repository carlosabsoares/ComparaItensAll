import React from 'react'
import { Button, Modal, ModalFooter, ModalBody } from 'reactstrap'

// export function ConfirmModal({
//   description = 'Tem certeza que deseja realizar essa ação?',
//   isVisible,
//   onCancel,
//   onSuccess,
// }) {
//   return (
//     <Modal isOpen={isVisible}>
//       <ModalBody>{description}</ModalBody>
//       <ModalFooter>
//         <Button color="secondary" onClick={onCancel}>
//           Não
//         </Button>
//         <Button color="primary" onClick={onSuccess}>
//           Sim
//         </Button>
//       </ModalFooter>
//     </Modal>
//   )
// }

export class ConfirmModal extends React.Component {
  state = {
    description: 'Tem certeza que deseja realizar essa ação?',
    isVisible: false,
    onCancel: () => {},
    onSuccess: () => {},
  }

  show = (config) => {
    const {
      description = 'Tem certeza que deseja realizar essa ação?',
      onCancel = () => {},
      onSuccess = () => {},
    } = config || {}

    this.setState({
      isVisible: true,
      description,
      onCancel,
      onSuccess,
    })
  }

  hide = () => {
    this.setState({ isVisible: false })
  }

  _onCancel = () => {
    this.setState({
      isVisible: false,
    })
    this.state.onCancel()
  }

  _onSuccess = () => {
    this.setState({
      isVisible: false,
    })
    this.state.onSuccess()
  }

  render() {
    const { description, isVisible } = this.state
    return (
      <Modal isOpen={isVisible}>
        <ModalBody>{description}</ModalBody>
        <ModalFooter>
          <Button color="secondary" onClick={this._onCancel}>
            Não
          </Button>
          <Button color="primary" onClick={this._onSuccess}>
            Sim
          </Button>
        </ModalFooter>
      </Modal>
    )
  }
}
