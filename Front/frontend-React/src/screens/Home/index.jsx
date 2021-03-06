import React, { useEffect, useState } from 'react';

import { Form, Field } from 'react-final-form';
import { Select } from 'final-form-material-ui';

import { Grid, Button, CssBaseline, MenuItem, Modal } from '@material-ui/core';
import { makeStyles } from '@material-ui/core/styles';

import NavBar from '../../components/NavBar';
import Card from '../../components/Card';
import ModalItem from '../../components/Modals/ModalItem';

import { findAllKeys, findByKey, findByParameter, findById } from '../../utils/produtos';
import { findAll as findAllCategories } from '../../utils/categorias';
import { findAll as findAllManufacturer } from '../../utils/fabricantes';
import { findAll as findAllcharacteristics, findById as findCharacteristicById } from '../../utils/caracteristicas';

const useStyles = makeStyles((theme) => ({
  gray: {
    color: 'gray',
  },
  listBox: {
    display: 'flex',
  },
}));

const Home = () => {
  const classes = useStyles();
  const [categories, setCategories] = useState([]);
  const [manufacturers, setManufacturers] = useState([]);
  const [characteristics, setCharacteristics] = useState([]);
  const [characteristicKeys, setCharacteristicKeys] = useState([]);
  const [characteristicDescriptions, setCharacteristicDescriptions] = useState([]);
  const [modalItem, setModalItem] = useState({});
  const [showModal, setShowModal] = useState(false);
  const [item, setItem] = useState([]);

  useEffect(async () => {
    const categoriesList = await findAllCategories();
    setCategories(categoriesList);
    const manufacturersList = await findAllManufacturer();
    setManufacturers(manufacturersList);
    // const characteristicsList = await findAllcharacteristics();
    // setCharacteristics(characteristicsList);
    // const characteristicKeysList = await findAllKeys();
    // setCharacteristicKeys(characteristicKeysList);
    const itemsList = await findByParameter();
    setItem(itemsList);
  }, []);

  const fetchCharacteristic = async (value) => {
    const response = await findCharacteristicById(value);
    setCharacteristics(response);
  }; 

  const onSubmit = async (data) => {
    const response = await findByParameter(data);
    setItem(response);
  };

  const fetchCharacteristicDescription = async (value) => {
    const response = await findByKey(value);
    setCharacteristicDescriptions(response);
  };

  const handleModalOpen = async (id) => {
    const response = await findById(Number(id));
    setModalItem(response);
    setShowModal(true)
  };

  const handleModalClose = () => {
    setShowModal(false)
  };

  return (
    <NavBar header="Pesquisar">
      <CssBaseline />
      <Form
        onSubmit={onSubmit}
        render={({ handleSubmit, form, submitting, pristine }) => (
          <form onSubmit={handleSubmit} noValidate>
            <Grid container alignItems="flex-start" spacing={2}>

              <Grid item xs={3}>
                <Field
                  fullWidth
                  name="manufacturerId"
                  component={Select}
                  label="Fabricante"
                  formControlProps={{ fullWidth: true }}
                >
                  <MenuItem value="" className={classes.gray}>
                    Fabricante
                  </MenuItem>
                  {manufacturers?.map((manufacturer) => (
                    <MenuItem key={manufacturer.id} value={manufacturer.id}>
                      {manufacturer.description}
                    </MenuItem>
                  ))}
                </Field>
              </Grid>
            
              <Grid item xs={3}>
                  <Field
                    fullWidth
                    name="categoryId"
                    component={Select}
                    label="Categorias"
                    formControlProps={{ fullWidth: true }}
                  >
                    <MenuItem
                        value={''}
                        onClick={() =>
                          setCharacteristics([])
                        }
                      >
                        ??
                    </MenuItem>
                    {categories?.sort((a,b) => a.description.localeCompare(b.description)).map((category) => (
                      <MenuItem
                        key={category.id}
                        value={category.id}
                        onClick={() => fetchCharacteristic(category.id)}
                      >
                        {category.description}
                      </MenuItem>
                    ))}
                  </Field>
                </Grid>
                <Grid item xs={3}>
                  <Field
                    fullWidth
                    name="characteristicId"
                    component={Select}
                    label="Caracter??stica"
                    formControlProps={{ fullWidth: true }}
                    disabled={characteristics.length === 0}
                  >
                    <MenuItem
                        value={''}
                        onClick={() =>
                          setCharacteristicDescriptions([])
                        }
                      >
                        ??
                    </MenuItem>
                    {characteristics?.sort((a,b) => a.description.localeCompare(b.description)).map((characteristic) => (
                      <MenuItem
                        key={characteristic.id}
                        value={characteristic.id}
                        onClick={() =>
                            fetchCharacteristicDescription(characteristic.id)
                        }
                      >
                        {characteristic.description}
                      </MenuItem>
                    ))}
                  </Field>
                </Grid>

                <Grid item xs={3}>
                  <Field
                    fullWidth
                    name="characteristicKeyId2"
                    component={Select}
                    label="Descri????o"
                    formControlProps={{ fullWidth: true }}
                    disabled={characteristicDescriptions.length === 0}
                  >
                    {characteristicDescriptions?.sort((a,b) => a.description.localeCompare(b.description)).map((characteristicKey) => (
                      <MenuItem
                        key={characteristicKey.id}
                        value={characteristicKey.id}
                      >
                        {characteristicKey.description}
                      </MenuItem>
                    ))}
                  </Field>
                </Grid>
              <Grid item>
                <Button
                  type="button"
                  variant="contained"
                  onClick={() => form.reset()}
                  disabled={submitting || pristine}
                >
                  Limpar
                </Button>
              </Grid>
              <Grid item>
                <Button variant="contained" color="primary" type="submit" disabled={submitting}>
                  Buscar
                </Button>
              </Grid>
            </Grid>
          </form>
        )}
      />
      <Grid container alignItems="flex-start" spacing={2}>
        {item?.map((item) => (
          <Grid item xs={3} key={item.id}>
            <Card item={item} onClick={() => handleModalOpen(item.id)} />
          </Grid>
        ))}
      </Grid>
      <Modal
        open={showModal}
        onClose={handleModalClose}
      >
        <ModalItem
          item={modalItem}
          handleClose={handleModalClose}
        />
      </Modal>
    </NavBar>
  );
};

export default Home;
