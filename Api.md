##https://docs.microsoft.com/pt-br/dotnet/core/additional-tools/self-signed-certificates-guide
dotnet dev-certs https -ep $env:USERPROFILE\.aspnet\https\aspnetapp.pfx -p crypticpassword
dotnet dev-certs https --clean
dotnet dev-certs https --trust