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

export default function UserTable({ hasKey, list, update, exclude, create, ModalBody }) {
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
              <TableCell align="right">Nome</TableCell>
              <TableCell align="right">Email</TableCell>
              <TableCell align="right">Login</TableCell>
              <TableCell align="right"></TableCell>
            </TableRow>
          </TableHead>
          <TableBody>
            {list.map((item) => (
              <TableRow key={item.id}>
                <TableCell component="th" scope="row">
                  {item.id}
                </TableCell>
                <TableCell align="right">{item.name}</TableCell>
                <TableCell align="right">{item.email}</TableCell>
                <TableCell align="right">{item.login}</TableCell>
                <TableCell align="right">
                  <EditIcon onClick={() => handleEditOpen(item)} />
                  <DeleteIcon onClick={() => exclude(item.id)} />
                </TableCell>
              </TableRow>
            ))}
          </TableBody>
        </Table>
      </TableContainer>
      <Modal
        open={showEditModal}
        onClose={handleEditClose}
      >
        <ModalBody
          header="Editar"
          handleSubmit={(name, login, email) => update({ id: item.id, role: 'Administrator', name, login, email })}
          item={item}
          handleClose={handleEditClose}
        />
      </Modal>
      <Modal
        open={showCreateModal}
        onClose={handleCreateClose}
      >
        <ModalBody
          header="Criar"
          handleSubmit={(name, login, email, password) => create({ name, login, email, password })}
          handleClose={handleCreateClose}
          isCreate
        />
      </Modal>
    </>
  );
}
