const KEY = "creditCardHistory";

export function getHistory() {
  return JSON.parse(localStorage.getItem(KEY)) || [];
}

export function saveToHistory(item) {
  const history = getHistory();
  history.unshift({
    ...item,
    date: new Date().toLocaleString(),
  });
  localStorage.setItem(KEY, JSON.stringify(history));
}

export function clearHistory() {
  localStorage.removeItem(KEY);
}
