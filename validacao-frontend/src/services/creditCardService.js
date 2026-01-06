export async function validateCreditCard(cardNumber) {
  const response = await fetch(
    "http://localhost:8001/api/creditcard/validate",
    {
      method: "POST",
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify({ cardNumber }),
    }
  );
  const data = await response.json();
  return data;
}
