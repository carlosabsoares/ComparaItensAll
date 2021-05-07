import { SIGN_IN_REQUEST, LOGOUT_REQUEST } from './actionTypes';

const signInRequest = (payload) => ({
  type: SIGN_IN_REQUEST,
  payload,
});

const logoutRequest = () => ({
  type: LOGOUT_REQUEST,
});

export { signInRequest, logoutRequest };
