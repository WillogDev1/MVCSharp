
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


# Configuração do MySQL com App.config em C#

## 1. Instalar o MySQL Connector

Baixe e instale o **MySQL Connector/NET** diretamente do site oficial:  
🔗 [MySQL Connector/NET](https://dev.mysql.com/downloads/connector/net/)

> Isso garante que a aplicação possa usar o driver oficial da Oracle para MySQL.

## 2. Instalar o pacote NuGet do MySQL

No Visual Studio:

- Vá para o menu **Ferramentas > Gerenciador de Pacotes NuGet > Gerenciar Pacotes NuGet para a Solução**.
- Pesquise por `MySql.Data` e instale o pacote.
  - **Nome do pacote**: `MySql.Data`
  - **Autor**: Oracle

## 3. Criar o arquivo de configuração (App.config)

No Visual Studio:

1. **Adicionar Arquivo de Configuração**:
   - Clique com o botão direito na pasta do seu projeto.
   - Selecione **Adicionar > Novo Item**.
   - Selecione **Arquivo de Configuração de Aplicativo**.
   - Nomeie o arquivo como `App.config`.

## 4. Copiar conteúdo do modelo para o `App.config`

Se você tiver copiado de um arquivo modelo como `App-Copy.config`, agora o conteúdo deve ser copiado para o arquivo `App.config`.

## 5. Configurar o `App.config`

Aqui está o **`App.config` corrigido** com a conexão ao banco de dados de forma segura e a string de conexão com um parâmetro:

```xml
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
	<appSettings>
		<!-- Dados da aplicação -->
		<add key="appName" value="MVCSharp"/>
		<add key="appVersion" value="1.0"/>

		<!-- Dados de conexão ao banco -->
		<add key="DB_HOST" value="localhost"/>
		<add key="DB_NAME" value="mvcsharp"/>
		<add key="DB_USER" value="root"/>
		<add key="DB_PASSWORD" value=""/>
		<add key="DB_PORT" value="3306"/>

		<!-- Layout do Menu -->
		<add key="MenuFooter" value=""/>
	</appSettings>
</configuration>
```

- **`appName`**: nome do seu aplicativo.
- **`MenuFilePath`**: caminho para os arquivos de menu.
- **`MenuFooter`**: o texto do rodapé do menu.
- **`MySqlConnection`**: String de conexão com o banco de dados MySQL.

## 6. Utilizando as configurações no código

### Obter o valor de `appSettings`:

```csharp
string nomeApp = ConfigurationManager.AppSettings["appName"];
```

### Obter a string de conexão:

```csharp
string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
MySqlConnection conn = new MySqlConnection(connectionString);
```

## Conclusão

Agora, você pode acessar o banco de dados e carregar configurações diretamente do `App.config`, mantendo as credenciais e outros parâmetros facilmente ajustáveis sem alterar o código-fonte.
