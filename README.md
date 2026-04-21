#  MendesBooking API

API REST desenvolvida em **.NET** com foco em **boas práticas de arquitetura backend**, organização de código e escalabilidade.

O projeto simula um sistema de reservas de hotéis, permitindo o gerenciamento de hotéis e seus respectivos quartos, aplicando conceitos utilizados em aplicações reais.

---

##  Sobre o projeto

O **MendesBooking** foi criado com o objetivo de consolidar conhecimentos essenciais no desenvolvimento backend, como:

* Arquitetura em camadas
* Separação de responsabilidades
* Uso de padrões de projeto
* Organização de código escalável

Com o foco de fazer um CRUD , este projeto foca em **estrutura e boas práticas**, aproximando-se de um cenário real de mercado.

---

##  Arquitetura do sistema

O projeto segue uma estrutura inspirada em **Clean Architecture**, dividida em camadas bem definidas:

###  Domain

* Entidades principais (`Hotel`, `Room`)
* Interfaces de repositório (`IHotelsRepository`)
* Camada mais importante do sistema (regra de negócio)

###  Infrastructure

* Implementação dos repositórios
* Integração com banco de dados
* Uso do Entity Framework Core

###  Application

* DTOs (entrada e saída de dados)
* Configuração do AutoMapper
* Regras de aplicação

###  API

* Controllers (ponto de entrada HTTP)
* Middlewares 
* Configuração de serviços (DI)
* Rotas e endpoints

---

## Conceitos e práticas aplicadas

Este projeto demonstra domínio em:

*  Repository Pattern
*  Injeção de Dependência (Dependency Injection)
*  DTOs para desacoplamento
*  AutoMapper para mapeamento de objetos
*  LINQ para consultas
*  Separação de responsabilidades (SRP)
*  Organização em camadas (Clean Architecture)

---

##  Tecnologias utilizadas

* .NET Web API
* Entity Framework Core
* SQL Server
* AutoMapper
* LINQ

---

##  Funcionalidades

*  Cadastro, edição, listagem e remoção de hotéis
*  Gerenciamento de quartos por hotel
*  Relacionamento entre entidades (Hotel → Rooms)
*  Uso de DTOs para entrada e saída de dados
*  Queries otimizadas com LINQ

---

##  Endpoints principais

###  Hotéis

* `GET /api/hotels`
* `GET /api/hotels/{id}`
* `POST /api/hotels`
* `PUT /api/hotels/{id}`
* `DELETE /api/hotels/{id}`

---

###  Quartos

* `GET /api/hotels/{hotelId}/rooms`
* `POST /api/hotels/{hotelId}/rooms`
* `DELETE /api/rooms/{id}`

---

##  Banco de dados

O projeto utiliza **Entity Framework Core com migrations**:

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

---

##  Evolução do projeto

Durante o desenvolvimento, foram aplicadas melhorias importantes:

* Substituição de acesso direto ao `DbContext` por repositórios
* Introdução de DTOs para evitar acoplamento
* Uso de AutoMapper para reduzir código repetitivo
* Organização em camadas para melhor manutenção

---

##  Próximos passos

Evoluções planejadas:

*  Autenticação e autorização com JWT
*  Paginação e filtros nas consultas
*  Logging e monitoramento
*  Testes automatizados
*  Deploy em nuvem

---

## Autor

Projeto desenvolvido como parte dos estudos em backend e arquitetura de software.
