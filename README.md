# Metro Digital Homework - MPos Air

### Project information
- Technologies:
    - ASP.NET Core 3.1 Web API
-    Entity Framework
- Architecture:
    - Domain Driven Design
    - Clean Architecture Oriented
- Database: SQL Server

### Requirement assumptions
Below are my assumptions of the requirements
- A basket must have customer name with it
- Article's price must be non-negative
- We can only add article to basket or close it if it's not closed yet

### Execution guide
Here are the steps to run the project locally
- Create a SQL Server database and execute sql file [create_db_structure.sql] to import table structure
- In the project, replace the connection string with your connection string in appsettings.json
- Run the project
