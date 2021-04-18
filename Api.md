## Revisando Conteúdo com Foco na Arquitetura - Estudos C#

## .NETCore 3.1/.NET5.0 - C# API com Arquitetura DDD na PRÁTICA

## https://docs.microsoft.com/pt-br/dotnet/core/additional-tools/self-signed-certificates-guide

dotnet dev-certs https -ep $env:USERPROFILE\.aspnet\https\aspnetapp.pfx -p crypticpassword
dotnet dev-certs https --clean
dotnet dev-certs https --trust

dotnet tool install --global dotnet-ef

## Adicionar referência

dotnet add .\Api.Data\ reference .\Api.Domain\

## Instalação MySQL via Docker

docker run --name container-dev-mysql -p 3306:3306 -e MYSQL_ROOT_PASSWORD=123456 -e MYSQL_ROOT_HOST=% -d mysql/mysql-server:latest

## https://stackoverflow.com/questions/61777554/mysqldbcontextoptionsbuilder-does-not-contain-a-definition-for-serverversion

dotnet ef migrations add InitialMigration
dotnet ef database update

## Instalar e atualizar ASPNET-CodeGenerator

https://docs.microsoft.com/pt-br/aspnet/core/fundamentals/tools/dotnet-aspnet-codegenerator?view=aspnetcore-5.0

Microsoft.VisualStudio.Web.CodeGeneration.Design

dotnet tool install -g dotnet-aspnet-codegenerator
dotnet aspnet-codegenerator controller -name UserController -m UserEntity -dc MyContext --relativeFolderPath Controllers --useDefaultLayout -api

## OTHERS LINKS

https://lhargil.com/implement-idesigntimedbcontextfactory-with-configurationbuilder/

https://stackoverflow.com/questions/40059929/cannot-find-the-usemysql-method-on-dbcontextoptions

https://stackoverflow.com/questions/61777554/mysqldbcontextoptionsbuilder-does-not-contain-a-definition-for-serverversionhttps://github.com/docker-library/mysql/issues/275

https://entityframeworkcore.com/knowledge-base/45892312/how-to-add-an-implementation-of--idesigntimedbcontextfactory-datacontext---to-the-project-in-asp-net-core-2-0

https://stackoverflow.com/questions/36951010/usesqlserver-is-not-defined-in-dbcontextoptionbuilder

https://www.connectionstrings.com/store-and-read-connection-string-in-appsettings-json/

https://stackoverflow.com/questions/29110241/how-do-you-configure-the-dbcontext-when-creating-migrations-in-entity-framework
https://stackoverflow.com/questions/46843367/how-to-setbasepath-in-configurationbuilder-in-core-2-0

https://stackoverflow.com/questions/47060751/could-not-get-the-reflection-type-for-dbcontext

https://docs.microsoft.com/pt-br/ef/core/cli/services

https://stackoverflow.com/questions/40900414/asp-net-core-dependency-injection-error-unable-to-resolve-service-for-type-whil
