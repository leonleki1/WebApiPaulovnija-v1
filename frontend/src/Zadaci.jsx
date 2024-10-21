import React, { useState, useEffect } from 'react';

function Zadaci() {
  const [zadaci, setZadaci] = useState([]);
  const [opis, setOpis] = useState('');
  const [datumPocetka, setDatumPocetka] = useState('');
  const [datumZavrsetka, setDatumZavrsetka] = useState('');
  const [statusZadatka, setStatusZadatka] = useState('');
  const [idRadnika, setIdRadnika] = useState('');
  const [selectedId, setSelectedId] = useState(null);
  
  
  const token = localStorage.getItem('token');

  useEffect(() => {
    fetchZadaci();
  }, []);

  const fetchZadaci = async () => {
    try {
      const response = await fetch('https://paulovnija.site/api/v1/Zadatak', {
        headers: {
          'Authorization': `Bearer ${token}` 
        }
      });
      if (!response.ok) throw new Error('Network response was not ok');
      const data = await response.json();
      console.log('Data received:', data);
      setZadaci(data);
    } catch (error) {
      console.error('There was a problem with the fetch operation:', error);
    }
  };

  const dodajZadatak = async () => {
    const newZadatak = {
      opis,
      datum_pocetka: datumPocetka,
      datum_zavrsetka: datumZavrsetka,
      status_Zadatka: statusZadatka,
      id_radnika: parseInt(idRadnika),
    };
    try {
      const response = await fetch('https://paulovnija.site/api/v1/Zadatak', {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json',
          'Authorization': `Bearer ${token}` 
        },
        body: JSON.stringify(newZadatak),
      });
      if (!response.ok) {
        throw new Error(`HTTP error! status: ${response.status}`);
      }
      fetchZadaci();
      resetForm();
    } catch (error) {
      console.error('Failed to add task:', error);
    }
  };

  const obrisiZadatak = async (id) => {
    if (!id) {
      console.error('Invalid ID:', id);
      return;
    }
    try {
      const response = await fetch(`https://paulovnija.site/api/v1/Zadatak/${id}`, {
        method: 'DELETE',
        headers: {
          'Authorization': `Bearer ${token}` 
        }
      });
      if (!response.ok) {
        throw new Error(`HTTP error! status: ${response.status}`);
      }
      fetchZadaci();
    } catch (error) {
      console.error('Failed to delete task:', error);
    }
  };

  const azurirajZadatak = async () => {
    const updatedZadatak = {
      opis,
      datum_pocetka: datumPocetka,
      datum_zavrsetka: datumZavrsetka,
      status_Zadatka: statusZadatka,
      id_radnika: parseInt(idRadnika),
    };
    try {
      const response = await fetch(`https://paulovnija.site/api/v1/Zadatak/${selectedId}`, {
        method: 'PUT',
        headers: {
          'Content-Type': 'application/json',
          'Authorization': `Bearer ${token}` // Dodajete token u zaglavlje
        },
        body: JSON.stringify(updatedZadatak),
      });
      if (!response.ok) {
        throw new Error(`HTTP error! status: ${response.status}`);
      }
      fetchZadaci();
      resetForm();
    } catch (error) {
      console.error('Failed to update task:', error);
    }
  };

  const resetForm = () => {
    setOpis('');
    setDatumPocetka('');
    setDatumZavrsetka('');
    setStatusZadatka('');
    setIdRadnika('');
    setSelectedId(null);
  };

  const odaberiZadatak = (zadatak) => {
    setOpis(zadatak.opis);
    setDatumPocetka(zadatak.datum_pocetka);
    setDatumZavrsetka(zadatak.datum_zavrsetka);
    setStatusZadatka(zadatak.status_Zadatka);
    setIdRadnika(zadatak.id_radnika);
    setSelectedId(zadatak.iD_Zadatka);
  };

  return (
    <div>
      <h2>Zadaci</h2>
      <form
        onSubmit={(e) => {
          e.preventDefault();
          selectedId ? azurirajZadatak() : dodajZadatak();
        }}
      >
        <input
          type="text"
          placeholder="Opis"
          value={opis}
          onChange={(e) => setOpis(e.target.value)}
          required
        />
        <input
          type="date"
          placeholder="Datum Pocetka"
          value={datumPocetka}
          onChange={(e) => setDatumPocetka(e.target.value)}
          required
        />
        <input
          type="date"
          placeholder="Datum Zavrsetka"
          value={datumZavrsetka}
          onChange={(e) => setDatumZavrsetka(e.target.value)}
          required
        />
        <input
          type="text"
          placeholder="Status Zadatka"
          value={statusZadatka}
          onChange={(e) => setStatusZadatka(e.target.value)}
          required
        />
        <input
          type="number"
          placeholder="ID Radnika"
          value={idRadnika}
          onChange={(e) => setIdRadnika(e.target.value)}
          required
        />
        <button type="submit">{selectedId ? 'Ažuriraj Zadatak' : 'Dodaj Zadatak'}</button>
      </form>

      <table>
        <thead>
          <tr>
            <th>ID Zadatka</th>
            <th>Opis</th>
            <th>Datum Pocetka</th>
            <th>Datum Zavrsetka</th>
            <th>Status</th>
            <th>ID Radnika</th>
            <th>Akcije</th>
          </tr>
        </thead>
        <tbody>
          {zadaci.map((zadatak) => (
            <tr key={zadatak.iD_Zadatka}>
              <td>{zadatak.iD_Zadatka}</td>
              <td>{zadatak.opis}</td>
              <td>{zadatak.datum_pocetka}</td>
              <td>{zadatak.datum_zavrsetka}</td>
              <td>{zadatak.status_Zadatka}</td>
              <td>{zadatak.id_radnika}</td>
              <td>
                <button onClick={() => odaberiZadatak(zadatak)}>Ažuriraj</button>
                <button onClick={() => obrisiZadatak(zadatak.iD_Zadatka)}>Obriši</button>
              </td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}

export default Zadaci;
