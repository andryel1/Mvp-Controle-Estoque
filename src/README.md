# Mvp-Controle-Estoque

# 📦 Controle de Estoque e Emissão de Notas Fiscais

Este projeto tem como objetivo oferecer uma solução simples e eficiente para controle de estoque de produtos e geração de notas fiscais eletrônicas. Ele foi desenvolvido com foco em **boas práticas de desenvolvimento**, como **DDD (Domain-Driven Design)**, **TDD (Test-Driven Development)** e **Clean Architecture**.

## 🚀 Tecnologias Utilizadas

- **C# / .NET Core**
- **Entity Framework Core**
- **SQL Server**
- **ASP.NET Web API**
- **xUnit** (para testes automatizados)
- **Swagger** (documentação da API)
- **AutoMapper**
- **FluentValidation**
- **Docker** (opcional)
- **RabbitMQ / WebSockets** (para futuras integrações de chat e eventos)

## 🎯 Funcionalidades

- Cadastro, edição e exclusão de produtos
- Controle de entrada e saída do estoque
- Visualização em tempo real do nível de estoque
- Geração automática de Nota Fiscal (modelo NFe simplificado)
- Relatórios e histórico de movimentações
- API RESTful com endpoints protegidos
- Integração com WebSockets (chat simples para comunicação entre setores)

## 🧱 Arquitetura

- **Camada de Apresentação** (Controllers / API)
- **Camada de Aplicação** (UseCases / Services)
- **Camada de Domínio** (Entidades / Regras de negócio)
- **Camada de Infraestrutura** (Repositórios / Contexto de Dados)
- **Camada de Testes** (Testes unitários e de integração)

## ✅ Testes

Os testes foram desenvolvidos com **xUnit** e seguem o padrão TDD. Estão localizados na pasta `/tests`, organizados por domínio. Os principais tipos de testes incluem:

- Testes Unitários
- Testes de Integração
- Testes de Validação

Para rodar os testes:

```bash
dotnet test
