import React, { useState, forwardRef } from 'react';
import { AppBar, Toolbar, Typography, TextField, Button } from '@material-ui/core';
import { makeStyles } from '@material-ui/core/styles';

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

const ModalCat = forwardRef(({ item }, _ref) => {
  const classes = useStyles();
  const [description, setDescription] = useState(item?.description || '');
  return (
    <div className={classes.modalBox}>
      <AppBar position="relative" className={classes.appBar}>
        <Toolbar>
          <Typography variant="h6" noWrap>
            {item.category.description}
          </Typography>
        </Toolbar>
      </AppBar>
      <div className={classes.modalBody}>
        <Typography variant="h6">Modelo:</Typography>
        <Typography variant="body2">{item.model}</Typography>

        <Typography variant="h6">Fabricante:</Typography>
        <Typography variant="body2">{item.manufecturer.description}</Typography>

        <Typography variant="h6">Ano de Fabricação:</Typography>
        <Typography variant="body2">{item.yearOfManufacture}</Typography>

        <Typography variant="h6">Descrição:</Typography>
        <Typography variant="body2">{item.description}</Typography>

        <Typography variant="h6">Caracteristicas:</Typography>
        {item.characteristicDescriptions.map((char) => (
          <div>
            <Typography variant="body2">{`${char.characteristics.description} - ${char.characteristicKeys.description}`}</Typography>
          </div>
        ))}
      </div>
    </div>
  );
});

export default ModalCat;
