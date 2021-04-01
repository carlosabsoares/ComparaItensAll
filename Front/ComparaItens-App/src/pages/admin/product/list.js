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
import * as manufacturerService from 'services/manufacturer/manufacturer-service'
import * as categoryService from 'services/category/category-service'
import * as productService from 'services/product/product-service'
import { PageWrapper } from 'components/page-wrapper'
import './styles.css'

export function AdminProductListPage() {
  const { token } = useAuthDataContext()

  const [pageLoaded, setPageLoaded] = useState(false)
  const [products, setProducts] = useState([])
  const [categories, setCategories] = useState([])
  const [manufacturers, setManufacturers] = useState([])

  const [selectedManufacturer, setSelectedManufacturer] = useState(null)
  const [selectedCategory, setSelectedCategory] = useState(null)
  const [selectedSpecifications, setSelectedSpecifications] = useState([])
  const [specificationInput, setSpecificationInput] = useState(null)

  const [showAddModal, setShowAddModal] = useState(false)

  useEffect(() => {
    async function fetchFilterData() {
      try {
        const [_products, _manufacturers, _categories] = await Promise.all([
          productService.findAll(),
          manufacturerService.findAll(),
          categoryService.findAll(),
        ])
        setProducts(_products)
        setCategories(_categories)
        setManufacturers(_manufacturers)
        setPageLoaded(true)
      } catch (error) {
        console.log('error', error)
      }
    }

    fetchFilterData()
  }, [])

  useEffect(() => {
    async function fetchProducts() {
      if (!pageLoaded) return

      try {
        const products = await productService.findAll()
        setProducts(products)
      } catch (error) {
        console.log('error', error)
      }
    }
    fetchProducts()
  }, [pageLoaded, categories, manufacturers])

  function toggleAddModal() {
    setShowAddModal(!showAddModal)
  }

  function onPressEditProduct(product) {}

  async function onPressRemoveProduct(product) {
    try {
      await productService.remove(product.id)
      setProducts(products.filter((p) => p.id === product.id))
    } catch (error) {
      console.log('error', error)
    }
  }

  function onSubmitSpecification(event) {
    event.preventDefault()

    console.log('specificationInput', specificationInput)
    setSelectedSpecifications([...selectedSpecifications, specificationInput])
    setSpecificationInput(null)
  }

  function onPressRemoveSpecification(specification) {
    const newSpecifications = selectedSpecifications.filter(
      (item) => item === specification
    )
    setSelectedSpecifications(newSpecifications)
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
                        >
                          {manufacturers.map((manufacturer) => (
                            <option value={manufacturer.id}>
                              {manufacturer.description}
                            </option>
                          ))}
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
                        >
                          {categories.map((category) => (
                            <option value={category.id}>
                              {category.description}
                            </option>
                          ))}
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
                          value={specificationInput}
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

                    {selectedSpecifications.length ? (
                      <div className="multi-filter-box">
                        {selectedSpecifications.map((specification) => (
                          <div>
                            <p>{specification} </p>
                            <i
                              class="fas fa-times"
                              onClick={() =>
                                onPressRemoveSpecification(specification)
                              }
                            ></i>
                          </div>
                        ))}
                      </div>
                    ) : null}

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
                        {products.map((product) => (
                          <tr>
                            <td>{product.id}</td>
                            <td>{product.category}</td>
                            <td>{product.description}</td>
                            <td>{product.manufacturer}</td>
                            <td className="text-right">
                              <button
                                className="action-btn-edit"
                                onClick={onPressEditProduct(product)}
                              >
                                <i class="far fa-edit"></i>
                              </button>
                              <button
                                className="action-btn-remove text-danger"
                                onClick={onPressRemoveProduct(product)}
                              >
                                <i class="far fa-trash-alt"></i>
                              </button>
                            </td>
                          </tr>
                        ))}
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
