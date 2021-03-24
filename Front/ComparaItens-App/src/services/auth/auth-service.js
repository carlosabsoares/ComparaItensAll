export async function fetchAuthToken(login, password) {
    const params = {
        login,
        password
    }
    return await fetch('https://localhost:44324/v1/comparaItens/user/validateUser', {
        headers: {
            'Accept': 'application/json, text/plain, */*',
            'Content-Type': 'application/json'
        },
        method: 'POST',
        body: JSON.stringify(params)
    })
}