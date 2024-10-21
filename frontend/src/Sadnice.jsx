import React, { useState, useEffect } from 'react';

import './App.css';

function Sadnice() {
  const [sadnice, setSadnice] = useState([]);
  const [vrsta, setVrsta] = useState('');
  const [visina, setVisina] = useState('');
  const [starost, setStarost] = useState('');
  const [datumSadnje, setDatumSadnje] = useState(''); 
  const [idRasadnika, setIdRasadnika] = useState('');
  const [selectedId, setSelectedId] = useState(null); 
  
  const token = localStorage.getItem('token'); 

  useEffect(() => {
    fetchSadnice();
  }, []);

  const fetchSadnice = async () => {
    try {
      const response = await fetch('https://paulovnija.site/api/Sadnice', {
        headers: {
          'Authorization': `Bearer ${token}`
        }
      });
      if (!response.ok) throw new Error('Network response was not ok');
      const data = await response.json();
      console.log('Data received:', data);
      setSadnice(data);
    } catch (error) {
      console.error('There was a problem with the fetch operation:', error);
    }
  };

  const dodajSadnicu = async () => {
    const formattedDate = new Date(datumSadnje).toISOString(); 
    const newSadnica = {
      vrsta,
      visina: parseFloat(visina),
      starost: parseInt(starost),
      datum_sadnje: formattedDate,
      ID_Rasadnika: parseInt(idRasadnika),
    };

    try {
      const response = await fetch('https://paulovnija.site/api/Sadnice', {
        method: 'POST',
        headers: { 
          'Content-Type': 'application/json',
          'Authorization': `Bearer ${token}` 
        },
        body: JSON.stringify(newSadnica),
      });
      if (!response.ok) {
        throw new Error(`HTTP error! status: ${response.status}`);
      }
      fetchSadnice();
      resetForm();
    } catch (error) {
      console.error('Failed to add sadnicu:', error);
    }
  };

  const obrisiSadnicu = async (id) => {
    if (!id) {
      console.error('Invalid ID:', id);
      return;
    }
    try {
      const response = await fetch(`https://paulovnija.site/api/Sadnice/${id}`, {
        method: 'DELETE',
        headers: {
          'Authorization': `Bearer ${token}` 
        }
      });
      if (!response.ok) {
        throw new Error(`HTTP error! status: ${response.status}`);
      }
      fetchSadnice();
    } catch (error) {
      console.error('Failed to delete sadnicu:', error);
    }
  };

  const azurirajSadnicu = async () => {
    if (!selectedId) {
        console.error('Selected ID is missing.');
        return;
    }

    const updatedSadnica = { 
        id_sadnice: selectedId,  
        vrsta, 
        visina: parseFloat(visina), 
        starost: parseInt(starost, 10), 
        datum_sadnje: datumSadnje, 
        id_rasadnika: parseInt(idRasadnika, 10) 
    };

  
    if (!datumSadnje || isNaN(new Date(datumSadnje).getTime())) {
        console.error('Datum sadnje nije ispravan:', datumSadnje);
        return;
    }

    try {
        const response = await fetch(`https://paulovnija.site/api/Sadnice/${selectedId}`, {
            method: 'PUT',
            headers: { 
                'Content-Type': 'application/json',
                'Authorization': `Bearer ${token}` 
            },
            body: JSON.stringify(updatedSadnica),
        });

        if (!response.ok) {
            const errorText = await response.text();
            throw new Error(`HTTP error! status: ${response.status}, message: ${errorText}`);
        }

        fetchSadnice();
        resetForm();
    } catch (error) {
        console.error('Failed to update sadnicu:', error);
    }
  };

  const resetForm = () => {
    setVrsta('');
    setVisina('');
    setStarost('');
    setDatumSadnje('');
    setIdRasadnika('');
    setSelectedId(null);
  };

  const odaberiSadnicu = (sadnica) => {
    setVrsta(sadnica.vrsta);
    setVisina(sadnica.visina);
    setStarost(sadnica.starost);
    setDatumSadnje(sadnica.datum_sadnje.substring(0, 10));
    setIdRasadnika(sadnica.iD_Rasadnika);
    setSelectedId(sadnica.iD_Sadnice);
  };

  return (
    <div>
      <h2>Sadnice</h2>
      <form onSubmit={(e) => { e.preventDefault(); selectedId ? azurirajSadnicu() : dodajSadnicu(); }}>
        {selectedId && ( 
          <input type="number" value={selectedId} readOnly placeholder="ID Sadnice" />
        )}
        <input type="text" placeholder="Vrsta" value={vrsta} onChange={(e) => setVrsta(e.target.value)} required />
        <input type="number" placeholder="Visina" value={visina} onChange={(e) => setVisina(e.target.value)} required />
        <input type="number" placeholder="Starost" value={starost} onChange={(e) => setStarost(e.target.value)} required />
        <input type="date" value={datumSadnje} onChange={(e) => setDatumSadnje(e.target.value)} required />
        <input type="number" placeholder="ID Rasadnika" value={idRasadnika} onChange={(e) => setIdRasadnika(e.target.value)} required />
        <button type="submit">{selectedId ? 'Ažuriraj Sadnicu' : 'Dodaj Sadnicu'}</button>
      </form>

      <table>
        <thead>
          <tr>
            <th>ID Sadnice</th>
            <th>Vrsta</th>
            <th>Visina</th>
            <th>Starost</th>
            <th>Datum sadnje</th>
            <th>ID Rasadnika</th>
            <th>Akcije</th>
          </tr>
        </thead>
        <tbody>
          {sadnice.map((sadnica) => (
            <tr key={sadnica.iD_Sadnice}>
              <td>{sadnica.iD_Sadnice}</td>
              <td>{sadnica.vrsta}</td>
              <td>{sadnica.visina}</td>
              <td>{sadnica.starost}</td>
              <td>{sadnica.datum_sadnje}</td>
              <td>{sadnica.iD_Rasadnika}</td>
              <td>
                <button onClick={() => odaberiSadnicu(sadnica)}>Ažuriraj</button>
                <button onClick={() => obrisiSadnicu(sadnica.iD_Sadnice)}>Obriši</button>
              </td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}

export default Sadnice;
