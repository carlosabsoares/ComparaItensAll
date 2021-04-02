import React, { useState } from 'react'
import {
  Button,
  Form,
  FormGroup,
  Input,
  Label,
  Modal,
  ModalBody,
  ModalFooter,
  ModalHeader,
} from 'reactstrap'
import * as manufacturerService from 'services/manufacturer/manufacturer-service'
import {
  useAuthDataContext,
  AuthDataContext,
} from 'services/auth/auth-provider'

export class EditManufacturerPage extends React.Component {
  static contextType = AuthDataContext

  state = {
    description: '',
    isVisible: false,
  }

  _onSuccessCallback = () => {}
  _category = {}

  show = (manufacturer, onSuccess) => {
    this.setState({ isVisible: true, description: manufacturer.description })
    this._onSuccessCallback = onSuccess
    this._manufacturer = manufacturer
  }

  hide = () => {
    this.setState({ isVisible: false })
  }

  _onClose = () => {
    this.setState({ isVisible: false })
  }

  _onFormSubmit = async (event) => {
    event.preventDefault()
    const { description } = this.state

    await manufacturerService.edit(
      { ...this._manufacturer, description },
      this.context.token
    )
    this._onClose()
    this._onSuccessCallback()
  }

  _toggleVisibility = () => {
    this.setState((prevState) => ({ isVisible: !prevState.isVisible }))
  }

  render() {
    const { isVisible, description } = this.state

    return (
      <Modal
        isOpen={isVisible}
        toggle={this._toggleVisibility}
        className={'className'}
      >
        <Form inline onSubmit={this._onFormSubmit}>
          <ModalHeader>Editar Fabricante</ModalHeader>
          <ModalBody>
            <FormGroup>
              <Label for="focusAfterClose">Descrição</Label>
              <Input
                required
                type="text"
                value={description}
                onChange={(event) =>
                  this.setState({ description: event.target.value })
                }
              />
            </FormGroup>
          </ModalBody>
          <ModalFooter>
            <Button color="primary" type="submit">
              Salvar
            </Button>{' '}
            <Button color="secondary" onClick={this._onClose}>
              Cancelar
            </Button>
          </ModalFooter>
        </Form>
      </Modal>
    )
  }
}
