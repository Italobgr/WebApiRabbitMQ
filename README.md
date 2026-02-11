# 🚀 WebApiRabbitMQ

![.NET](https://img.shields.io/badge/.NET%20Core-5.0+-512BD4?style=for-the-badge&logo=dotnet)
![RabbitMQ](https://img.shields.io/badge/RabbitMQ-FF6600?style=for-the-badge&logo=rabbitmq&logoColor=white)
![License](https://img.shields.io/badge/License-MIT-green?style=for-the-badge)

## 📝 Introdução
Bem-vindo à documentação da **WebApiRabbitMQ**. Este repositório contém uma API RESTful desenvolvida em .NET Core projetada para demonstrar a integração com o **RabbitMQ**, permitindo a publicação e o consumo de mensagens de forma assíncrona e escalável.

## ⚙️ Pré-requisitos
Antes de começar, você precisará ter instalado em sua máquina:
* **[.NET SDK](https://dotnet.microsoft.com/download)** (versão 5.0 ou superior)
* **[RabbitMQ Server](https://www.rabbitmq.com/download.html)** rodando localmente ou via Docker

## 🛠️ Instalação e Execução

1.  **Clone o repositório:**
    ```bash
    git clone [https://github.com/Italobgr/WebApiRabbitMQ.git](https://github.com/Italobgr/WebApiRabbitMQ.git)
    cd WebApiRabbitMQ
    ```

2.  **Restaure as dependências do projeto:**
    ```bash
    dotnet restore
    ```

3.  **Execute a aplicação:**
    ```bash
    dotnet run
    ```

---

## 📡 Endpoints da API

Abaixo estão os endpoints disponíveis para interagir com o broker de mensagens:

| Método | Endpoint | Descrição |
| :--- | :--- | :--- |
| `POST` | `/api/messages` | Publica uma mensagem no RabbitMQ. |
| `GET` | `/api/messages` | Recupera mensagens pendentes na fila. |

### Exemplo de Publicação (cURL)
```bash
curl -X POST http://localhost:5000/api/messages \
     -H "Content-Type: application/json" \
     -d '{ "message": "Olá, RabbitMQ!" }
 ```

## ⚙️ Configuração

As credenciais e o host do RabbitMQ podem ser editados no arquivo `appsettings.json`:

```json
{
  "RabbitMQ": {
    "Host": "localhost",
    "Username": "guest",
    "Password": "guest"
  }
}
