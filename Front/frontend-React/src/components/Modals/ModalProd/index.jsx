import React, { useEffect, useState, forwardRef } from 'react';
import crypto from 'crypto';
import { Form, Field } from 'react-final-form';
import { TextField, Select } from 'final-form-material-ui';

import {
  AppBar,
  Paper,
  Grid,
  Button,
  CssBaseline,
  MenuItem,
  Toolbar,
  Typography,
} from '@material-ui/core';
import { makeStyles } from '@material-ui/core/styles';
import { AddBox as AddBoxIcon } from '@material-ui/icons';

import { findAllKeys, findByKey } from '../../../utils/produtos';
import { findAll as findAllCategories } from '../../../utils/categorias';
import { findAll as findAllManufacturer } from '../../../utils/fabricantes';
import { findAll as findAllcharacteristics, findById as findCharacteristicById } from '../../../utils/caracteristicas';

import CharacteristicTable from '../../Tables/CharacteristicTable';

const useStyles = makeStyles((theme) => ({
  appBar: {
    [theme.breakpoints.up('sm')]: {
      width: `100%`,
    },
  },
  add: {
    color: 'green',
    fontSize: 40,
    margin: '10px 2px 2px',
  },
  button: {
    alignSelf: 'flex-end',
    fontWeight: '700',
    marginTop: '10px',
    width: '80px',
  },
  content: {
    flexGrow: 1,
    padding: theme.spacing(3),
  },
  marginTop: {
    marginTop: '10px',
  },
  modalBody: {
    padding: '5%',
    display: 'flex',
    flexDirection: 'column',
    justifyContent: 'space-around',
  },
  modalBox: {
    margin: 'auto',
    marginTop: '5%',
    backgroundColor: 'white',
    width: '50%',
    minHeight: '150px',
    minWidth: '300px',
    maxHeight: '90vh',
    overflow: 'auto',
  },
  root: {
    display: 'flex',
  },
  toolbar: theme.mixins.toolbar,
  span: {
    marginLeft: '5px',
  },
  fileInput: {
    display: 'flex',
    alignItems: 'center',
  },
}));

const newId = () => crypto.randomBytes(16).toString('hex');
const ModalProdutos = forwardRef(({ header, handleSubmit, item , handleClose }, _ref) => {
  const classes = useStyles();
  const [categories, setCategories] = useState([]);
  const [manufacturers, setManufacturers] = useState([]);
  const [characteristics, setCharacteristics] = useState([]);
  const [characteristicDescriptions, setCharacteristicDescriptions] = useState([]);
  const [characteristicsArray, setCharacteristicsArray] = useState([]);
  const [newCharacteristic, setNewCharacteristic] = useState({
    id: newId(),
    characteristic: { id: null, description: '' },
    description: { id: null, description: '' },
  });

  useEffect(() => {
    if (item?.characteristicDescriptions) {
      setCharacteristicsArray(item?.characteristicDescriptions.map(it => ({
        characteristic: { id: it.characteristics?.id, description: it.characteristics?.description },
        description: { id: it.characteristicKeys?.id, description: it.characteristicKeys?.description }
      })))
    }
  }, [item]);

  useEffect(() => {
    const asyncEffect = async () => {
      const categoriesList = await findAllCategories();
      setCategories(categoriesList);
      const manufacturersList = await findAllManufacturer();
      setManufacturers(manufacturersList);
    };
    asyncEffect();
  }, []);

  const onSubmit = (data) => {
    const { characteristicId, characteristicKeyId, characteristicKeyId2, ...newData } = data;

    const parsedDescriptions = characteristicsArray?.map((characteristic) => ({
      characteristicId: characteristic.characteristic.id,
      characteristicKeyId: characteristic.description.id,
    }));

    const sendData = { ...newData, characteristicDescriptions: parsedDescriptions };

    handleSubmit(sendData);
    handleClose();
  };

  const fetchCharacteristicDescription = async (value) => {
    const response = await findByKey(value);
    setCharacteristicDescriptions(response);
  };

  const fetchCharacteristic = async (value) => {
    const response = await findCharacteristicById(value);
    setCharacteristics(response);
  }; 

  const handleExcludeDescription = (id) => {
    const newArray = characteristicsArray.filter((item) => item.id !== id);
    setCharacteristicsArray(newArray);
  };

  const handleCreateDescription = (form) => {
    if (
      newCharacteristic.characteristic.id !== null &&
      newCharacteristic.description.id !== null
    ) {
      setCharacteristicsArray([...characteristicsArray, newCharacteristic]);
      setNewCharacteristic({
        id: newId(),
        characteristic: { id: null, description: '' },
        description: { id: null, description: '' },
      });
    }
  };

  return (
    <div className={classes.modalBox}>
      <AppBar position="relative" className={classes.appBar}>
        <Toolbar>
          <Typography variant="h6" noWrap>
            {`${header} Produto`}
          </Typography>
        </Toolbar>
      </AppBar>
      <CssBaseline />
      <Form
        onSubmit={onSubmit}
        initialValues={item}
        render={({ handleSubmit, form, submitting, pristine }) => (
          <form onSubmit={handleSubmit} noValidate>
            <Paper style={{ padding: 16 }}>
              <Grid container alignItems="flex-start" spacing={2}>
                <Grid item xs={12}>
                  <Field
                    fullWidth
                    required
                    name="description"
                    component={TextField}
                    type="text"
                    label="Descri????o"
                  />
                </Grid>
                <Grid item xs={4}>
                  <Field
                    fullWidth
                    name="manufacturerId"
                    component={Select}
                    label="Fabricante"
                    formControlProps={{ fullWidth: true }}
                  >
                    {manufacturers?.sort((a,b) => a.description.localeCompare(b.description)).map((manufacturer) => (
                      <MenuItem key={manufacturer.id} value={manufacturer.id}>
                        {manufacturer.description}
                      </MenuItem>
                    ))}
                  </Field>
                </Grid>
                <Grid item xs={4}>
                  <Field
                    name="model"
                    fullWidth
                    required
                    component={TextField}
                    type="text"
                    label="Modelo"
                  />
                </Grid>
                <Grid item xs={4}>
                  <Field
                    name="yearOfManufacture"
                    fullWidth
                    required
                    component={TextField}
                    type="text"
                    label="Ano de Fabrica????o"
                  />
                </Grid>

                <Grid item xs={4}>
                  <Field
                    fullWidth
                    name="categoryId"
                    component={Select}
                    label="Categoria"
                    formControlProps={{ fullWidth: true }}
                  >
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
                <Grid item xs={4}>
                  <Field
                    fullWidth
                    name="characteristicId"
                    component={Select}
                    label="Caracter??stica"
                    formControlProps={{ fullWidth: true }}
                    disabled={characteristics.length === 0}
                  >
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
                        onClick={() =>
                            setNewCharacteristic({
                            characteristic: {
                              id: characteristicKey.characteristics.id,
                              description: characteristicKey.characteristics.description,
                            },
                            description: {
                              id: characteristicKey.id,
                              description: characteristicKey.description,
                            },
                          })}
                      >
                        {characteristicKey.description}
                      </MenuItem>
                    ))}
                  </Field>
                </Grid>
                <Grid item xs={1} p="0">
                  <AddBoxIcon className={classes.add} onClick={handleCreateDescription} />
                </Grid>
                <Grid item xs={12}>
                  <CharacteristicTable
                    list={characteristicsArray}
                    exclude={handleExcludeDescription}
                  />
                </Grid>
                <Grid item style={{ marginTop: 16 }}>
                  <Button
                    type="button"
                    variant="contained"
                    onClick={() => {
                      form.reset();
                      setCharacteristicsArray([]);
                    }}
                    disabled={submitting || pristine}
                  >
                    Resetar
                  </Button>
                </Grid>
                <Grid item style={{ marginTop: 16 }}>
                  <Button variant="contained" color="primary" type="submit" disabled={submitting}>
                    Enviar
                  </Button>
                </Grid>
              </Grid>
            </Paper>
          </form>
        )}
      />
    </div>
  );
});

export default ModalProdutos;
