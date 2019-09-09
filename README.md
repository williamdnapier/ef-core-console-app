# Entity Framework Core in .NET Core Console App
This project uses .NET Core SDK version 2.2.301 with Entity Framework Core to create a simple console application. This console application serves only one purpose -- to demostrate knowledge of Entity Framework Core with basic .NET Core SDK functionality.

The significance in this app is the way in which it was built. Following Microsoft documentation, I used the .NET Core SDK to do the following steps:

1. Create a new project
```
dotnet new console -o ConsoleApp.SQLite
```
2. Install Entity Framework Core
```
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Design
```
3. Run ```dotnet restore``` to install new packages.

4. Create the Product and Store models.
5. Using migrations, I created the SQLite database with the following .NET Core SDK commands:
```
dotnet ef migrations add InitialCreate
dotnet ef database update
```
6. Then, when the app is run in the VS Code terminal, you can see the results of adding model records to the database.
```
ConsoleApp.SQLite>dotnet run
1 records saved to the database

All stores in the database:
...
```
7. Also, updated the Store model and ran additional migrations in order to try that.
