import { SIGN_IN_REQUEST, LOGOUT_REQUEST } from './actionTypes';

const signInRequest = (payload) => ({
  type: SIGN_IN_REQUEST,
  role: payload._result.role,
  token: payload.token,
  user: { 
    name: payload._result.name,
    login: payload._result.login
  },
});

const logoutRequest = () => ({
  type: LOGOUT_REQUEST,
});

export { signInRequest, logoutRequest };
