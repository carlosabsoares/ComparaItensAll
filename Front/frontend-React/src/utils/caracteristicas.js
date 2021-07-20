import api from './api';

export const findAll = async () => {
  const response = await api.get('/v1/comparaItens/characteristic/findAll');
  return response.data;
};

export const createItem = async (data) => {
  await api.post('v1/comparaItens/characteristic/create', data);
};

export const deleteItem = async (id) => {
  await api.delete(`/v1/comparaItens/characteristic/delete?id=${id}`);
};

export const updateItem = async (data) => {
  await api.put('v1/comparaItens/characteristic/update', data);
};

export const findById = async (id) => {
  const response = await api.get(`/v1/comparaItens/characteristic/findByCategoryId?id=${id}`);
  return response.data;
}