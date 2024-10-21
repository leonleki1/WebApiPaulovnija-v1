// main.jsx
import React from 'react';
import ReactDOM from 'react-dom/client';
import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';

import App from './App';
import Home from './Home'; 
import Radnici from './Radnici';
import Zadaci from './Zadaci';
import Rasadnici from './Rasadnik';
import Sadnice from './Sadnice';
import Strojevi from './Strojevi';
import Kreator from './Kreator';
import Login from './Login';
import { AuthProvider } from './AuthContext';
import ProtectedRoute from './ProtectedComponent';

const Main = () => {
    return (
        <Router>
            <AuthProvider>
                <Routes>
                    <Route path="/" element={<App />}>
                        <Route index element={<Home />} />
                        <Route path="radnici" element={
                            <ProtectedRoute>
                                <Radnici />
                            </ProtectedRoute>
                        } />
                        <Route path="zadaci" element={
                            <ProtectedRoute>
                                <Zadaci />
                            </ProtectedRoute>
                        } />
                        <Route path="rasadnici" element={
                            <ProtectedRoute>
                                <Rasadnici />
                            </ProtectedRoute>
                        } />
                        <Route path="sadnice" element={
                            <ProtectedRoute>
                                <Sadnice />
                            </ProtectedRoute>
                        } />
                        <Route path="strojevi" element={
                            <ProtectedRoute>
                                <Strojevi />
                            </ProtectedRoute>
                        } />
                        <Route path="kreator" element={
                            <ProtectedRoute>
                                <Kreator />
                            </ProtectedRoute>
                        } />
                        <Route path="login" element={<Login />} />
                    </Route>
                </Routes>
            </AuthProvider>
        </Router>
    );
};

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(<Main />);
