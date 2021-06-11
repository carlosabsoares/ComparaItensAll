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

const ModalCat = forwardRef(({ header, handleSubmit, item, handleClose }, _ref) => {
  const classes = useStyles();
  const [description, setDescription] = useState(item?.description || '');

  return (
    <div className={classes.modalBox}>
      <AppBar position="relative" className={classes.appBar}>
        <Toolbar>
          <Typography variant="h6" noWrap>
            {`${header} Categoria`}
          </Typography>
        </Toolbar>
      </AppBar>
      <div className={classes.modalBody}>
        <TextField
          label="Descrição"
          name="description"
          defaultValue={description}
          onChange={(e) => setDescription(e.target.value)}
          variant="outlined"
          size="small"
        />
        <Button
          type="button"
          variant="contained"
          size="small"
          color="primary"
          className={classes.button}
          onClick={async () => {
            await handleSubmit({ description });
            handleClose();
          }}
        >
          Enviar
        </Button>
      </div>
    </div>
  );
});

export default ModalCat;
