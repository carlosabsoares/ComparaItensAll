import React, { useEffect, useState } from 'react'
import {
  Button,
  Dropdown,
  Form,
  FormGroup,
  Input,
  Label,
  Modal,
  Table,
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
              <FormGroup style={{ display: 'inline-block', width: 200, marginRight: 32, }}>
                <Label for="focusAfterClose" style={{ display: 'inline-block'}}>
                  Selecione a Categoria
                </Label>
                <Input style={{ width: 200 }} type="select" id="focusAfterClose">
                </Input>
                <span style={{ marginLeft: '42px !important' }} />
              </FormGroup>
            </div>

            <div>
            <FormGroup style={{ display: 'inline-block', width: 200, marginRight: 32, }}>
                <Label for="focusAfterClose" style={{ display: 'inline-block'}}>
                  Selecione o Fabricante
                </Label>
                <Input style={{ width: 200 }} type="select" id="focusAfterClose">
                </Input>
                <span style={{ marginLeft: '42px !important' }} />
              </FormGroup>
            </div>

            <div>
            <FormGroup>
                  <Label for="focusAfterClose">
                    Especificacoes do produto
                  </Label>
                  <br />
                  <Input style={{ width: 300, display: 'inline-block',}} type="text" required/>
                  <Button type="submit" className="plus-button">
                    <i class="fas fa-plus"></i>
                  </Button>
                </FormGroup>
            </div>

            <div>
              <Table responsive>
                <thead className="text-primary">
                  <tr>
                    <th>Especificações</th>
                    <th className="text-center">Opções</th>
                  </tr>
                </thead>
                <tbody>
                  
                    <tr>
                      <td></td>
                      <td className="text-center">
                        <button Tooltip = "teste" className="action-btn-edit">
                          <i class="far fa-edit"></i>
                        </button>
                        <button
                          className="action-btn-remove text-danger"
                        >
                          <i class="far fa-trash-alt"></i>
                        </button>
                      </td>
                    </tr>
                </tbody>
              </Table>

            </div>

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
