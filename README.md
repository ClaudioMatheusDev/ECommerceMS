# E-commerce Microservices com ASP.NET

Este repositório contém um projeto de E-commerce desenvolvido em **ASP.NET Core**, utilizando uma arquitetura baseada em **microservices**. O projeto implementa autenticação segura com **IdentityServer** e **JWT**, e segue boas práticas como **DTOs**, **migrations**, e comunicação entre serviços.

## Tecnologias Utilizadas
- **ASP.NET Core**  
- **Entity Framework Core** (com Migrations)  
- **IdentityServer4** (para autenticação e autorização)  
- **JWT (JSON Web Token)** (para autenticação segura)  
- **DTO (Data Transfer Object)** (para transferência de dados)  
- **Docker** (para conteinerização)  
- **RabbitMQ** (para comunicação entre microservices)  
- **Swagger** (para documentação da API)  

## Estrutura do Projeto
O sistema é composto por vários microservices, cada um responsável por uma funcionalidade específica:

- **IdentityServer**: Responsável pela autenticação e gestão de usuários com **IdentityServer** e **JWT**.
- **ProdutoApi**: Gerencia produtos, categorias e preços.
- **CartApi**: Gerencia carrinho de compras.
- **DescontoApi**: Gerencia códigos promocionais e descontos.

