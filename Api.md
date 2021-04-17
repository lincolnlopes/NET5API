#Revisando Conteúdo com Foco na Arquitetura - Estudos C#
#.NETCore 3.1/.NET5.0 - C# API com Arquitetura DDD na PRÁTICA

##https://docs.microsoft.com/pt-br/dotnet/core/additional-tools/self-signed-certificates-guide
dotnet dev-certs https -ep $env:USERPROFILE\.aspnet\https\aspnetapp.pfx -p crypticpassword
dotnet dev-certs https --clean
dotnet dev-certs https --trust

dotnet tool install --global dotnet-ef
