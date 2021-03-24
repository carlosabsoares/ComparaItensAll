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