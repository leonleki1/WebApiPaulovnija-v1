import React, { useState, useContext } from 'react';
import { useNavigate } from 'react-router-dom'; // Dodajte ovo
import { AuthContext } from './AuthContext'; // Dodaj AuthContext

const LoginForm = () => {
  const [username, setUsername] = useState('');
  const [password, setPassword] = useState('');
  const [error, setError] = useState('');
  
  const { login } = useContext(AuthContext); 
  const navigate = useNavigate(); 

  const handleSubmit = async (e) => {
    e.preventDefault();

    const loginData = { korisnickoIme: username, lozinka: password };

    try {
      const response = await fetch('https://paulovnija.site/api/Autorizacija/login', {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json',
        },
        body: JSON.stringify(loginData),
      });

      if (!response.ok) {
        throw new Error('Login failed!');
      }

      const data = await response.json();
      login(data.token); 

     
      navigate('/'); 
    } catch (error) {
      setError(error.message);
    }
  };

  return (
    <form onSubmit={handleSubmit}>
      <h2></h2>
      <div>
        <label>Korisničko ime</label>
        <input type="text" value={username} onChange={(e) => setUsername(e.target.value)} required />
      </div>
      <div>
        <label>Lozinka</label>
        <input type="password" value={password} onChange={(e) => setPassword(e.target.value)} required />
      </div>
      {error && <p style={{ color: 'red' }}>{error}</p>}
      <button type="submit">Prijava</button>
    </form>
  );
};

export default LoginForm;
