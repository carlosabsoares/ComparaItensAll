import api from './api';

export const findAll = async () => {
  const response = await api.get('/v1/comparaItens/characteristicKey/findAll');
  return response.data;
};

export const createItem = async (data) => {
  await api.post('/v1/comparaItens/characteristicKey/create', data);
};

export const deleteItem = async (id) => {
  const a = await api.delete(`/v1/comparaItens/characteristicKey/delete?id=${id}`);
};

export const updateItem = async (data) => {
  await api.put('v1/comparaItens/characteristicKey/update', data);
};
