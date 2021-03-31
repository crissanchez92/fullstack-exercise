# fullstack-exercise
Contains a WebAPI and UI

Environment setup:
1- Open a new console and clone the repository
 > git clone https://github.com/crissanchez92/fullstack-exercise.git

3- In a new console navigate to the Api folder ~ API Console
 > cd fullstack-exercise/properties-api

4- Generate the Database (Review notes at the bottom)[1] ~ API Console
 > cd roofstock.Data
 > dotnet ef database update
 
5- Build the Api ~ API Console
 > cd ../roofstock.Api
 > dotnet restore
 > dotnet build

6- Run the Api ~ API Console
 > dotnet run

7- In a new console navigate to the Client folder and use develop branch ~ Client Console
 > cd fullstack-exercise/properties-client

8- Install dependencies for Client ~ Client Console
 > yarn install

9- Run the Client ~ Client Console
 > ng serve
 
10- Open the Application
 > http://localhost:4200/

Notes:
[1]: make sure the connection string is pointing to valid local SQL Server, appsettings.json has the default connection string so use the following pattern in case of changing it:
Data Source=[YOUR_SQLSERVER];Initial Catalog=Roofstock;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
Both database creation factory and dbcontext are using the connection string from appsettings.json in roofstock.Api project.
The appsettings file is located in the folder: \properties-api\roofstock.Api\appsettings.json.


For more details please review the README.docx file attached with further information.