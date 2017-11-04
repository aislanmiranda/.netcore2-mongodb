
# AspNetCore2MongoDb
Projeto com estrutura AspNet Core 2 com MongoDb
```
O exemplo mostra um crud utilizando webapi - Métodos para teste na ProductController.
```

Requisitos:
1. Baixar o sdk asp.net core 2.0
https://www.microsoft.com/net/download/core

2. Após baixar o projeto do repositório, executar o comando dentro da raiz do projeto
> dotnet restore

> dotnet build

> dotnet run

#Instruções de uso (Comandos): 
Criar class library
```
dotnet new classlib --name <nome-library> 
Ex: dotnet new classlib --name Demo.Domain
```

Criar solution
```
dotnet new sln --name <nome_solution>
Ex: dotnet new sln --name DemoProject
```

Adicionar referenciar projeto na solution
```
dotnet sln add <caminho-projeto>
Ex: dotnet sln add src\Demo.Domain\Demo.Domain.csproj
```
