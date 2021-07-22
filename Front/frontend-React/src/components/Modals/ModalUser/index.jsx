import React, { useState, forwardRef } from 'react';
import { AppBar, Toolbar, Typography, TextField, Button, Checkbox, FormControlLabel } from '@material-ui/core';
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

const ModalUser = forwardRef(({ header, handleSubmit, item, handleClose, isCreate }, _ref) => {
  const classes = useStyles();
  const [login, setLogin] = useState(item?.login || '');
  const [password, setPassword] = useState(item?.password || '');
  const [name, setName] = useState(item?.name || '');
  const [email, setEmail] = useState(item?.email || '');
  const [role, setRole] = useState('User');

  return (
    <div className={classes.modalBox}>
      <AppBar position="relative" className={classes.appBar}>
        <Toolbar>
          <Typography variant="h6" noWrap>
            {`${header} Usuário`}
          </Typography>
        </Toolbar>
      </AppBar>
      <div className={classes.modalBody}>
        <TextField
          label="Login"
          name="login"
          defaultValue={login}
          onChange={(e) => setLogin(e.target.value)}
          variant="outlined"
          size="small"
        />
        {isCreate && <TextField
          className={classes.marginTop}
          label="Password"
          type="password"
          name="key"
          defaultValue={password}
          onChange={(e) => setPassword(e.target.value)}
          variant="outlined"
          size="small"
        />}
        <TextField
          className={classes.marginTop}
          label="Nome"
          name="name"
          defaultValue={name}
          onChange={(e) => setName(e.target.value)}
          variant="outlined"
          size="small"
        />
        <TextField
          className={classes.marginTop}
          label="Email"
          name="email"
          defaultValue={email}
          onChange={(e) => setEmail(e.target.value)}
          variant="outlined"
          size="small"
        />
        <FormControlLabel
          labelPlacement="start"
          control={<Checkbox checked={role === "Administrator"} onChange={(e) => setRole(e.target.checked ? "Administrator" : "User" )} />}
          label="Administrador"
        />
        <Button
          type="button"
          variant="contained"
          size="small"
          color="primary"
          className={classes.button}
          onClick={async () => {
            await handleSubmit(name, login, email, password, role);
            handleClose();
          }}
        >
          Enviar
        </Button>
      </div>
    </div>
  );
});

export default ModalUser;
