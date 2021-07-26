import React, { useState } from 'react';
import { Redirect, useLocation } from 'react-router-dom';
import { useDispatch, useSelector } from 'react-redux';

import {
  AppBar,
  Button,
  CssBaseline,
  Divider,
  Drawer,
  Hidden,
  IconButton,
  List,
  ListItem,
  ListItemIcon,
  ListItemText,
  Toolbar,
  Typography,
} from '@material-ui/core';
import {
  AddShoppingCart as ProdutoIcon,
  CardGiftcard as CategoriaIcon,
  Search as SearchIcon,
  Person as PersonIcon,
  Menu as MenuIcon,
  Face as UserIcon,
  StorageOutlined as CategoriaItemIcon,
  AccountBalance as FabricanteIcon,
  WbIridescentOutlined as CaracteristicaIcon,
  VpnKey as LoginIcon,
} from '@material-ui/icons';
import { makeStyles, useTheme } from '@material-ui/core/styles';
import { logoutRequest } from '../../store/actions';

const drawerWidth = 240;

const useStyles = makeStyles((theme) => ({
  root: {
    display: 'flex',
  },
  button: {
    width: '120px',
    display: 'flex',
    justifyContent: 'space-around',
  },
  drawer: {
    [theme.breakpoints.up('sm')]: {
      width: drawerWidth,
      flexShrink: 0,
    },
  },
  appBar: {
    [theme.breakpoints.up('sm')]: {
      width: `calc(100% - ${drawerWidth}px)`,
      marginLeft: drawerWidth,
    },
  },
  header: {
    display: 'flex',
    justifyContent: 'space-between',
    width: '100%',
    alignItems: 'baseline',
  },
  menuButton: {
    marginRight: theme.spacing(2),
    [theme.breakpoints.up('sm')]: {
      display: 'none',
    },
  },
  toolbar: theme.mixins.toolbar,
  drawerPaper: {
    width: drawerWidth,
  },
  content: {
    flexGrow: 1,
    padding: theme.spacing(3),
  },
}));

function NavBar(props) {
  const { window, children, header } = props;
  const classes = useStyles();
  const location = useLocation();
  const theme = useTheme();
  const [mobileOpen, setMobileOpen] = useState(false);
  const [redirect, setRedirect] = useState({
    path: '/',
    redirect: false,
  });
  const signedIn = useSelector((state) => state.loginReducer.signedIn);
  const role = useSelector((state) => state.loginReducer.role)
  const user = useSelector((state) => state.loginReducer.user)
  const dispatch = useDispatch();

  const handleDrawerToggle = () => {
    setMobileOpen(!mobileOpen);
  };

  const handleLogout = () => {
    dispatch(logoutRequest());
  };

  const drawer = (
    <div>
      <div className={classes.toolbar}>
        <List>
          <ListItem>
            <ListItemIcon>
              <PersonIcon />
            </ListItemIcon>
            <ListItemText primary={user.login} />
          </ListItem>
        </List>
      </div>
      <Divider />
      <List>
        <ListItem
          button
          key="Home"
          onClick={() =>
            setRedirect({
              path: '/home',
              redirect: true,
            })
          }
        >
          <ListItemIcon>
            <SearchIcon />
          </ListItemIcon>
          <ListItemText primary="Pesquisar" />
        </ListItem>
      </List>
      <Divider />
      {signedIn && role === 'Administrator' && (
        <List>
          <ListItem
            button
            key="Fabricantes"
            onClick={() =>
              setRedirect({
                path: '/fabricantes',
                redirect: true,
              })
            }
          >
            <ListItemIcon>
              <FabricanteIcon />
            </ListItemIcon>
            <ListItemText primary="Fabricantes" />
          </ListItem>
          <ListItem
            button
            key="Categorias"
            onClick={() =>
              setRedirect({
                path: '/categorias',
                redirect: true,
              })
            }
          >
            <ListItemIcon>
              <CategoriaIcon />
            </ListItemIcon>
            <ListItemText primary="Categorias" />
          </ListItem>
          <ListItem
            button
            key="Características"
            onClick={() =>
              setRedirect({
                path: '/caracteristicas',
                redirect: true,
              })
            }
          >
            <ListItemIcon>
              <CaracteristicaIcon />
            </ListItemIcon>
            <ListItemText primary="Características" />
          </ListItem>
          <ListItem
            button
            key="Características Itens"
            onClick={() =>
              setRedirect({
                path: '/caracteristicasitens',
                redirect: true,
              })
            }
          >
            <ListItemIcon>
              <CategoriaItemIcon />
            </ListItemIcon>
            <ListItemText primary="Características Itens" />
          </ListItem>
          <ListItem
            button
            key="Produtos"
            onClick={() =>
              setRedirect({
                path: '/produtos',
                redirect: true,
              })
            }
          >
            <ListItemIcon>
              <ProdutoIcon />
            </ListItemIcon>
            <ListItemText primary="Produtos" />
          </ListItem>
        </List>
      )}
      {signedIn && role === 'Administrator' && <Divider />}
      {signedIn && role === 'Administrator' && (
        <List>
          <ListItem
            button
            key="Usuarios"
            onClick={() =>
              setRedirect({
                path: '/usuarios',
                redirect: true,
              })
            }
          >
            <ListItemIcon>
              <UserIcon />
            </ListItemIcon>
            <ListItemText primary="Usuários" />
          </ListItem>
        </List>
      )}
    </div>
  );

  const container = window !== undefined ? () => window().document.body : undefined;

  if (redirect.redirect && redirect.path !== location.pathname) {
    return <Redirect to={redirect.path} />;
  }

  return (
    <div className={classes.root}>
      <CssBaseline />
      <AppBar position="fixed" className={classes.appBar}>
        <Toolbar>
          <IconButton
            color="inherit"
            aria-label="open drawer"
            edge="start"
            onClick={handleDrawerToggle}
            className={classes.menuButton}
          >
            <MenuIcon />
          </IconButton>
          <div className={classes.header}>
            <Typography variant="h6" noWrap>
              {header}
            </Typography>
            {signedIn ? (
              <Button
                variant="contained"
                color="primary"
                disableElevation
                size="small"
                className={classes.button}
                onClick={handleLogout}
              >
                Logout
                <LoginIcon />
              </Button>
            ) : (
              <Button
                variant="contained"
                color="primary"
                disableElevation
                size="small"
                className={classes.button}
                onClick={() =>
                  setRedirect({
                    path: '/',
                    redirect: true,
                  })
                }
              >
                Login
                <LoginIcon />
              </Button>
            )}
          </div>
        </Toolbar>
      </AppBar>
      <nav className={classes.drawer} aria-label="mailbox folders">
        <Hidden smUp implementation="css">
          <Drawer
            container={container}
            variant="temporary"
            anchor={theme.direction === 'rtl' ? 'right' : 'left'}
            open={mobileOpen}
            onClose={handleDrawerToggle}
            classes={{
              paper: classes.drawerPaper,
            }}
            ModalProps={{
              keepMounted: true,
            }}
          >
            {drawer}
          </Drawer>
        </Hidden>
        <Hidden xsDown implementation="css">
          <Drawer
            classes={{
              paper: classes.drawerPaper,
            }}
            variant="permanent"
            open
          >
            {drawer}
          </Drawer>
        </Hidden>
      </nav>
      <main className={classes.content}>
        <div className={classes.toolbar} />
        {children}
      </main>
    </div>
  );
}

export default NavBar;
