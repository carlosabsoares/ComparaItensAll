import React, { useEffect, useState, forwardRef } from 'react';
import crypto from 'crypto';
import { Form, Field } from 'react-final-form';
import { TextField, Select } from 'final-form-material-ui';
import ImageUploader from '../../ImageUploader';

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
import { findAll as findAllcharacteristics } from '../../../utils/caracteristicas';

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
    margin: '2px',
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
const ModalProdutos = forwardRef(({ header, handleSubmit, item = {}, handleClose }, _ref) => {
  const classes = useStyles();
  const [categories, setCategories] = useState([]);
  const [manufacturers, setManufacturers] = useState([]);
  const [characteristics, setCharacteristics] = useState([]);
  const [characteristicKeys, setCharacteristicKeys] = useState([]);
  const [characteristicDescriptions, setCharacteristicDescriptions] = useState([]);
  const [characteristicsArray, setCharacteristicsArray] = useState([]);
  const [newCharacteristic, setNewCharacteristic] = useState({
    id: newId(),
    characteristic: { id: null, description: '' },
    key: '',
    description: { id: null, description: '' },
  });

  useEffect(async () => {
    const categoriesList = await findAllCategories();
    setCategories(categoriesList);
    const manufacturersList = await findAllManufacturer();
    setManufacturers(manufacturersList);
    const characteristicsList = await findAllcharacteristics();
    setCharacteristics(characteristicsList);
    const characteristicKeysList = await findAllKeys();
    setCharacteristicKeys(characteristicKeysList);
  }, []);

  const onSubmit = (data) => {
    const {
      characteristicId,
      characteristicKeyId,
      characteristicKeyId2,
      image: imageFile,
      folder: folderFile,
      ...newData
    } = data;
    const parsedDescriptions = characteristicsArray.map((characteristic) => ({
      characteristicId: characteristic.characteristic.id,
      characteristicKeyId: characteristic.description.id,
    }));
    const image = {
      formFile: imageFile?.find((x) => x),
      fileName: imageFile?.find((x) => x)?.name,
    };
    const folder = folderFile?.find((x) => x);
    const sendData = { ...newData, characteristicDescriptions: parsedDescriptions, image, folder };
    handleSubmit(sendData);
    handleClose();
  };

  const fetchCharacteristicDescription = async (value) => {
    const response = await findByKey(value);
    setCharacteristicDescriptions(response);
  };

  const handleExcludeDescription = (id) => {
    const newArray = characteristicsArray.filter((item) => item.id !== id);
    setCharacteristicsArray(newArray);
  };

  const handleCreateDescription = () => {
    if (
      newCharacteristic.characteristic.id !== null &&
      newCharacteristic.key !== '' &&
      newCharacteristic.description.id !== null
    ) {
      setCharacteristicsArray([...characteristicsArray, newCharacteristic]);
      setNewCharacteristic({ ...newCharacteristic, id: newId() });
    }
  };

  return (
    <div className={classes.modalBox}>
      <AppBar position="relative" className={classes.appBar}>
        <Toolbar>
          <Typography variant="h6" noWrap>
            {`${header} Fabricante`}
          </Typography>
        </Toolbar>
      </AppBar>
      <CssBaseline />
      <Form
        onSubmit={onSubmit}
        initialValues={item}
        render={({ handleSubmit, form, reset, submitting, pristine }) => (
          <form onSubmit={handleSubmit} noValidate encType="multipart/form-data">
            <Paper style={{ padding: 16 }}>
              <Grid container alignItems="flex-start" spacing={2}>
                <Grid item xs={6}>
                  <Field
                    fullWidth
                    name="categoryId"
                    component={Select}
                    label="Categorias"
                    formControlProps={{ fullWidth: true }}
                  >
                    {categories.map((category) => (
                      <MenuItem key={category.id} value={category.id}>
                        {category.description}
                      </MenuItem>
                    ))}
                  </Field>
                </Grid>
                <Grid item xs={6}>
                  <Field
                    fullWidth
                    name="manufacturerId"
                    component={Select}
                    label="Fabricante"
                    formControlProps={{ fullWidth: true }}
                  >
                    {manufacturers.map((manufacturer) => (
                      <MenuItem key={manufacturer.id} value={manufacturer.id}>
                        {manufacturer.description}
                      </MenuItem>
                    ))}
                  </Field>
                </Grid>
              </Grid>
              <Grid container alignItems="flex-start" spacing={2}>
                <Grid item xs={12}>
                  <Field
                    fullWidth
                    required
                    name="description"
                    component={TextField}
                    type="text"
                    label="Descrição"
                  />
                </Grid>
                <Grid item xs={6}>
                  <Field
                    name="model"
                    fullWidth
                    required
                    component={TextField}
                    type="text"
                    label="Modelo"
                  />
                </Grid>
                <Grid item xs={6}>
                  <Field
                    name="yearOfManufacture"
                    fullWidth
                    required
                    component={TextField}
                    type="text"
                    label="Ano de Fabricação"
                  />
                </Grid>
                <Grid item xs={6}>
                  <Field name="image">
                    {(props) => (
                      <div>
                        <ImageUploader {...props.input} buttonName="Imagem" />
                      </div>
                    )}
                  </Field>
                </Grid>
                <Grid item xs={6}>
                  <Field name="folder">
                    {(props) => (
                      <div>
                        <ImageUploader pdf {...props.input} buttonName="Folder" />
                      </div>
                    )}
                  </Field>
                </Grid>
                <Grid item xs={4}>
                  <Field
                    fullWidth
                    name="characteristicId"
                    component={Select}
                    label="Característica"
                    formControlProps={{ fullWidth: true }}
                  >
                    {characteristics.map((characteristic) => (
                      <MenuItem
                        key={characteristic.id}
                        value={characteristic.id}
                        onClick={() =>
                          setNewCharacteristic({ ...newCharacteristic, characteristic })
                        }
                      >
                        {characteristic.description}
                      </MenuItem>
                    ))}
                  </Field>
                </Grid>
                <Grid item xs={4}>
                  <Field
                    fullWidth
                    name="characteristicKeyId"
                    component={Select}
                    label="Item"
                    formControlProps={{ fullWidth: true }}
                  >
                    {characteristicKeys.map((characteristicKey) => (
                      <MenuItem
                        key={characteristicKey}
                        value={characteristicKey}
                        onClick={() => fetchCharacteristicDescription(characteristicKey)}
                      >
                        {characteristicKey}
                      </MenuItem>
                    ))}
                  </Field>
                </Grid>
                <Grid item xs={4}>
                  <Field
                    fullWidth
                    name="characteristicKeyId2"
                    component={Select}
                    label="Descrição"
                    formControlProps={{ fullWidth: true }}
                  >
                    {characteristicDescriptions.map((characteristicKey) => (
                      <MenuItem
                        key={characteristicKey.id}
                        value={characteristicKey.id}
                        onClick={() =>
                          setNewCharacteristic({
                            ...newCharacteristic,
                            key: characteristicKey.key,
                            description: {
                              id: characteristicKey.id,
                              description: characteristicKey.description,
                            },
                          })
                        }
                      >
                        {characteristicKey.description}
                      </MenuItem>
                    ))}
                  </Field>
                </Grid>
                <Grid item>
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
                    onClick={reset}
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
