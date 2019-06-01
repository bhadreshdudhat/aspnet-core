**** System Requirements ****

Dot Net Core
1.1 install dot net core version for the project
dotnet-sdk-2.2.107-win-x64.exe
Estimated time : 2 Mins

1.2 Hosting issues
**** Updated Visual Studio to 15.9 .. ******https://support.aspnetzero.com/QA/Questions/6286


2. Open Solution  (if neccessary set Target Framework to .net core 2.2)
Set Web.Host as startup project 
and built it
Estimated time : 2 Mins

3. Change ConnectionStrings to your SQL SERVER or localdb in host project
"ConnectionStrings": {
    
"Default": "Server=DESKTOP-Q4SAD4L\\BHADRESHSQL; Database=VimeoAppDb; Trusted_Connection=True;"
}

For SQL SERVER : DESKTOP-Q4SAD4L\\BHADRESHSQL
For Local DB : (localdb)\\mssqllocaldb

4. update-database through PM console (select EFCORE project as default project) 

5. Rebuild and Run the project


---------------------------------------------------

Angular

1. npm install
Estimated time : 10 Mins (depends on internet speed)

2. ng serve -o

------------------------------------------------------


Deployment

https://bhadreshdudhat.azurewebsites.net

Create database server[bhadreshdb](with username[bhadresh] and password[Nishtha1618]) and database(with database name  : BhadreshDB) on AZURE
Go to Database and change Set SERVER Firewall : add rule to allow all IP addresses 0.0.0.0 to 255.255.255.255 
https://github.com/Microsoft/azure-pipelines-tasks/issues/3981

Change connection String in appsetting and update-database to run all migration 
--connection String---
Server=tcp:bhadreshdb.database.windows.net,1433;Initial Catalog=BhadreshDB;Persist Security Info=False;User ID=bhadresh;Password=Nishtha1618;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;


Connection string will be added while publishing through VS2017

https://docs.aspnetzero.com/documents/aspnet-core-angular/latest/Deployment-Angular-Publish-Azure

ENABLE CORS on azure for 
http://localhost:4200 and
https://bhadreshngapp.azurewebsites.net

Opening azure database in VS SQLserver Object Explorer

Running combinations :
server file : appsetting.json
client files : developement : environment.ts, appconfig.json
			   production   : environment.prod.ts, appconfig.production.json
1. client & server on localhost using Azure database
2. client & server on Azure using Azure database
3. client & server on localhost using local database


-----------------------------------------------------























