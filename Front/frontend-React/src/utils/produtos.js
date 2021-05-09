import api, { apiMultiData } from './api';

export const findAll = async () => {
  try {
    const response = await api.get('/v1/comparaItens/product/findAll');
    return response.data;
  } catch (err) {
    console.log(err);
  }
};

export const createItem = async (data) => {
  console.log(data)
  try {
    await apiMultiData.post('/v1/comparaItens/product/create', data);
  } catch (err) {
    console.log(err);
  }
};

export const deleteItem = async (id) => {
  try {
    await api.delete(`/v1/comparaItens/product/delete?id=${id}`);
  } catch (err) {
    console.log(err);
  }
};

export const updateItem = async (data) => {
  try {
    await api.put('v1/comparaItens/product/update', data);
  } catch (err) {
    console.log(err);
  }
};

export const findByKey = async (key) => {
  try {
    const response = await api.get(`/v1/comparaItens/characteristicKey/findByKey?key=${key}`);
    return response.data;
  } catch (err) {
    console.log(err);
  }
};

export const findAllKeys = async () => {
  try {
    const response = await api.get('/v1/comparaItens/characteristicKey/findAllKey');
    return response.data;
  } catch (err) {
    console.log(err);
  }
};

export const findByParameter = async (data) => {
  try {
    const res = await api.get('/v1/comparaItens/product/findByParameters', {
      params: data });
    console.log(res.data)
    return res.data;
  } catch (err) {
    console.log(err);
  }
};
