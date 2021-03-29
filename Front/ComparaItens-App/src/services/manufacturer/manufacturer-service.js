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

  await new Promise((resolve) => setTimeout(resolve, 1000))
  // return [
  //   { id: '123123', description: 'asdasdasdasdsa' },
  //   { id: '123123', description: 'asdasdasdasdsa' },
  //   { id: '123123', description: 'asdasdasdasdsa' },
  // ]
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
