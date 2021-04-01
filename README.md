# Fullstack-exercise
## Coding Exercise – Full stack


The exercise was built in two simple projects as WebAPI (NetCore 3.1) and UI-Client (Angular 11). Regarding to the WebApi was split into two layers/projects: roofstock.Api and roofstock.Data. In the roofstock.Api I register the services using DependencyInjection and provided a couple of extension methods to register the DbContext from roofstock.Data and the AutoMapper custom configuration which is how I communicate between layers. The DbContext uses EFCore with LINQ and CodeFirst strategy for the database creation. For consuming the external file from the API provided in the requirement I used the Adapter patter to convert the data.

## Architecture Diagram
![alt text](https://github.com/crissanchez92/fullstack-exercise/blob/main/ArchitectureDiagram.png)

## Requirements
1- Git Client: https://git-scm.com/book/en/v2/Getting-Started-The-Command-Line<br />
2- NetCore CLI: https://docs.microsoft.com/en-us/dotnet/core/tools/<br />
3- EFCore CLI: https://docs.microsoft.com/en-us/ef/core/cli/dotnet<br />
4- Angular CLI: https://angular.io/cli<br />
5- SQLExpress: https://docs.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb?view=sql-server-ver15<br />


## Environment setup:
1- Open a new console and clone the repository
 > git clone https://github.com/crissanchez92/fullstack-exercise.git

2- In a new console navigate to the Api folder ~ API Console
 > cd fullstack-exercise/properties-api

3- Navigate to roofstock.Data folder
 > cd roofstock.Data
 
4- Generate the Database (Review notes at the bottom)[1] ~ API Console
 > dotnet ef database update
 
5- Navigate to the roofstock.Api folder ~ API Console
 > cd ../roofstock.Api
 
6- Restore the API project ~ API Console
 > dotnet restore
 
7- Build the API ~ API Console
 > dotnet build

8- Run the Api ~ API Console
 > dotnet run

9- In a new console navigate to the Client folder and use develop branch ~ Client Console
 > cd fullstack-exercise/properties-client

10- Install dependencies for Client ~ Client Console
 > yarn install

11- Run the Client ~ Client Console
 > ng serve
 
12- Open the Application
 > http://localhost:4200/

## Notes:

[1]: make sure the connection string is pointing to valid local SQL Server, appsettings.json has the default connection string so use the following pattern in case of changing it:
Data Source=[YOUR_SQLSERVER];Initial Catalog=Roofstock;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
Both database creation factory and dbcontext are using the connection string from appsettings.json in roofstock.Api project.


The appsettings file is located in the folder: \properties-api\roofstock.Api\appsettings.json.


For more details please review the README.docx file attached with further information.