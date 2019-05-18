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






















