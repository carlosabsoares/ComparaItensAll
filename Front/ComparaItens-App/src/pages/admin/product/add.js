import React, { useEffect, useState } from 'react'
import {
  Button,
  Dropdown,
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

// import { useAuthDataContext } from 'services/auth/auth-provider'
// import * as manufacturerService from 'services/manufacturer/manufacturer-service'
// import * as categoryService from 'services/category/category-service'
// import * as productService from 'services/product/product-service'
// import { PageWrapper } from 'components/page-wrapper'

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
            <div>
              <div>
                <label>Categoria</label>

              </div>
              <div>
                {/* <Label
                for="focusAfterClose"
                style={{ display: 'inline-block' }}
              >
                Selecione o Fabricante
              </Label>
              <Input
                style={{ width: 200 }}
                type="select"
                id="focusAfterClose"
              >
                {manufacturers.map((manufacturer) => (
                  <option value={manufacturer.id}>
                    {manufacturer.description}
                  </option>
                ))}
              </Input> */}
              </div>
            </div>

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
