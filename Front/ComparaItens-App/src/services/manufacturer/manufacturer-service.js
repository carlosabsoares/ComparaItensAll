export async function findAll(token) {
  const response = await fetch('https://localhost:44324/v1/comparaItens/manufacturer/findAll', {
      method: 'GET',
      headers: {
          'Accept': 'application/json, text/plain, */*',
          'Content-Type': 'application/json',
          "Authorization": `Bearer ${token}`
      }

  })
  return await response.json()
}

export async function add(manufacturer, token) {
  const response = await fetch(
    'https://localhost:44324/v1/comparaItens/manufacturer/create',
    {
      method: 'POST',
      headers: {
        Accept: 'application/json, text/plain, */*',
        'Content-Type': 'application/json',
        Authorization: `Bearer ${token}`,
      },
      body: JSON.stringify(manufacturer),
    }
  )

  return await response.json()
}

export async function edit(manufacturer, token) {
  const response = await fetch(
    'https://localhost:44324/v1/comparaItens/manufacturer/update',
    {
      method: 'PUT',
      headers: {
        Accept: 'application/json, text/plain, */*',
        'Content-Type': 'application/json',
        Authorization: `Bearer ${token}`,
      },
      body: JSON.stringify(manufacturer),
    }
  )

  return await response.json()
}


export async function remove(token, id) {
  const response = await fetch(
    `https://localhost:44324/v1/comparaItens/manufacturer/delete?id=${id}`,
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


