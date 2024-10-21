const fetchProtectedData = async () => {
    const token = localStorage.getItem('token');

    const response = await fetch('https://paulovnija.site/api/v1/Autorizacija/protected-data', {
        method: 'GET',
        headers: {
            'Authorization': `Bearer ${token}`,
            'Content-Type': 'application/json',
        },
    });

    if (response.ok) {
        const data = await response.json();
        console.log(data);
    } else {
        console.error('Došlo je do greške prilikom pristupa zaštićenim podacima.');
    }
};
