export async function findAll(token) {
  const response = await fetch(
    'https://localhost:44324/v1/comparaItens/category/findAll',
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

  // await new Promise((resolve) => setTimeout(resolve, 1000))
  // return [
  //   { id: '23232323', description: 'desc123123123123' },
  //   { id: '23232323', description: 'desc123123123123' },
  //   { id: '23232323', description: 'desc123123123123' },
  //   { id: '23232323', description: 'desc123123123123' },
  // ]
}

export async function add(category, token) {
  const response = await fetch(
    'https://localhost:44324/v1/comparaItens/category/create',
    {
      method: 'POST',
      headers: {
        Accept: 'application/json, text/plain, */*',
        'Content-Type': 'application/json',
        Authorization: `Bearer ${token}`,
      },
      body: JSON.stringify(category),
    }
  )

  return await response.json()
}

export async function remove(token, id) {
  const response = await fetch(
    `https://localhost:44324/v1/comparaItens/category/delete?id=${id}`,
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


