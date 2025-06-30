Objetivo

O objetivo desta avaliação é desenvolver uma aplicação web fullstack que permita ao usuário:

- Realizar login e acessar a aplicação com segurança;
- Cadastrar, editar, visualizar e remover receitas e despesas;
- Categorizar os lançamentos financeiros (pessoal, água, luz, alimentação e etc…);
- Visualizar separadamente as receitas e as despesas;
- Consumir endpoints protegidos com JWT;
- Aplicar boas práticas de organização no backend e frontend.

Sugestão de Entidades

Para estruturar a aplicação, sugere-se a criação das seguintes entidades no backend. Os nomes e os atributos devem ser definidos pelos alunos conforme as necessidades da solução proposta:

- **Usuário**
    
    Representa a pessoa autenticada que utilizará a aplicação e terá seus próprios lançamentos financeiros.
    
- **Categoria**
    
    Representa os tipos de lançamentos (ex: alimentação, transporte, salário). Pode ser utilizada tanto para receitas quanto para despesas.
    
- **Lançamento**
    
    Representa um valor registrado na aplicação, podendo ser uma receita ou uma despesa. Deve estar vinculado a um usuário e a uma categoria.
