

# 💳 Validação de Cartão – Backend API

API REST desenvolvida em **ASP.NET Core**, responsável por:

- Validar números de cartão usando o Algoritmo de Luhn
- Identificar a bandeira do cartão (Visa, MasterCard, Amex, etc.)
- Retornar dados estruturados em JSON
- Ser consumida por aplicações frontend

A API é containerizada com **Docker** e expõe documentação via **Swagger**.

---

## 🚀 Tecnologias Utilizadas

- ASP.NET Core Web API
- C#
- Swagger
- Docker

---

## 📂 Estrutura

```bash
validacao/
├── Controllers/
├── Services/
├── Models/
├── Dockerfile
└── README.md
```

---

## ⚙️ Pré-requisitos

- Docker

---

## ▶️ Executar com Docker

### 🔹 Build e execução

Na pasta `validacao`:

```bash
docker build -t validacao-api .
docker run -p 8081:8080 validacao-api
```
## 🌐 Endpoints
* Swagger
```bash
http://localhost:8081/swagger
```
## Validar Cartão
POST `/api/creditcard/validate`
Request 
```bash
{
  "cardNumber": "5513945908742906"
}
```
Response
```bash
{
  "isValid": true,
  "brand": "MasterCard"
}

```
## 🧠 Regras de Negócio
* Remove espaços automaticamente

* Valida se contém apenas números

* Aplica Algoritmo de Luhn

* Identifica bandeira por prefixo

 ## 🐳 Docker

A aplicação roda internamente na porta 8080.
A porta externa pode ser alterada via Docker.

```bash
-p 8081:8080
```
## Contribuição
- [![GitHub](https://img.shields.io/badge/GitHub-DanielaVelter-black?logo=github)](https://github.com/Daniela2319)
- [![GitHub](https://img.shields.io/badge/GitHub-Guilhermed'Almeida-black?logo=github)](https://github.com/gbad8)
