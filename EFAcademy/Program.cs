
//using EFAcademy.Model;

//    void Code()
//{
//    var student = new Student("Sven", "Svensson");
//    var stu = student.ToString();

//    Console.WriteLine(stu);
//}

//Code();

//Install EF Core tools: tool install --global dotnet-ef
//Create migrations: dotnet ef migrations add InitialMigration

using EFAcademy;
using Microsoft.EntityFrameworkCore;

var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseSqlite().Options;
var dbContext = new ApplicationDbContext(options);

dbContext.Database.Migrate();


