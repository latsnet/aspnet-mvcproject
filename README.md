# Projeto ASP.NET MVC

How to run in Development mode:

    export ASPNETCORE_ENVIRONMENT=Development

Migrations with NET CLI

    dotnet tool install --global dotnet-ef

Create Migration

    dotnet ef migrations add <Migration_Name> [options]

Apply Migration

    dotnet ef database update [options]

Remove Migration

    dotnet ef migrations remove