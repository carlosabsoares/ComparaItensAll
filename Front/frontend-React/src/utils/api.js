import axios from 'axios';
import store from '../store';

const api = axios.create({
  // baseURL: 'https://buscaitens.azurewebsites.net',
  baseURL: 'https://localhost:5001',
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
