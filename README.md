
# MVCSharp - Menu Interativo com MVC no Terminal

Este projeto é um exemplo didático de como aplicar o padrão arquitetural **MVC (Model-View-Controller)** em uma aplicação **console (terminal)** utilizando **C#**.

> **Objetivo:** Aprender e demonstrar como organizar uma aplicação em camadas separadas de responsabilidade (MVC), mesmo em um ambiente simples como o terminal, sem interfaces gráficas.

---

## 📐 Arquitetura MVC no Terminal

Este projeto segue o padrão **MVC** com foco no terminal de comando:

- **Model:** (em construção ou implementável) — responsável por lidar com os dados e lógica de negócio.
- **View:** Arquivos `.txt` localizados em `App/View`, que contêm as opções de menu.
- **Controller:** Define as ações a serem tomadas com base na escolha do usuário.
- **Handler:** Responsável por exibir o menu, capturar a entrada do usuário e formatar a interface no terminal.

---

## 📁 Estrutura do Projeto

```plaintext
MVCSharp/
│
├── App/
│   ├── Controller/
│   │   └── Controller.cs          # Controlador principal do menu
│   ├── View/
│   │   └── MENU.txt               # Arquivo com as opções do menu
│
├── Handler/
│   └── Index.cs                   # Classe que gerencia o layout e interação do menu
│
└── Program/
    └── Program.cs                 # Ponto de entrada da aplicação
```

---

## ▶️ Como funciona?

1. O programa inicia e carrega um menu definido em um arquivo `.txt`.
2. O usuário navega pelas opções com as **setas** e confirma com **Enter**.
3. O menu retorna o número da opção escolhida.
4. O `Controller` processa a escolha do usuário.

---

## ✅ Recursos Implementados

- [x] Leitura dinâmica de arquivos `.txt` como menu
- [x] Interface interativa com `Console.SetCursorPosition`
- [x] Navegação com `seta para cima/baixo` e `enter`
- [x] Separação de responsabilidades (Handler vs Controller)
- [x] Estrutura em **MVC**

---

## 🚀 Objetivos de Aprendizado

Este projeto foi criado com o intuito de:

- Compreender a aplicação prática do padrão **MVC**.
- Desenvolver uma aplicação limpa e modular mesmo no **terminal**.
- Praticar conceitos como:
  - Leitura e escrita com arquivos
  - Manipulação de entrada do usuário
  - Separação de camadas
  - Lógica de navegação via teclado

---

## 🧠 Proximas Features

- [ ] Criar uma camada `Model` para persistência ou simulação de dados
- [ ] Criar Controle de Acesso
- [ ] Criar Permissionamento

---

## 👨‍💻 Autor

William O. Gibram

---

## 🤝 Contribuições
Este projeto está livre para participações!
Sinta-se à vontade para sugerir melhorias, corrigir bugs ou adicionar novas funcionalidades. Toda contribuição é bem-vinda.
