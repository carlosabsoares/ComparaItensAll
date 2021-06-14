import React, { useEffect, useState } from 'react';
import ModalCar from '../../components/Modals/ModalCar';
import NavBar from '../../components/NavBar';
import Table from '../../components/Tables/DefaultTable';

import { findAll, createItem, deleteItem, updateItem } from '../../utils/caracteristicas';

export default function Caracteristicas() {
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
      <NavBar header="Características">
        <Table
          isChar
          list={list}
          update={handleUpdate}
          create={handleCreate}
          exclude={handleDelete}
          ModalBody={ModalCar}
        />
      </NavBar>
    </div>
  );
}
