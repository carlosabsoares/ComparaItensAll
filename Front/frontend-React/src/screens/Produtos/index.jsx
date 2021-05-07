import React, { useEffect, useState } from 'react';
import ModalProd from '../../components/Modals/ModalProd';
import NavBar from '../../components/NavBar';
import Table from '../../components/Tables/ProdTable';

import { findAll, createItem, deleteItem, updateItem } from '../../utils/produtos';

export default function Produtos() {
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
      <NavBar header="Produtos">
        <Table
          list={list}
          update={handleUpdate}
          create={handleCreate}
          exclude={handleDelete}
          ModalBody={ModalProd}
        />
      </NavBar>
    </div>
  );
}
