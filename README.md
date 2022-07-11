# 🔗 MinimalApi

Projeto desenvolvido com .NET Core 6.0 e C# resolvendo um desafio onde um cliente envia 
um numero e esse numero e decomposto, retornando uma lista com todos os seus divisores
e enumerando os divisores em outra lista que são primos.

Foi implementado uma WebApi documentada com o swagger e testes unitarios com Xunit

<p align="center">
  <img alt="GitHub language count" src="https://img.shields.io/github/languages/count/HendricksSumeck/MinimalApi?color=%2304D361">

  <img alt="Repository size" src="https://img.shields.io/github/repo-size/HendricksSumeck/MinimalApi">

  <a href="https://github.com/HendricksSumeck/MinimalApi">
    <img alt="GitHub last commit" src="https://img.shields.io/github/last-commit/HendricksSumeck/MinimalApi">
  </a>

  <a href="https://github.com/HendricksSumeck/MinimalApi/stargazers">
    <img alt="Stargazers" src="https://img.shields.io/github/stars/HendricksSumeck/MinimalApi?style=social">
  </a>
</p>

## 🛠 Tecnologias

As seguintes ferramentas foram usadas na construção do projeto:

- ![NET Badge](https://img.shields.io/badge/.NET-5C2D91?style=flat-square&logo=.net&logoColor=white)
- ![C# Badge](https://img.shields.io/badge/C%23-239120?style=flat-square&logo=c-sharp&logoColor=white)
- ![PostgreSQL Badge](https://img.shields.io/badge/PostgreSQL-316192?style=flat-square&logo=postgresql&logoColor=white)
- ![Docker Badge](https://img.shields.io/badge/Docker-2496ED?style=flat-square&logo=docker&logoColor=white)
- ![windows Badge](https://img.shields.io/badge/Windows-017AD7?style=flat-square&logo=windows&logoColor=white)
- ![Git Badge](https://img.shields.io/badge/Git-E34F26?style=flat-square&logo=git&logoColor=white)

![NET Badge](https://img.shields.io/badge/.NET-5C2D91?style=flat-square&logo=.net&logoColor=white)
![C# Badge](https://img.shields.io/badge/C%23-239120?style=flat-square&logo=c-sharp&logoColor=white)
![PostgreSQL Badge](https://img.shields.io/badge/PostgreSQL-316192?style=flat-square&logo=postgresql&logoColor=white)
![Docker Badge](https://img.shields.io/badge/Docker-2496ED?style=flat-square&logo=docker&logoColor=white)
![windows Badge](https://img.shields.io/badge/Windows-017AD7?style=flat-square&logo=windows&logoColor=white)
![Git Badge](https://img.shields.io/badge/Git-E34F26?style=flat-square&logo=git&logoColor=white)

## Rodando localmente

### Pré-requisitos

Antes de começar, você vai precisar ter instalado em sua máquina as seguintes ferramentas:
[Git](https://git-scm.com), [.NET 6.0](https://dotnet.microsoft.com/en-us/download) e [Docker](https://docs.docker.com/desktop/windows/install/).

Além disto é bom ter uma IDE para trabalhar com o código como [Visual Studio](https://visualstudio.microsoft.com/pt-br/downloads/) 
é uma ferramenta de administração de banco de dados como [DBeaver](https://dbeaver.io/download/).

### 🎲 Rodando o Back End (servidor)

```bash
# Clone este repositório
$ git clone git@github.com:HendricksSumeck/MinimalApi.git

# Acesse a pasta do projeto no terminal/cmd
$ cd MinimalApi

# Vá para a pasta MinimalApi
$ cd MinimalApi

# Execute a aplicação
$ dotnet run

# O servidor inciará na porta:5000 - acesse https://localhost:5000/swagger/index.html
```

### <img src="https://img.icons8.com/color/26/000000/docker.png"/> Inicializando Docker do projeto

```bash
# Clone este repositório
$ git clone git@github.com:HendricksSumeck/MinimalApi.git

# Acesse a pasta do projeto no terminal/cmd
$ cd MinimalApi

# Execute o comando
$ docker-compose -p pgslq -d
```

### <img src="https://img.icons8.com/fluency/26/000000/database.png"/> Rodando as migrações do projeto

```bash
# Clone este repositório
$ git clone git@github.com:HendricksSumeck/MinimalApi.git

# Acesse a pasta do projeto no terminal/cmd
$ cd MinimalApi

# Vá para a pasta MinimalApi
$ cd MinimalApi

# Criar as migrações do banco de dados
$ dotnet ef --startup-project MinimalApi/ migrations add Inicial --context AppDataContext

# Executar para criar o banco
$ dotnet ef database update --startup-project MinimalApi/ --context AppDataContext
```

## 🚀 Autor

<img style="border-radius: 50%;" src="https://avatars.githubusercontent.com/u/33631655?v=4" width="100px;" alt=""/>

<sub><b>Hendrick</b></sub></a> 🚀

[![GitHub Badge](https://img.shields.io/badge/Hendrick-100000?style=flat-square&logo=github&logoColor=white)](https://github.com/HendricksSumeck)
[![Linkedin Badge](https://img.shields.io/badge/-Hendrick-blue?style=flat-square&logo=Linkedin&logoColor=white&link=https://www.linkedin.com/in/hendrick-sumeck-45a41918a/)](https://www.linkedin.com/in/hendrick-sumeck-45a41918a/) 
[![Gmail Badge](https://img.shields.io/badge/-hsumeck@gmail.com-c14438?style=flat-square&logo=Gmail&logoColor=white&link=hsumeck@gmail.com)](mailto:hsumeck@gmail.com)
