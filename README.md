# MVCBiblioteca 📖

## Descrição
MVCBiblioteca é uma aplicação web desenvolvida utilizando ASP.NET Core MVC para gerenciar uma biblioteca. O sistema permite o gerenciamento de livros e usuários, incluindo operações de criação, leitura, atualização e exclusão (CRUD).

## Estrutura dos Controladores

### HomeController
Este controlador gerencia as operações básicas da página inicial e páginas de informações da aplicação.

- **Dependências**: `ILogger<HomeController>`
- **Ações**:
  - `Index`: Retorna a visão da página inicial.
  - `Privacy`: Retorna a visão da página de privacidade.
  - `Error`: Retorna a visão de erro com informações detalhadas do erro.

### LivrosController
Este controlador gerencia todas as operações relacionadas aos livros na biblioteca.

- **Dependências**: `BibliotecaContext`
- **Ações**:
  - `Index`: Retorna a lista de todos os livros.
  - `Details(int? id)`: Retorna os detalhes de um livro específico.
  - `Create` (GET e POST): Exibe o formulário para criar um novo livro e processa a criação do livro.
  - `Edit(int? id)` (GET e POST): Exibe o formulário para editar um livro existente e processa a atualização do livro.
  - `Delete(int? id)` (GET e POST): Exibe a confirmação para deletar um livro e processa a exclusão do livro.
  - `LivroExists(int id)`: Verifica se um livro existe no banco de dados.

### UsuariosController
Este controlador gerencia todas as operações relacionadas aos usuários da biblioteca.

- **Dependências**: `BibliotecaContext`
- **Ações**:
  - `Index`: Retorna a lista de todos os usuários.
  - `Details(int? id)`: Retorna os detalhes de um usuário específico.
  - `Create` (GET e POST): Exibe o formulário para criar um novo usuário e processa a criação do usuário.
  - `Edit(int? id)` (GET e POST): Exibe o formulário para editar um usuário existente e processa a atualização do usuário.
  - `Delete(int? id)` (GET e POST): Exibe a confirmação para deletar um usuário e processa a exclusão do usuário.
  - `UsuarioExists(int id)`: Verifica se um usuário existe no banco de dados.

## Requisitos
- .NET Core SDK
- ASP.NET Core
- Entity Framework Core

## Configuração e Execução
1. **Clonar o repositório**:
   ```bash
   git clone https://github.com/seu-usuario/mvcbiblioteca.git
   cd mvcbiblioteca 
   ```
2. **Restaurar as dependências**:
    ```bash
    dotnet restore
    ```
3. **Atualizar o banco de dados**:
    ```bash
    dotnet ef database update
    ```
4. **Executar a aplicação**:
    ```bash
    dotnet run
    ```
---
## Estrutura do Projeto

- Controllers: Contém os controladores da aplicação.
- Models: Contém as classes de modelo utilizadas pelo Entity Famework.
- Views: Contém as views para cada ação nos controladores.
- Data: Contém o contexto do banco de dados.

## Licença
Este projeto está licenciado sob os termos da licença MIT. Para mais informações, veja o arquivo [LICENSE](LICENSE).

## Contribuição
Contribuições são bem-vindas! Por favor, envie um pull request ou abra uma issue para discutir melhorias ou correções.

Contato
Para mais informações, entre em contato com j.lucassousafer@gmail.com


