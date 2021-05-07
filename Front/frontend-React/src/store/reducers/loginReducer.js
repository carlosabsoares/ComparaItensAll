import { SIGN_IN_REQUEST, LOGOUT_REQUEST } from '../actions/actionTypes';

const initialState = {
  token: null,
  signedIn: false,
};

const loginReducer = (state = initialState, action) => {
  switch (action.type) {
    case SIGN_IN_REQUEST:
      return {
        ...state,
        token: action.payload,
        signedIn: true,
      };
    case LOGOUT_REQUEST:
      return {
        ...state,
        token: null,
        signedIn: false,
      };
    default:
      return state;
  }
};

export default loginReducer;
