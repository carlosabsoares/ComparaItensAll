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
import * as categoryService from 'services/category/category-service'
import {
  useAuthDataContext,
  AuthDataContext,
} from 'services/auth/auth-provider'

export class EditCategoryPage extends React.Component {
  static contextType = AuthDataContext

  state = {
    description: '',
    isVisible: false,
  }

  _onSuccessCallback = () => {}
  _category = {}

  show = (category, onSuccess) => {
    this.setState({ isVisible: true, description: category.description })
    this._onSuccessCallback = onSuccess
    this._category = category
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

    await categoryService.edit(
      { ...this._category, description },
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
          <ModalHeader>Editar Categoria</ModalHeader>
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
