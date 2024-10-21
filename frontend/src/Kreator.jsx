import React from 'react';
import './Kreator.css'; 
import myPicture from './slike/Leon.jpg'; // Ispravan import slike

const Kreator = () => {
    return (
        <div className="kreator-container">
            <h1>Kreator</h1>
            <div className="kreator-info">
                {}
                <img src={myPicture} alt="Kreator" className="kreator-slika" />
                <h2>Ime: Leon</h2>
                <p>Opis: Ja sam kreator ove stranice, hvala na posjeti!</p>
            </div>
        </div>
    );
};

export default Kreator;
