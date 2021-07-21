import React from 'react';
import { Switch, BrowserRouter } from 'react-router-dom';

import Home from '../screens/Home';
import Fabricantes from '../screens/Fabricantes';
import Categorias from '../screens/Categorias';
import Caracteristicas from '../screens/Caracteristicas';
import Produtos from '../screens/Produtos';
import CaracteristicasItens from '../screens/CaracteristicasItens';
import Usuarios from '../screens/Usuarios';
import Login from '../screens/Login';

import Route from './RouteWrapper';

const Routes = () => (
  <BrowserRouter>
    <Switch>
      <Route exact path="/" component={Login} />
      <Route path="/Home" component={Home} needsAuth />
      <Route path="/fabricantes" component={Fabricantes} needsAuth />
      <Route path="/categorias" component={Categorias} needsAuth />
      <Route path="/caracteristicas" component={Caracteristicas} needsAuth />
      <Route path="/caracteristicasitens" component={CaracteristicasItens} needsAuth />
      <Route path="/produtos" component={Produtos} needsAuth />
      <Route path="/usuarios" component={Usuarios} needsAuth />
    </Switch>
  </BrowserRouter>
);

export default Routes;
