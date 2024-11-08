# Random User Generator App

[![NPM](https://img.shields.io/github/license/jehveiga/Blog-api)](https://github.com/jehveiga/UserGeneratorApp/blob/main/LICENSE.txt)

# Sobre o projeto

Desenvolvimento de uma aplicação Web Asp.Net Core (Blazor App - SPA), consumindo uma API Random User Generator que gera usuários aleatórios para cadastro de usuário no sistema, criado um CRUD usando banco de dados PostgreSQL na criação usa os dados gerados pela API persistindo os dados no banco, com páginas relacionadas de listagem, criação, alteração, remoção de dados do usuário. Criado um botão para alterar os dados gerados da API efetuando outra requisição e atualização de dados sem carregamento total da pagina pensando na melhor interação com usuário. Adicionado também a funcionalidade de gerar relatório de listagem de usuários na página index de listagem usando JavaScript.

# Apresentação da Web API - User Generator

## Visualizando as funcionalidades - demonstração das funcionalidades do projeto CRUD
![Apresentacao Projeto Principal](https://github.com/jehveiga/UserGeneratorApp/blob/main/assets/apresentacao-projeto.gif)

## Gerar relatório - demonstração da funcionalidade de gerar relatório
![Apresentacao Projeto Gerar Relatório](https://github.com/jehveiga/UserGeneratorApp/blob/main/assets/gerando-relatorio.gif)

## Script Utilizado SQL - Criado o script se optar criar o banco para por ele

- Alterar a string de conexão no arquivo `appsettings.json`, para as configurações do seu banco.
- Run `ScriptSql/createDbScript.sql` para criação do banco de dados.

## Utilizando Entity Framework Tools

- Alterar a string de conexão no arquivo `appsettings.json`, para as configurações do seu banco.
- Apagar a pasta `Migrations`.
- Run `Add-Migration` e depois `Update-Database` para criação do banco de dados.
- Executar o projeto

## Back end

- C#

## Outras Tecnologias

- Blazor
- Asp.Net Core
- Entity Framework Core
- JavaScript

## Banco de Dados

- PostgreSql

# Autor 

Jefferson Veiga

https://www.linkedin.com/in/jefferson-veiga-dev/
