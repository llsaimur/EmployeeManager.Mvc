# EmployeeManager.Mvc

Employee Manager application using ASP.NET Core MVC. The
application’s user interface is built using Tag Helpers. The database CRUD operations are
performed using Entity Framework Core. The EF Core model is built manually by creating
POCOs and mapping them to the table schema. To perform the mapping and model
validations, data annotation attributes are used. The user authentication and authorization
is provided using ASP.NET Core Identity. Specifically, this uses:

  • Use the Model-View-Controller pattern to build an ASP.NET Core
  web application
  • Utilize Tag Helpers to render HTML form and form fields
  • Perform CRUD operations using Entity Framework Core
  • Perform data validations using data annotation attributes
  • Implement user registration and sign-in using ASP.NET Core Identity

Functionalities:

  -Signing In to Employee Manager
  -Creating a New User Account
  -Listing All the Employees
  -Inserting a New Employee
  -Updating Existing Employee
  -Deleting Existing Employee
  -Signing Out of Employee Manager

What I Learned:

  -Built Employee Manager application using ASP.NET Core MVC
  -Created model using Entity Framework Core
  -Became familiar with DbContext and DbSet classes
  -Developed EmployeeManagerController with CRUD actions
  -Utilized Razor Views and Tag Helpers for user interface
  -Secured application using ASP.NET Core Identity
  -Enabled user authentication and authorization
  -Learned about UserManager, RoleManager, SignInManager classes
  -Utilized [Authorize] attribute for authorization
