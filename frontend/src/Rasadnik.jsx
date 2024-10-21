import React, { useState, useEffect, useContext } from 'react';
import { AuthContext } from './AuthContext'; 
import './App.css';

function Rasadnici() {
  const [rasadnici, setRasadnici] = useState([]);
  const [naziv, setNaziv] = useState('');
  const [lokacija, setLokacija] = useState('');
  const [povrsina, setPovrsina] = useState('');
  const [datumOtvaranja, setDatumOtvaranja] = useState(''); 
  const [selectedId, setSelectedId] = useState(null);

  const { user } = useContext(AuthContext); 
  const token = user?.token;

  useEffect(() => {
    fetchRasadnici();
  }, []);

  const fetchRasadnici = async () => {
    try {
      const response = await fetch('https://paulovnija.site/api/Rasadnici', {
        headers: {
          'Authorization': `Bearer ${token}`, 
          'Content-Type': 'application/json'
        }
      });
      if (!response.ok) throw new Error('Network response was not ok');
      const data = await response.json();
      console.log('Data received:', data);
      setRasadnici(data);
    } catch (error) {
      console.error('There was a problem with the fetch operation:', error);
    }
  };

  const dodajRasadnik = async () => {
    const newRasadnik = { 
      naziv, 
      lokacija, 
      povrsina: parseFloat(povrsina), 
      datum_otvaranja: datumOtvaranja 
    };
    try {
      const response = await fetch('https://paulovnija.site/api/Rasadnici', {
        method: 'POST',
        headers: { 
          'Authorization': `Bearer ${token}`, 
          'Content-Type': 'application/json' 
        },
        body: JSON.stringify(newRasadnik),
      });
      if (!response.ok) {
        throw new Error(`HTTP error! status: ${response.status}`);
      }
      fetchRasadnici();
      resetForm();
    } catch (error) {
      console.error('Failed to add rasadnik:', error);
    }
  };

  const obrisiRasadnik = async (id) => {
    if (!id) {
      console.error('Invalid ID:', id);
      return;
    }
    try {
      const response = await fetch(`https://paulovnija.site/api/Rasadnici/${id}`, {
        method: 'DELETE',
        headers: {
          'Authorization': `Bearer ${token}` 
        }
      });
      if (!response.ok) {
        throw new Error(`HTTP error! status: ${response.status}`);
      }
      fetchRasadnici();
    } catch (error) {
      console.error('Failed to delete rasadnik:', error);
    }
  };

  const azurirajRasadnik = async () => {
    if (!selectedId) {
        console.error('Selected ID is missing.');
        return;
    }

    const updatedRasadnik = { 
        id_rasadnika: selectedId,  
        naziv, 
        lokacija, 
        povrsina: parseFloat(povrsina), 
        datum_otvaranja: datumOtvaranja 
    };

    
    if (!datumOtvaranja || isNaN(new Date(datumOtvaranja).getTime())) {
        console.error('Datum otvaranja nije ispravan:', datumOtvaranja);
        return;
    }

    try {
        const response = await fetch(`https://paulovnija.site/api/Rasadnici/${selectedId}`, {
            method: 'PUT',
            headers: { 
              'Authorization': `Bearer ${token}`, 
              'Content-Type': 'application/json' 
            },
            body: JSON.stringify(updatedRasadnik),
        });

        if (!response.ok) {
            const errorText = await response.text();
            throw new Error(`HTTP error! status: ${response.status}, message: ${errorText}`);
        }

        fetchRasadnici();
        resetForm();
    } catch (error) {
        console.error('Failed to update rasadnik:', error);
    }
  };

  const resetForm = () => {
    setNaziv('');
    setLokacija('');
    setPovrsina('');
    setDatumOtvaranja('');
    setSelectedId(null);
  };

  const odaberiRasadnik = (rasadnik) => {
    setNaziv(rasadnik.naziv);
    setLokacija(rasadnik.lokacija);
    setPovrsina(rasadnik.povrsina);

    
    let datum = rasadnik.datum_otvaranja;
    if (datum === "0001-01-01T00:00:00") {
      datum = ''; 
    } else {
      datum = datum.substring(0, 10); 
    }
    setDatumOtvaranja(datum); 

    setSelectedId(rasadnik.iD_Rasadnika);
  };

  return (
    <div>
      <h2>Rasadnici</h2>
      <form onSubmit={(e) => { e.preventDefault(); selectedId ? azurirajRasadnik() : dodajRasadnik(); }}>
        <input type="text" placeholder="Naziv" value={naziv} onChange={(e) => setNaziv(e.target.value)} required />
        <input type="text" placeholder="Lokacija" value={lokacija} onChange={(e) => setLokacija(e.target.value)} required />
        <input type="number" placeholder="Površina" value={povrsina} onChange={(e) => setPovrsina(e.target.value)} required />
        <input type="date" placeholder="Datum otvaranja" value={datumOtvaranja} onChange={(e) => setDatumOtvaranja(e.target.value)} required />
        <button type="submit">{selectedId ? 'Ažuriraj Rasadnik' : 'Dodaj Rasadnik'}</button>
      </form>

      <table>
        <thead>
          <tr>
            <th>ID_Rasadnika</th>
            <th>Naziv</th>
            <th>Lokacija</th>
            <th>Površina</th>
            <th>Datum otvaranja</th>
            <th>Akcije</th>
          </tr>
        </thead>
        <tbody>
          {rasadnici.map((rasadnik) => (
            <tr key={rasadnik.iD_Rasadnika}>
              <td>{rasadnik.iD_Rasadnika}</td>
              <td>{rasadnik.naziv}</td>
              <td>{rasadnik.lokacija}</td>
              <td>{rasadnik.povrsina}</td>
              <td>{rasadnik.datum_otvaranja}</td>
              <td>
                <button onClick={() => odaberiRasadnik(rasadnik)}>Ažuriraj</button>
                <button onClick={() => obrisiRasadnik(rasadnik.iD_Rasadnika)}>Obriši</button>
              </td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}

export default Rasadnici;
