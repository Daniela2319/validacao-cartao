import { useState, useEffect } from "react";
import { validateCreditCard } from "./services/creditCardService";
import {
  getHistory,
  saveToHistory,
  clearHistory,
} from "./services/storageService";
import CardBrandIcon from "./components/CardBrandIcon";

function App() {
  const [cardNumber, setCardNumber] = useState("");
  const [result, setResult] = useState(null);
  const [history, setHistory] = useState([]);

  useEffect(() => {
    setHistory(getHistory());
  }, []);

  async function handleValidate() {
    if (!cardNumber) return;

    const response = await validateCreditCard(cardNumber);
    setResult(response);

    saveToHistory(response);
    setHistory(getHistory());
  }

  return (
  <div className="container d-flex justify-content-center mt-5">
    <div className="col-md-6">

      <div className="card shadow-sm">
        <div className="card-body">

          <h3 className="text-center mb-4">Validação de Cartão</h3>

          <input
            className="form-control form-control-lg text-center"
            placeholder="Digite o número do cartão"
            value={cardNumber}
            onChange={(e) => setCardNumber(e.target.value)}
          />

          <button
            className="btn btn-primary btn-lg w-100 mt-3"
            onClick={handleValidate}
          >
            Validar
          </button>

          {result && (
            <div className="card mt-4 border-0 bg-light">
              <div className="card-body text-center">

                <h5 className="mb-3">Resultado</h5>

                <p className="mb-1">
                  <strong>Válido:</strong>{" "}
                  <span
                    className={
                      result.isValid ? "text-success" : "text-danger"
                    }
                  >
                    {result.isValid ? "Sim" : "Não"}
                  </span>
                </p>

                <p className="mb-3">
                  <strong>Bandeira:</strong> {result.brand}
                </p>

                <CardBrandIcon brand={result.brand} size={60} />
              </div>
            </div>
          )}

        </div>
      </div>

      {/* HISTÓRICO */}
      <div className="card mt-4 shadow-sm">
        <div className="card-body">

          <div className="d-flex justify-content-between align-items-center mb-3">
            <h5 className="mb-0">Histórico</h5>
            <button
              className="btn btn-sm btn-outline-danger"
              onClick={() => {
                clearHistory();
                setHistory([]);
              }}
            >
              Limpar
            </button>
          </div>

          {history.length === 0 ? (
            <p className="text-muted text-center">
              Nenhuma validação realizada
            </p>
          ) : (
            <ul className="list-group list-group-flush">
              {history.map((item, index) => (
                <li
                  key={index}
                  className="list-group-item d-flex justify-content-between align-items-center"
                >
                  <div>
                    <strong>{item.cardNumber}</strong>
                    <br />
                    <small className="text-muted">{item.date}</small>
                  </div>
                  <span className="badge bg-secondary">
                    {item.brand}
                  </span>
                </li>
              ))}
            </ul>
          )}

        </div>
      </div>

    </div>
  </div>
);

}

export default App;
