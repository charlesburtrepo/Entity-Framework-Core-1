Entity Framework Core 1

EF Documentation [link](https://docs.microsoft.com/en-us/ef/)

## Description

In the video below you can see me creating this basic console application to add Schools to a SQL local database using Entity Framework Core.

## Steps

1.  Create a blank solution
2.  Add new project > class library > name it "Model"
3.  Add new project > class library > name it "Data"
4.  Add new project > console application > name it "View"
5.  Right click the Data project > Manage NuGet Packages > Browse for "Microsoft.EntityFrameworkCore.SqlServer > Install
6.  Delete autocreated classes in each project, e.g. "Class1.cs"
7.  Add new class into Data project called Context
8.  Add new class into Model project called School
9.  Add new class into Model project called Subject
10.  In the Context class

1.  inherit from DbContext
2.  import the necessary library
3.  Create a property DbSet<School> Schools { get; set; }
4.  Create a property DbSet<Subject> Subjects { get; set; }
5.  Add a project reference inside the Data project to the Model project
6.  Add necessary usings for the Schools and Subjects properties
7.  Use autocomplete to type a function: override OnConfiguring
8.  Within the function, replace the existing code with optionsBuilder.UseSqlServer("Data Source= (localdb)\\\MSSQLLocalDB; Initial Catalog=SchoolsAppData");

12.  In the School class

1.  Create a property public int Id { get; set; }
2.  Create a property public int Name { get; set; }

14.  In the Subject class

1.  Create a property public int Id { get; set; }
2.  Create a property public int Name { get; set; }

16.  Make sure all classes, methods and properties that need to be accessed publicly are set to public throughout this example
17.  Inside the View project

1.  Add a project reference to the Data and Model projects
2.  In the Program class (inside the View project)

1.  Create a new instance of the Context class: public static Context context = new Context();
2.  Make sure the database is created on run: context.Database.EnsureCreated();
3.  Create a new School: var school = new School();
4.  Grab the user's input as the school's name: school.Name = Console.ReadLine();
5.  Add the school to the database: context.Schools.Add(school);
6.  Save the changes: context.SaveChanges();
7.  Print out the school names by first grabbing the schools data from the database: var data = context.Schools.ToList();
8.  Print out all the school's names using a foreach loop

19.  Run the project with Ctrl+F5
20.  Add some schools
21.  In Visual Studio's SQL Server Object Explorer, you should be able to see the newly created database and right click it, then select view data to see the new info
22.  If there are any issues, please check the video

## Prerequisites

*   .NET SDK 5 from [link](https://dotnet.microsoft.com)
*   VS 2019

## Video

<a href="https://youtu.be/h_mO3Z4_Zpw">Link</a> 