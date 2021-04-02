import React, { useEffect, useState } from 'react'
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

import * as productService from 'services/product/product-service'
import { useAuthDataContext } from 'services/auth/auth-provider'

export default function AddManufacturerPage({
  isModalOpen,
  toggleModal,
  onSuccess,
}) {
  const { token } = useAuthDataContext()
  const [description, setDescription] = useState('')

  async function onFormSubmit(event) {
    event.preventDefault()

    console.log('onFormSubmit', description)
    await productService.add({ description }, token)
    onSuccess()
  }

  return (
    <Modal isOpen={isModalOpen} toggle={toggleModal} className={'className'}>
      <Form inline onSubmit={onFormSubmit}>
        <ModalHeader toggle={toggleModal}>Adicionar Produto</ModalHeader>
        <ModalBody>
          <FormGroup>
            {/* <Label for="focusAfterClose">Descrição</Label>
            <Input
              required
              type="text"
              onChange={(event) => setDescription(event.target.value)}
            /> */}
          </FormGroup>
        </ModalBody>
        <ModalFooter>
          <Button color="primary" type="submit">
            Salvar
          </Button>{' '}
          <Button color="secondary" onClick={toggleModal}>
            Cancelar
          </Button>
        </ModalFooter>
      </Form>
    </Modal>
  )
}
