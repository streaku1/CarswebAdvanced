CarsWeb is an ASP.NET Core MVC application built with Entity Framework Core and SQL Server. It uses CRUD operations, MVC structure, and database relationships.

The application manages cars, customers, and reviews. Each review is linked to a specific car using a foreign key.

You can view cars and their details. You can also see a list of current customers and their details.

The app allows you to create reviews with a comment, rating, and selected car.

It includes error handling that displays custom 404 and 500 error pages instead of crashing when an exception occurs.

You can register and login using the navigation bar buttons on the top right of the screen included in the layout by using your email and a password.

How to use:

Run locally

Clone the repository

Update the connection string in appsettings.json

Run database migrations  
dotnet ef database update

Start the app  
dotnet run
