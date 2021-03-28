import React, { useEffect, useRef, useState } from 'react'
import {
  Card,
  CardHeader,
  CardBody,
  CardTitle,
  Table,
  Row,
  Col,
  Button,
  FormGroup,
  Label,
  Input,
  Form,
} from 'reactstrap'

import { useAuthDataContext } from 'services/auth/auth-provider'
import { findAll } from 'services/manufacturer/manufacturer-service'
import { PageWrapper } from 'components/page-wrapper'
import './styles.css'

export function AdminProductListPage() {
  const { token } = useAuthDataContext()
  const [products, setProducts] = useState([])
  const [category, setCategory] = useState(null)
  const [manufacturer, setManufacturer] = useState(null)
  const [specifications, setSpecifications] = useState([null])

  const [showAddModal, setShowAddModal] = useState(false)

  const [specificationInput, setSpecificationInput] = useState(null)

  async function fetchManufacturers() {
    console.log('token', token)
    try {
      const response = await findAll(token)
      setProducts(response)
      console.log('response', response)
    } catch (error) {
      console.error(error)
    }
  }

  useEffect(() => {
    fetchManufacturers()
  }, [])

  function toggleAddModal() {
    setShowAddModal(!showAddModal)
  }

  function onPressEdit(manufacturer) {}

  function onPressRemove(manufacturer) {}

  function onSubmitSpecification(event) {
    event.preventDefault()

    console.log('specificationInput', specificationInput)
    setSpecifications([...specifications, specificationInput])
    setSpecificationInput(null)
  }

  return (
    <>
      <PageWrapper>
        <div className="user-list-container">
          <div>
            <Button
              className="btn-round"
              color="primary"
              onClick={toggleAddModal}
            >
              Adicionar Produto
            </Button>
          </div>

          <br />

          <div className="content">
            <Row>
              <Col md="12">
                <Card>
                  <CardHeader>
                    <CardTitle tag="h4">Produtos</CardTitle>
                  </CardHeader>

                  <CardBody>
                    <Form inline onSubmit={(e) => e.preventDefault()}>
                      <FormGroup
                        style={{
                          display: 'inline-block',
                          width: 200,
                          marginRight: 32,
                        }}
                      >
                        <Label
                          for="focusAfterClose"
                          style={{ display: 'inline-block' }}
                        >
                          Selecione o Fabricante
                        </Label>
                        <Input
                          style={{ width: 200 }}
                          type="select"
                          id="focusAfterClose"
                          //onChange={handleSelectChange}
                        >
                          <option value="true">Yes</option>
                          <option value="false">No</option>
                        </Input>

                        <span style={{ marginLeft: '42px !important' }} />
                      </FormGroup>

                      <FormGroup style={{ display: 'inline-block' }}>
                        <Label
                          for="focusAfterClose"
                          style={{ display: 'inline-block' }}
                        >
                          Selecione a Categoria
                        </Label>
                        <Input
                          style={{
                            width: 200,
                          }}
                          type="select"
                          id="focusAfterClose"
                          //onChange={handleSelectChange}
                        >
                          <option value="true">Yes</option>
                          <option value="false">No</option>
                        </Input>
                      </FormGroup>
                      <br />
                    </Form>
                    <br />

                    <Form onSubmit={onSubmitSpecification}>
                      <FormGroup>
                        <Label for="focusAfterClose">
                          Especificacoes do produto
                        </Label>
                        <br />
                        <Input
                          onChange={(event) =>
                            setSpecificationInput(event.target.value)
                          }
                          style={{
                            width: 300,
                            display: 'inline-block',
                          }}
                          type="text"
                          required
                        />
                        <Button type="submit" className="plus-button">
                          <i class="fas fa-plus"></i>
                        </Button>
                      </FormGroup>
                    </Form>

                    <br />

                    <div className="multi-filter-box">
                      {specifications.map((specification) => (
                        <div>
                          <p>{specification} </p>
                          <i class="fas fa-times"></i>
                        </div>
                      ))}
                    </div>

                    <Table responsive>
                      <thead className="text-primary">
                        <tr>
                          <th>ID</th>
                          <th>Descrição</th>
                          <th>Categoria</th>
                          <th>Fabricante</th>
                          <th className="text-right"></th>
                        </tr>
                      </thead>
                      <tbody>
                        {products.map((manufacturer) => (
                          <tr>
                            <td>{manufacturer.id}</td>
                            <td>{manufacturer.description}</td>
                            <td className="text-right">
                              <button
                                className="action-btn-edit"
                                onClick={onPressEdit(manufacturer)}
                              >
                                <i class="far fa-edit"></i>
                              </button>
                              <button
                                className="action-btn-remove text-danger"
                                onClick={onPressRemove(manufacturer)}
                              >
                                <i class="far fa-trash-alt"></i>
                              </button>
                            </td>
                          </tr>
                        ))}

                        <tr>
                          <td>Dakota Rice</td>
                          <td>Niger</td>
                          <td>Dakota Rice</td>
                          <td>Niger</td>
                          <td className="text-right">
                            <button
                              className="action-btn-edit"
                              onClick={onPressEdit({})}
                            >
                              <i class="far fa-edit"></i>
                            </button>
                            <button
                              className="action-btn-remove text-danger"
                              onClick={onPressRemove({})}
                            >
                              <i class="far fa-trash-alt"></i>
                            </button>
                          </td>
                        </tr>
                        <tr>
                          <td>Minerva Hooper</td>
                          <td>Curaçao</td>
                          <td>Dakota Rice</td>
                          <td>Niger</td>
                          <td className="text-right">
                            <button className="action-btn-edit">
                              <i class="far fa-edit"></i>
                            </button>
                            <button className="action-btn-remove text-danger">
                              <i class="far fa-trash-alt"></i>
                            </button>
                          </td>
                        </tr>
                      </tbody>
                    </Table>
                  </CardBody>
                </Card>
              </Col>
            </Row>
          </div>
        </div>
      </PageWrapper>
      {/* <AddManufacturerPage
        isModalOpen={showAddModal}
        toggleModal={toggleAddModal}
        onAddNewManufacturer={fetchManufacturers}
      /> */}
    </>
  )
}
