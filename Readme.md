# Projeto C# com Migrations

Este projeto demonstra o uso de Entity Framework Core para gerenciar Migrations em um projeto C#. Inclui dois contextos: `BloggingContext` e `CategoryContext`, incluindo o relacionamento entre eles.

## Pré-requisitos

- .NET SDK instalado (versão 6.0 ou superior)
- Entity Framework Core instalado

## Estrutura do Projeto

O projeto contém os seguintes contextos:
- `BloggingContext`: Gerencia entidades relacionadas a blogs.
- `CategoryContext`: Gerencia entidades relacionadas a categorias.

## Instalação

1. Restaure os pacotes NuGet:

    ```bash
    dotnet restore
    ```

## Aplicar Migrations

### Aplicando as migrações


```bash
dotnet ef database update -c CategoryContext
dotnet ef database update -c BloggingContext
```
