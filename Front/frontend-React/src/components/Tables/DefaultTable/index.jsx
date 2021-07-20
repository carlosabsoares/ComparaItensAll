import React, { useState } from 'react';
import { makeStyles } from '@material-ui/core/styles';
import {
  Table,
  TableBody,
  TableCell,
  TableContainer,
  TableHead,
  TableRow,
  Paper,
  Modal,
} from '@material-ui/core';

import { Edit as EditIcon, Delete as DeleteIcon, AddBox as AddBoxIcon } from '@material-ui/icons';

const useStyles = makeStyles({
  table: {
    minWidth: 150,
  },
  add: {
    color: 'green',
    fontSize: 40,
    margin: '2px',
  },
});

export default function ItemsTable({ hasKey, list, update, exclude, create, ModalBody, isChar }) {
  const classes = useStyles();
  const [showEditModal, setShowEditModal] = useState(false);
  const [showCreateModal, setShowCreateModal] = useState(false);
  const [item, setItem] = useState(null);
  function handleEditOpen(item) {
    setShowEditModal(true);
    setItem(item);
  }

  function handleEditClose() {
    setShowEditModal(false);
  }

  function handleCreateOpen() {
    setShowCreateModal(true);
  }

  function handleCreateClose() {
    setShowCreateModal(false);
  }

  return (
    <>
      <AddBoxIcon className={classes.add} onClick={handleCreateOpen} />
      <TableContainer component={Paper}>
        <Table className={classes.table} size="small">
          <TableHead>
            <TableRow>
              <TableCell>Id</TableCell>
              {hasKey && <TableCell align="right">Item</TableCell>}
              {isChar && <TableCell align="right">Categoria</TableCell>}
              <TableCell align="right">Descrição</TableCell>
              <TableCell align="right"></TableCell>
            </TableRow>
          </TableHead>
          <TableBody>
            {list.map((item) => (
              <TableRow key={item.id}>
                <TableCell component="th" scope="row">
                  {item.id}
                </TableCell>
                {hasKey && <TableCell align="right">{item.characteristics.description}</TableCell>}
                {isChar && <TableCell align="right">{item.category.description}</TableCell>}
                <TableCell align="right">{item.description}</TableCell>
                <TableCell align="right">
                  <EditIcon onClick={() => handleEditOpen(item)} />
                  <DeleteIcon onClick={() => exclude(item.id)} />
                </TableCell>
              </TableRow>
            ))}
          </TableBody>
        </Table>
      </TableContainer>
      <Modal open={showEditModal} onClose={handleEditClose}>
        <ModalBody
          header="Editar"
          handleSubmit={(data) => update(data)}
          item={item}
          handleClose={handleEditClose}
        />
      </Modal>
      <Modal open={showCreateModal} onClose={handleCreateClose}>
        <ModalBody
          header="Criar"
          handleSubmit={(data) => create(data)}
          handleClose={handleCreateClose}
        />
      </Modal>
    </>
  );
}
