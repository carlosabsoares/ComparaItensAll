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
import { useAuthDataContext } from 'services/auth/auth-provider'

export default function AddManufacturerPage({
  isModalOpen,
  toggleModal,
  onAddNewManufacturer,
  category,
}) {
  const { token } = useAuthDataContext()
  const [description, setDescription] = useState(category.description)

  async function onFormSubmit(event) {
    event.preventDefault()

    console.log('onFormSubmit', description)
    await categoryService.add({ ...category, description }, token)
    onAddNewManufacturer()
  }

  return (
    <Modal isOpen={isModalOpen} toggle={toggleModal} className={'className'}>
      <Form inline onSubmit={onFormSubmit}>
        <ModalHeader toggle={toggleModal}>Editar Categoria</ModalHeader>
        <ModalBody>
          <FormGroup>
            <Label for="focusAfterClose">Descrição</Label>
            <Input
              required
              type="text"
              onChange={(event) => setDescription(event.target.value)}
            />
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
