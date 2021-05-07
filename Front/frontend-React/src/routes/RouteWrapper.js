import React from 'react';
import { useSelector } from 'react-redux';

import { Route, Redirect } from 'react-router-dom';

const RouteWrapper = ({ component: Component, needsAuth = false, ...rest }) => {
  const signed = useSelector((state) => state.loginReducer.signedIn);

  if (!signed && needsAuth) {
    return <Redirect to="/login" />;
  }

  return (
    <Route
      {...rest}
      render={() => (
        <div>
          <Component />
        </div>
      )}
    />
  );
};

export default RouteWrapper;
