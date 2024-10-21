import React, { useState, useEffect } from 'react';

import './App.css';

function Strojevi() {
    const [strojevi, setStrojevi] = useState([]);
    const [marka, setMarka] = useState('');
    const [model, setModel] = useState('');
    const [godiste, setGodiste] = useState('');
    const [tip, setTip] = useState('');
    const [kapacitetRezervoara, setKapacitetRezervoara] = useState('');
    const [idRadnika, setIdRadnika] = useState('');
    const [selectedId, setSelectedId] = useState(null);

    const token = localStorage.getItem('token'); 

    useEffect(() => {
        fetchStrojevi();
    }, []);

    const fetchStrojevi = async () => {
        try {
            const response = await fetch('https://paulovnija.site/api/Strojevi', {
                headers: {
                    'Authorization': `Bearer ${token}` 
                }
            });
            if (!response.ok) throw new Error('Network response was not ok');
            const data = await response.json();
            console.log('Data received:', data);
            setStrojevi(data);
        } catch (error) {
            console.error('There was a problem with the fetch operation:', error);
        }
    };

    const dodajStroj = async () => {
        const newStroj = {
            marka,
            model,
            godiste: parseInt(godiste, 10),
            tip,
            kapacitet_rezervoara: parseFloat(kapacitetRezervoara),
            id_radnika: parseInt(idRadnika, 10),
        };

        try {
            const response = await fetch('https://paulovnija.site/api/Strojevi', {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json',
                    'Authorization': `Bearer ${token}` 
                },
                body: JSON.stringify(newStroj),
            });
            if (!response.ok) {
                throw new Error(`HTTP error! status: ${response.status}`);
            }
            fetchStrojevi();
            resetForm();
        } catch (error) {
            console.error('Failed to add stroj:', error);
        }
    };

    const obrisiStroj = async (id) => {
        if (!id) {
            console.error('Invalid ID:', id);
            return;
        }
        try {
            const response = await fetch(`https://paulovnija.site/api/Strojevi/${id}`, {
                method: 'DELETE',
                headers: {
                    'Authorization': `Bearer ${token}` 
                }
            });
            if (!response.ok) {
                throw new Error(`HTTP error! status: ${response.status}`);
            }
            fetchStrojevi();
        } catch (error) {
            console.error('Failed to delete stroj:', error);
        }
    };

    const azurirajStroj = async () => {
        const updatedStroj = {
            ID_Stroja: selectedId,
            Marka: marka,
            Model: model,
            Godiste: parseInt(godiste, 10),
            Tip: tip,
            Kapacitet_rezervoara: parseFloat(kapacitetRezervoara),
            ID_Radnika: parseInt(idRadnika, 10),
        };

        try {
            const response = await fetch(`https://paulovnija.site/api/Strojevi/${selectedId}`, {
                method: 'PUT',
                headers: {
                    'Content-Type': 'application/json',
                    'Authorization': `Bearer ${token}` 
                },
                body: JSON.stringify(updatedStroj),
            });
            if (!response.ok) {
                throw new Error(`HTTP error! status: ${response.status}`);
            }
            fetchStrojevi();
            resetForm();
        } catch (error) {
            console.error('Failed to update stroj:', error);
        }
    };

    const resetForm = () => {
        setMarka('');
        setModel('');
        setGodiste('');
        setTip('');
        setKapacitetRezervoara('');
        setIdRadnika('');
        setSelectedId(null);
    };

    const odaberiStroj = (stroj) => {
        setMarka(stroj.marka);
        setModel(stroj.model);
        setGodiste(stroj.godiste);
        setTip(stroj.tip);
        setKapacitetRezervoara(stroj.kapacitet_rezervoara);
        setIdRadnika(stroj.id_radnika);
        setSelectedId(stroj.iD_Stroja); 
    };

    return (
        <div>
            <h2>Strojevi</h2>
            <form onSubmit={(e) => { e.preventDefault(); selectedId ? azurirajStroj() : dodajStroj(); }}>
                <input type="text" placeholder="Marka" value={marka || ''} onChange={(e) => setMarka(e.target.value)} required />
                <input type="text" placeholder="Model" value={model || ''} onChange={(e) => setModel(e.target.value)} required />
                <input type="number" placeholder="Godina" value={godiste || ''} onChange={(e) => setGodiste(e.target.value)} required />
                <input type="text" placeholder="Tip" value={tip || ''} onChange={(e) => setTip(e.target.value)} required />
                <input type="number" step="0.01" placeholder="Kapacitet rezervoara" value={kapacitetRezervoara || ''} onChange={(e) => setKapacitetRezervoara(e.target.value)} required />
                <input type="number" placeholder="ID Radnika" value={idRadnika || ''} onChange={(e) => setIdRadnika(e.target.value)} required />
                <button type="submit">{selectedId ? 'Ažuriraj Stroj' : 'Dodaj Stroj'}</button>
            </form>

            <table>
                <thead>
                    <tr>
                        <th>ID Stroja</th>
                        <th>Marka</th>
                        <th>Model</th>
                        <th>Godina</th>
                        <th>Tip</th>
                        <th>Kapacitet rezervoara</th>
                        <th>ID Radnika</th>
                        <th>Akcije</th>
                    </tr>
                </thead>
                <tbody>
                    {strojevi.map((stroj) => (
                        <tr key={stroj.iD_Stroja}>
                            <td>{stroj.iD_Stroja}</td>
                            <td>{stroj.marka}</td>
                            <td>{stroj.model}</td>
                            <td>{stroj.godiste}</td>
                            <td>{stroj.tip}</td>
                            <td>{stroj.kapacitet_rezervoara}</td>
                            <td>{stroj.id_radnika}</td>
                            <td>
                                <button onClick={() => odaberiStroj(stroj)}>Ažuriraj</button>
                                <button onClick={() => obrisiStroj(stroj.iD_Stroja)}>Obriši</button>
                            </td>
                        </tr>
                    ))}
                </tbody>
            </table>
        </div>
    );
}

export default Strojevi;
