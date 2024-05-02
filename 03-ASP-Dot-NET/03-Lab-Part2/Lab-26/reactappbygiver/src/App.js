import React, { useState } from 'react';
import './App.css';
import Home from './home';
import Calculator from './calculator';

function App() {
  const [activePage, setActivePage] = useState('home');

  const handlePageChange = (page) => {
    setActivePage(page);
  };

  return (
    <div className="App">
      <nav className="navbar">
        <a onClick={() => handlePageChange('home')} className="nav-link" style={{marginRight: "1rem"}}>
          Home
        </a>
        <a onClick={() => handlePageChange('calculator')} className="nav-link">
          Calculator
        </a>
      </nav>
      {activePage === 'home' && <Home />}
      {activePage === 'calculator' && <Calculator />}
      <footer className="footer">© Giver Khadka, 2024</footer>
    </div>
  );
}

export default App;
