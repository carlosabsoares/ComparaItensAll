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
      <Route exact path="/" component={Home} />
      <Route path="/login" component={Login} />
      <Route path="/fabricantes" needsAuth component={Fabricantes} />
      <Route path="/categorias" needsAuth component={Categorias} />
      <Route path="/caracteristicas" needsAuth component={Caracteristicas} />
      <Route path="/caracteristicasitens" needsAuth component={CaracteristicasItens} />
      <Route path="/produtos" needsAuth component={Produtos} />
      <Route path="/usuarios" needsAuth component={Usuarios} />
    </Switch>
  </BrowserRouter>
);

export default Routes;
