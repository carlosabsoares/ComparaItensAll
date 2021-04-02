export async function findAll(token) {
    const response = await fetch(
      'https://localhost:44324/v1/comparaItens/product/findAll',
      {
        method: 'GET',
        headers: {
          Accept: 'application/json, text/plain, */*',
          'Content-Type': 'application/json',
          Authorization: `Bearer ${token}`,
        },
      }
    )
    return await response.json()

  await new Promise((resolve) => setTimeout(resolve, 1000))
  // return [
  //   {
  //     id: '1123123',
  //     description: 'descricao',
  //     category: 'asdasdasd',
  //     manufacturer: 'manufacturermanufacturer',
  //   },
  //   {
  //     id: '12312',
  //     description: 'descricao',
  //     category: 'asdasdasd',
  //     manufacturer: 'manufacturermanufacturer',
  //   },
  //   {
  //     id: 'asdasd',
  //     description: 'descricao',
  //     category: 'asdasdasd',
  //     manufacturer: 'manufacturermanufacturer',
  //   },
  // ]
}

export async function add(product, token) {
  const response = await fetch(
    'https://localhost:44324/v1/comparaItens/product/create',
    {
      method: 'POST',
      headers: {
        Accept: 'application/json, text/plain, */*',
        'Content-Type': 'application/json',
        Authorization: `Bearer ${token}`,
      },
      body: JSON.stringify(product),
    }
  )

  return await response.json()
}

export async function remove(token, id) {
  const response = await fetch(
    `https://localhost:44324/v1/comparaItens/manufacturer/${id}`,
    {
      method: 'DELETE',
      headers: {
        Accept: 'application/json, text/plain, */*',
        'Content-Type': 'application/json',
        Authorization: `Bearer ${token}`,
      },
    }
  )
  return await response.json()
}
