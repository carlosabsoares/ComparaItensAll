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
import * as manufacturerService from 'services/manufacturer/manufacturer-service'
import { PageWrapper } from 'components/page-wrapper'
import AddManufacturerPage from './add'

export default function ManufacturerListPage() {
  const { token } = useAuthDataContext()
  const [manufacturers, setManufacturers] = useState([])
  const [showAddModal, setShowAddModal] = useState(false)

  async function fetchManufacturers() {
    console.log('token', token)
    try {
      const response = await manufacturerService.findAll(token)
      setManufacturers(response)
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

  async function onPressRemove(manufacturer) {
    try {
      await manufacturerService.remove(manufacturer.id)
      setManufacturers(manufacturers.filter((m) => m.id === manufacturer.id))
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
              Adicionar Fabricante
            </Button>
          </div>

          <br />

          <div className="content">
            <Row>
              <Col md="12">
                <Card>
                  <CardHeader>
                    <CardTitle tag="h4">Fabricantes</CardTitle>
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
                        {manufacturers.map((manufacturer) => (
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
                      </tbody>
                    </Table>
                  </CardBody>
                </Card>
              </Col>
            </Row>
          </div>
        </div>
      </PageWrapper>
      <AddManufacturerPage
        isModalOpen={showAddModal}
        toggleModal={toggleAddModal}
        onAddNewManufacturer={fetchManufacturers}
      />
    </>
  )
}