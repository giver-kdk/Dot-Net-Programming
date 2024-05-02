import React, { useState } from 'react';

function Calculator() {
  const [num1, setNum1] = useState(0);
  const [num2, setNum2] = useState(0);
  const [operation, setOperation] = useState('add');
  const [result, setResult] = useState(0);

  const handleNumChange = (event) => {
    const value = parseFloat(event.target.value);
    if (event.target.id === 'num1') {
      setNum1(value);
    } else {
      setNum2(value);
    }
  };

  const handleOperationChange = (event) => {
    setOperation(event.target.value);
  };

  const calculate = () => {
    let calculatedResult;
    switch (operation) {
      case 'add':
        calculatedResult = num1 + num2;
        break;
      case 'subtract':
        calculatedResult = num1 - num2;
        break;
      case 'multiply':
        calculatedResult = num1 * num2;
        break;
      default:
        calculatedResult = 0;
    }
    setResult(calculatedResult);
  };

  return (
    <div className="calculator">
      <h2>Calculator</h2>
      <form>
        <div className="form-group">
          <label htmlFor="num1">Number 1:</label>
          <input
            type="number"
            id="num1"
            value={num1}
            onChange={handleNumChange}
          />
        </div>
        <div className="form-group">
          <label htmlFor="num2">Number 2:</label>
          <input
            type="number"
            id="num2"
            value={num2}
            onChange={handleNumChange}
          />
        </div>
        <div className="form-group">
          <label htmlFor="operation">Operation:</label>
          <select id="operation" value={operation} onChange={handleOperationChange}>
            <option value="add">Add</option>
            <option value="subtract">Subtract</option>
            <option value="multiply">Multiply</option>
          </select>
        </div>
        <button type="button" onClick={calculate}>
          Compute
        </button>
        <div className="result">
          <label>Result:</label>
          <span>{result}</span>
        </div>
      </form>
    </div>
  );
}

export default Calculator;
