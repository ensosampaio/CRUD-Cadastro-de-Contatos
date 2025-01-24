# CRUD Cadastro de Contatos

Este projeto é uma aplicação web para gerenciar um cadastro de contatos, permitindo operações de **Criar**, **Ler**, **Atualizar** e **Excluir** (CRUD). Foi desenvolvida utilizando **ASP.NET Core MVC** com **C#** no backend e **HTML**, **CSS** e **JavaScript** no frontend.

## 🛠️ Tecnologias Utilizadas

- **ASP.NET Core MVC**: Framework para construção de aplicações web robustas e escaláveis.
- **Entity Framework Core**: ORM para interagir com o banco de dados de forma simplificada.
- **SQL Server**: Banco de dados relacional utilizado para armazenar as informações dos contatos.
- **HTML5** e **CSS3**: Para estruturação e estilização das páginas.
- **JavaScript**: Para interatividade e manipulação do DOM.

## ⚙️ Funcionalidades

- **Adicionar Contato**: Permite adicionar um novo contato com nome, e-mail e telefone.
- **Listar Contatos**: Exibe uma lista de todos os contatos cadastrados.
- **Editar Contato**: Possibilita a edição das informações de um contato existente.
- **Excluir Contato**: Remove um contato do cadastro.

## 🚀 Como Executar o Projeto
- **Pré-requisitos**
- .NET 6.0 SDK: Certifique-se de que o SDK do .NET 6.0 está instalado em sua máquina.
- SQL Server: Necessário para o banco de dados.
- **Passos para Execução**
- 1° Clonar o repositório (comandos passados dentro bash)
- **git clone https://github.com/ensosampaio/CRUD-Cadastro-de-Contatos.git** **cd CRUD-Cadastro-de-Contatos**
- **2° Configure o Banco de Dados:**
- Abra o arquivo appsettings.json e atualize a string de conexão com as informações da sua instância do SQL Server.
- Crie as migrações usando o comando **dotnet ef migrations add InitialCreate**
- Aplique as migrações, criando o banco de dados com o comando **dotnet ef database update**
