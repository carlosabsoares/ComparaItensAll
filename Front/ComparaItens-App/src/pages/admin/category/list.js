import React, { useEffect, useState } from 'react'
import {
  Card,
  CardHeader,
  CardBody,
  CardTitle,
  Table,
  Row,
  Col,
  Button,
} from 'reactstrap'

import { useAuthDataContext } from 'services/auth/auth-provider'
import * as categoryService from 'services/category-service'
import { PageWrapper } from 'components/page-wrapper'
import AddCategoryPage from './add'

export default function CategoryListPage() {
  const { token } = useAuthDataContext()
  const [categories, setCategories] = useState([])
  const [showAddModal, setShowAddModal] = useState(false)

  async function fetchCategories() {
    console.log('token', token)
    try {
      const response = await categoryService.findAll(token)
      setCategories(response)
      console.log('response', response)
    } catch (error) {
      console.error(error)
    }
  }

  useEffect(() => {
    fetchCategories()
  }, [])

  function toggleAddModal() {
    setShowAddModal(!showAddModal)
  }

  function onPressEdit(category) {}

  async function onPressRemove(category) {
    try {
      await categoryService.remove(category.id)
      setCategories(categories.filter((c) => c.id === category.id))
    } catch (error) {
      console.log('error', error)
    }
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
              Adicionar Categoria
            </Button>
          </div>

          <br />

          <div className="content">
            <Row>
              <Col md="12">
                <Card>
                  <CardHeader>
                    <CardTitle tag="h4">Categorias</CardTitle>
                  </CardHeader>
                  <CardBody>
                    <Table responsive>
                      <thead className="text-primary">
                        <tr>
                          <th>ID</th>
                          <th>Descrição</th>
                          <th className="text-right"></th>
                        </tr>
                      </thead>
                      <tbody>
                        {categories.map((category) => (
                          <tr>
                            <td>{category.id}</td>
                            <td>{category.description}</td>
                            <td className="text-right">
                              <button
                                className="action-btn-edit"
                                onClick={() => onPressEdit(category)}
                              >
                                <i class="far fa-edit"></i>
                              </button>
                              <button
                                className="action-btn-remove text-danger"
                                onClick={() => onPressRemove(category)}
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
      <AddCategoryPage
        isModalOpen={showAddModal}
        toggleModal={toggleAddModal}
        onAddNewManufacturer={fetchCategories}
      />
    </>
  )
}
