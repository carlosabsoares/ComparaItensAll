import api from './api';

export const findAll = async () => {
  const response = await api.get('/v1/comparaItens/characteristicDescription/findAll');
  return response.data;
};

export const createItem = async (data) => {
  await api.post('/v1/comparaItens/characteristicDescription/create', data);
};

export const deleteItem = async (id) => {
  await api.delete(`/v1/comparaItens/characteristicDescription/delete?id=${id}`);
};

export const updateItem = async (data) => {
  await api.put('v1/comparaItens/characteristicDescription/update', data);
};
