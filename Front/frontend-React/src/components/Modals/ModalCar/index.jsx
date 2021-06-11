import React, { useState, useEffect, forwardRef } from 'react';
import { AppBar, Toolbar, Typography, Grid, Button, MenuItem } from '@material-ui/core';
import { makeStyles } from '@material-ui/core/styles';
import { findAll as findAllCategories } from '../../../utils/categorias';
import { Form, Field } from 'react-final-form';
import { Select, TextField } from 'final-form-material-ui';

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

const ModalCar = forwardRef(({ header, handleSubmit, item, handleClose }, _ref) => {
  const classes = useStyles();
  const [categories, setCategories] = useState([]);

  useEffect(() => {
    const asyncEffect = async () => {
      const categoriesList = await findAllCategories();
      setCategories(categoriesList);
    };

    asyncEffect();
  }, [findAllCategories]);

  const onSubmit = (data) => {
    handleSubmit(data);
    handleClose();
  };

  return (
    <div className={classes.modalBox}>
      <AppBar position="relative" className={classes.appBar}>
        <Toolbar>
          <Typography variant="h6" noWrap>
            {`${header} Característica`}
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
                    name="categoryId"
                    component={Select}
                    label="Categorias"
                    formControlProps={{ fullWidth: true }}
                  >
                    {categories?.map((category) => (
                      <MenuItem key={category.id} value={category.id}>
                        {category.description}
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

export default ModalCar;
