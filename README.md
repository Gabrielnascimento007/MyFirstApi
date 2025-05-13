# MyFirstApi
Este projeto é uma API desenvolvida com ASP.NET Core, com o objetivo de praticar os conceitos iniciais de APIs REST utilizando Swagger, Controllers, herança entre entidades, e organização em camadas como Requests, Responses e Entities.

---

🧠 Conceitos Aplicados
✅ Criação de API com ASP.NET Core

✅ Uso do Swagger para documentação e testes da API

✅ Padrão REST com rotas organizadas em Controllers

✅ Camadas de comunicação separadas por pastas (Requests, Responses)

✅ Uso de herança entre entidades

✅ Separação clara entre lógica de negócio e modelos de dados

---

📁 Estrutura do Projeto
bash
Copiar
Editar
MyFirstApi/
│
├── Communication/
│   └── Requests/
│       ├── RequestChangePasswordJson.cs
│       ├── RequestRegisterUserJson.cs
│       ├── RequestUpdateUserProfileJson.cs
│
├── Controllers/
│   ├── DeviceController.cs
│   ├── MyFirstApiBaseController.cs
│   └── UserController.cs
│
├── Entities/
│   ├── Device.cs              # Classe base
│   ├── Laptop.cs              # Herda de Device
│   └── Smartphone.cs          # Herda de Device
│
├── MyClass.cs
├── Program.cs
├── User.cs
├── appsettings.json
├── MyFirstApi.http
└── README.md

---

📂 Controllers
UserController.cs
Responsável por operações relacionadas ao usuário, como registro, atualização de perfil e troca de senha, recebendo dados via objetos JSON contidos na pasta Requests.

DeviceController.cs
Exemplos de endpoints que lidam com dispositivos (Laptop, Smartphone), demonstrando o uso de herança.

MyFirstApiBaseController.cs
Possivelmente utilizado como base comum para os outros controllers, contendo métodos auxiliares ou funcionalidades compartilhadas.

---

▶️ Como Executar
Clone o repositório:

bash
Copiar
Editar
git clone https://github.com/seu-usuario/MyFirstApi.git
cd MyFirstApi
Abra com o Visual Studio ou use o terminal:

bash
Copiar
Editar
dotnet run
Acesse a URL no navegador conforme indicado no console, geralmente:

bash
Copiar
Editar
https://localhost:5001/swagger

---

✅ Próximos Passos
Adicionar camada de persistência com Entity Framework Core

Implementar autenticação com JWT

Criar testes unitários

Melhorar tratamento de erros e validações
