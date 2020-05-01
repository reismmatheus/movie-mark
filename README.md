# MovieMark

Projeto voltado para estudo do .NET Core e também do EntityFramwork, pois já tinha alguma familiaridade com o ASP.NET MVC 5. Como eu sempre me perdia em qual episódio estava em determinada série, fiz essa aplicação para acabar com isso.

## Getting Started

- Instalar o SQL Server

## Installing

 Mudar a [ConnectionString](https://github.com/reismmatheus/movie-mark/blob/master/src/MovieMark/appsettings.json) para a conexão do banco de dados com a aplicação;

### Command Line

Restaurar a Aplicação

```
dotnet restore
```

Atualizar as Migrations

```
dotnet ef database update
```

### Visual Studio

Restaurar a Aplicação

- Botão direito na solução, Restaurar pacotes do Nuget

Atualizar as Migrations (Package Manager Console)

```
Update-Database
```

## Run

No Visual Studio, Start na parte superior.

Pelo Cmd.
```
dotnet watch --project src/MovieMark run
```


## Built With

* [.NET Core](https://dotnet.microsoft.com/download) - Framework multiplataforma
* [SQL Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads) - Banco de Dados

## Plugins

* [DataTable](https://dotnet.microsoft.com/download) - Table Plugin
* [JQuery](https://dotnet.microsoft.com/download) - Javascript Library
* [SweetAlert](https://dotnet.microsoft.com/download) - Alert Plugin
* [Bootstrap](https://dotnet.microsoft.com/download) - Framework web

## Authors

* **Matheus Reis** - *Developer* - [GitHub](https://github.com/reismmatheus)

## License

This project is licensed under the MIT License
