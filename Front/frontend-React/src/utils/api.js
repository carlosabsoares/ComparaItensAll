import axios from 'axios';
import store from '../store';

const api = axios.create({
  baseURL: process.env.REACT_APP_URL,
});

api.interceptors.request.use((config) => {
  const { token } = store.getState().loginReducer;

  const headers = { ...config.headers, };

  if (token) {
    headers.Authorization = `Bearer ${token}`;
  }

  return { ...config, headers };
});

export default api;
