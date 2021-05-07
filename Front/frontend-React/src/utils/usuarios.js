import api from './api';

export const findAll = async () => {
  const response = await api.get('/v1/comparaItens/user/findAll');
  return response.data;
};

export const createItem = async (data) => {
  await api.post('/v1/comparaItens/user/create', data);
};

export const deleteItem = async (id) => {
  await api.delete(`/v1/comparaItens/user/delete?id=${id}`);
};

export const updateItem = async (data) => {
  await api.put('v1/comparaItens/user/update', data);
};

export const login = async (data) => {
  const res = await api.post('/v1/comparaItens/user/validateUser', data)
  return res.data?.data;
}