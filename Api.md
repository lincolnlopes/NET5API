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

## OTHERS LINKS

https://lhargil.com/implement-idesigntimedbcontextfactory-with-configurationbuilder/
