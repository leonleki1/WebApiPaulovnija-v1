
import React, { useContext } from 'react';
import { Link, Outlet } from 'react-router-dom';
import { AuthContext } from './AuthContext';
import './app.css';

function App() {
    const { user, logout } = useContext(AuthContext); // Koristi AuthContext

    const handleLogout = () => {
        logout();
        
    };

    return (
        <div>
            <nav className="navbar">
                <div className="navbar-brand">
                    <img src="/assets/logo.png" alt="Logo" className="tree-logo" />
                    <h1>Paulovnija</h1>
                </div>
                <ul>
                    <li>
                        <Link to="#">Menu</Link>
                        <div className="dropdown-content">
                            <Link to="/radnici">Radnici</Link>
                            <Link to="/zadaci">Zadaci</Link>
                            <Link to="/rasadnici">Rasadnici</Link>
                            <Link to="/sadnice">Sadnice</Link>
                            <Link to="/strojevi">Strojevi</Link>
                        </div>
                    </li>
                    <li>
                        <Link to="/" className="home-button">Početna</Link>
                    </li>
                    <li>
                        <Link to="/kreator" className="cool-button">Kreator</Link>
                    </li>
                    {user ? (
                        <li>
                            <button className="logout-button" onClick={handleLogout}>Odjava</button>
                        </li>
                    ) : (
                        <li>
                            <Link to="/login" className="login-button">Prijava</Link>
                        </li>
                    )}
                </ul>
            </nav>

            <Outlet />
        </div>
    );
}

export default App;
