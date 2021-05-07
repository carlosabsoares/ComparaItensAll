import React, { useEffect, useState } from 'react';
import ModalUser from '../../components/Modals/ModalUser';
import NavBar from '../../components/NavBar';
import Table from '../../components/Tables/UserTable';

import { findAll, createItem, deleteItem, updateItem } from '../../utils/usuarios';

export default function Usuários() {
  const [list, setList] = useState([]);

  const fetchAll = async () => {
    try {
      const res = await findAll();
      setList(res);
    } catch (err) {
      console.log(err);
    }
  };

  useEffect(() => {
    fetchAll();
  }, []);

  const handleUpdate = async (data) => {
    try {
      await updateItem(data);
      fetchAll();
    } catch (err) {
      console.log(err);
    }
  };

  const handleDelete = async (id) => {
    try {
      await deleteItem(id);
      fetchAll();
    } catch (err) {
      console.log(err);
    }
  };

  const handleCreate = async (data) => {
    try {
      await createItem(data);
      fetchAll();
    } catch (err) {
      console.log(err);
    }
  };

  return (
    <div>
      <NavBar header="Usuários">
        <Table
          list={list}
          update={handleUpdate}
          create={handleCreate}
          exclude={handleDelete}
          ModalBody={ModalUser}
        />
      </NavBar>
    </div>
  );
}
