# Bibliotecário 📚

Este projeto é um **sistema bibliotecário** desenvolvido em **C# WinForms** com **MySQL** como banco de dados. Ele foi criado com o objetivo de fornecer uma aplicação funcional para **estudantes de programação** aprenderem conceitos de desenvolvimento de software, integração com banco de dados, e boas práticas de programação.

---

## 📖 Objetivo

O principal objetivo deste sistema é **promover o aprendizado** ao compartilhar uma aplicação completa que aborda:

- Estruturação em camadas.
- Manipulação de banco de dados com MySQL.
- Desenvolvimento de interfaces gráficas usando WinForms.
- Implementação de funcionalidades práticas para gestão de bibliotecas.

---

## 🛠️ Funcionalidades

- **Gerenciamento de livros**: Cadastro, edição e exclusão.
- **Cadastro de usuários**: Registro e edição de leitores.
- **Controle de empréstimos**: Registro, devolução e cálculo de atrasos.
- **Relatórios básicos**: Listagem de livros, usuários e atividades realizadas.

---

## 📂 Estrutura do Código

O sistema foi desenvolvido seguindo o padrão de arquitetura em camadas, com a seguinte organização:

- **Bibliotecario**: Interface gráfica do usuário (UI), construída com WinForms.  
  - Localização: `Bibliotecario/Bibliotecario/`
  - Exemplo: `FormAdicionarAcervo.cs`, `FormLogin.cs`.

- **CamadaNegocio**: Contém a lógica de negócios, incluindo validações e regras específicas da aplicação.  
  - Localização: `Bibliotecario/CamadaNegocio/`
  - Exemplo: `AcervoCamadaNegocio.cs`, `UtilizadorCamadaNegocio.cs`.

- **CamadaEntidade**: Classes que representam as entidades do sistema, como Acervo e Utilizador, mapeando os dados do banco.  
  - Localização: `Bibliotecario/CamadaEntidade/`
  - Exemplo: `Acervo.cs`, `Utilizador.cs`.

- **CamadaDados**: Responsável pela comunicação direta com o banco de dados, incluindo operações de CRUD.  
  - Localização: `Bibliotecario/CamadaDados/`
  - Exemplo: `AcervoCamadaDados.cs`, `UtilizadorDados.cs`.

---

## 🚀 Como Usar

1. **Clone o repositório:**
   ```bash
   git clone https://github.com/SimaoBrandao/sistema-bibliotecario.git
   ```

2. **Abra o projeto:**
   - Use o Visual Studio para abrir o arquivo `.sln`.

3. **Compile e execute:**
   - Compile o projeto no Visual Studio e execute diretamente.

---

## 🧑‍💻 Tecnologias Utilizadas

- **Linguagem:** C# (Windows Forms)
- **Banco de Dados:** MySQL
- **Framework:** .NET Framework 4.8
- **IDE:** Visual Studio

---

## 🎓 Licença

Este projeto está licenciado sob a **Creative Commons Attribution-NonCommercial 4.0 International (CC BY-NC 4.0)**.  
Você pode usar, modificar e compartilhar este código, desde que seja para fins **educacionais e não comerciais**.  

Para mais informações, veja o arquivo [LICENSE](LICENSE).

---

## 🤝 Contribuições

Contribuições são bem-vindas! Caso encontre problemas ou tenha sugestões, sinta-se à vontade para abrir uma **issue** ou enviar um **pull request**.

---

## 📩 Contato

Caso tenha dúvidas ou queira compartilhar seu feedback, entre em contato:  
📧 **sibrandao2008@gmail.com**
