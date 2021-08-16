import React, { useState, forwardRef, useEffect } from 'react';
import { AppBar, Toolbar, Typography, Button, Grid, MenuItem } from '@material-ui/core';
import { makeStyles } from '@material-ui/core/styles';
import { Form, Field } from 'react-final-form';
import { Select, TextField } from 'final-form-material-ui';

import { findAll as findAllCharacteristics } from '../../../utils/caracteristicas';


const useStyles = makeStyles((theme) => ({
  appBar: {
    [theme.breakpoints.up('sm')]: {
      width: `100%`,
    },
  },
  button: {
    alignSelf: 'flex-end',
    marginTop: '10px',
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
  },
  root: {
    display: 'flex',
  },
  toolbar: theme.mixins.toolbar,
}));

const ModalCarIt = forwardRef(({ header, handleSubmit, item, handleClose }, _ref) => {
  const classes = useStyles();
  const [characteristics, setCharacteristcs] = useState([]);

  const onSubmit = (data) => {
    const sendData = {
      ...data,
    };
    handleSubmit(sendData);
    handleClose();
  };

  useEffect(() => {
    const asyncEffect = async () => {
      const List = await findAllCharacteristics();
      setCharacteristcs(List);
    };

    asyncEffect();
  }, [findAllCharacteristics]);

  return (
    <div className={classes.modalBox}>
      <AppBar position="relative" className={classes.appBar}>
        <Toolbar>
          <Typography variant="h6" noWrap>
            {`${header} Característica Itens`}
          </Typography>
        </Toolbar>
      </AppBar>
      <div className={classes.modalBody}>
        <Form
          onSubmit={onSubmit}
          initialValue={item}
          render={({ handleSubmit }) => (
            <form onSubmit={handleSubmit} noValidate>
              <Grid container alignItems="flex-start" spacing={2}>
                <Grid item xs={12}>
                  <Field
                    fullWidth
                    name="characteristicId"
                    component={Select}
                    label="Característica"
                    defaultValue={item?.characteristicId || ''}
                    formControlProps={{ fullWidth: true }}
                  >
                    {characteristics?.sort((a,b) => a.description.localeCompare(b.description)).map((characteristic) => (
                      <MenuItem key={characteristic.id} value={characteristic.id}>
                        {characteristic.description}
                      </MenuItem>
                    ))}
                  </Field>
                </Grid>
                <Grid item xs={12}>
                  <Field
                    fullWidth
                    label="Descrição"
                    name="description"
                    variant="outlined"
                    size="small"
                    type="text"
                    defaultValue={item?.description}
                    component={TextField}
                  />
                </Grid>
              </Grid>
              <Button
                type="submit"
                variant="contained"
                size="small"
                color="primary"
                className={classes.button}
              >
                Enviar
              </Button>
            </form>
          )}
        />
      </div>
    </div>
  );
});

export default ModalCarIt;
