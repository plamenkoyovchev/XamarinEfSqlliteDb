# XamarinEfSqlliteDb
This demo project is showing how to create Sqlite database with EntityFramework Core and Xamarin.Forms application

# Enable migrations
1. Create .NET Core console app and install Microsoft.EntityFrameworkCore, Microsoft.EntityFrameworkCore.Tools, Microsoft.EntityFrameworkCore.Sqlite packages from NuGet.
2. Copy the persistance folder to the console application
3. Execute "Add-Migration InitialDbCreate" from Package Manager Console and this command will generate Migrations folder for you
4. Copy Migrations folder to the .NET Standard project and fix the namespaces of the generated files
5. Make sure you are executing only db.Database.Migrate() from App.xaml.cs file 
6. Start the app and this will create the tables
7. If you want to create new entity you need to repeat the procedure
8. Create new entity
9. Copy the new class to the persistance folder of the console application
10. Execute "Add-Migration AddStorageEntity" from Package Manager Console 
11. Copy the newly generated files from Migrations folder and paste them into .NET Standard Migrations folder and fix the namespaces
12. Run the app again and the database should be updated
