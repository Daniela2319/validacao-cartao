# 💳 Validação de Cartão – Frontend

Frontend da aplicação de validação de cartão de crédito, desenvolvido em **React**, responsável por:

- Enviar o número do cartão para a API
- Exibir se o cartão é válido (Algoritmo de Luhn)
- Mostrar a bandeira identificada
- Exibir ícones das bandeiras
- Manter histórico no LocalStorage

A aplicação é servida em produção via **Nginx** e totalmente containerizada com **Docker**.

---

## 🚀 Tecnologias Utilizadas

- React
- JavaScript
- Bootstrap
- Docker
- Nginx

---

## 📂 Estrutura

```
validacao-frontend/
├── src/
├── public/
├── Dockerfile
└── README.md
```

---

## ⚙️ Pré-requisitos

- Docker

---

## ▶️ Executar com Docker

### 🔹 Build e execução

Na pasta `validacao-frontend`:

```bash
docker build -t validacao-frontend .
docker run -p 3000:80 validacao-frontend
```
## 🌐 Acesso
Abra no navegador:
```bash
http://localhost:3000
```
## 🔗 Comunicação com a API
Em ambiente Docker, o frontend se comunica com o backend através do nome do serviços Docker:
[Repositório do Backend](https://github.com/Daniela2319/validacao-cartao/tree/main)

## 🧪 Exemplo de uso
Digite um número de cartão (com ou sem espaços):
```bash
5513 9459 0874 2906
```
Resultado:
* Cartão válido ou inválido
* Bandeira identificada
* Histórico salvo localmente
