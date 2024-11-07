# Extensão para Manipulação de Valores Monetários

Este projeto foi desenvolvido como parte do curso de **DevOps** na plataforma [Balta.io](https://balta.io). Ele fornece uma extensão para manipulação de valores monetários em .NET, com foco em integração contínua (CI), entrega contínua (CD) e publicação em um pacote NuGet.

## 📋 Descrição do Projeto

A extensão é projetada para facilitar operações com valores monetários, permitindo cálculos precisos e manipulando diferentes formatos de moedas. O objetivo é simplificar o trabalho com operações financeiras em projetos .NET.

Este projeto inclui configurações de CI/CD para automação de builds, testes e publicação do pacote no NuGet, permitindo uma distribuição rápida e fácil da extensão.

## 🚀 Tecnologias Utilizadas

- **.NET 6** ou superior
- **Azure DevOps** / **GitHub Actions** (para CI/CD)
- **NuGet** (para publicação do pacote)

## 📦 Recursos

- Manipulação simplificada de valores monetários
- Compatibilidade com diversos formatos de moeda
- Reduz erros em operações financeiras
- Pronto para publicação como pacote NuGet

## 📑 Estrutura do Projeto

```plaintext
.
├── src
│   └── MonetaryExtensions.csproj      # Projeto principal da extensão
│   └── MonetaryExtensions.cs          # Classe de extensão para manipulação de valores monetários
├── tests
│   └── MonetaryExtensions.Tests.csproj # Projeto de testes unitários
├── .github/workflows
│   └── ci-cd.yml                      # Workflow para CI/CD
└── README.md
```

## ⚙️ Configuração de CI/CD
O projeto utiliza pipelines para realizar build, testes e publicação do pacote no NuGet. Basta configurar os seguintes segredos para automação completa:

NUGET_API_KEY – Chave de API para publicação no NuGet
GITHUB_TOKEN – Token para autenticação no GitHub Actions
Para configurações adicionais, veja o arquivo .github/workflows/ci-cd.yml.

## 📥 Instalação
Para instalar o pacote em seu projeto .NET, utilize o comando abaixo:


``` bash
dotnet add package MonetaryExtensions
```
Ou adicione o seguinte ao seu arquivo .csproj:

````xml
<PackageReference Include="MonetaryExtensions" Version="1.0.0" />
````
## 🧪 Testes
Para rodar os testes do projeto, execute:

````bash
dotnet test
````
## 🌐 Publicação
A publicação no NuGet é realizada automaticamente pelo pipeline CI/CD após cada merge na branch main, utilizando o workflow configurado para publicar o pacote.

## ✨ Contribuições
Contribuições são bem-vindas! Sinta-se à vontade para abrir issues e pull requests para melhorias e correções.

## 📄 Licença
Este projeto está licenciado sob a Licença MIT.
