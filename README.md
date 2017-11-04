# aspnetcore2
Projeto ASP.NET Core 2.0

Requisitos:
1. Baixar o sdk asp.net core 2.0
https://www.microsoft.com/net/download/core

2. Após baixar o projeto do repositório, executar o comando dentro da raiz do projeto
> dotnet restore

> dotnet build



Instruções de uso (Comandos): 

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

Gerar o migrations: Antes  altere as configurações no arquivo appsettings.json
"DefaultConnection": "data source=.\\INSTANCIA-BANCO; user id=USUARIO-BANCO; password=SENHA-BANCO;"
```
No prompt de comando acesse a pasta do seu projeto:
pasta-do-projeto\src\Demo.Data> dotnet ef --startup-project ..\Demo.Api\Demo.Api.csproj --project .\Demo.Data.csproj  migrations add AddCategory
depois execute > dotnet ef --startup-project ..\Demo.Api\Demo.Api.csproj --project .\Demo.Data.csproj database update
```"
