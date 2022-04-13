The solution implements a REST Api application that provides two endpoints allowing to obtain information about technical inspections of cars.
The REST Api was implemented in .NET Core 6.0, using EntityFramework library with database first approach in order to map the PostgreSQL database to Entites objects and to easily access to the database.

First endpoint provides an HTTP GET method which takes the car registration number as a parameter. If the parameter is not set, the method returns information for all cars saved in database.
Example of GET request:
http://localhost:5000/CarInspections/GetCarInspections?registrationNumber=KR11357 ('5000' is a current application port)

Second endpoint provides an HTTP POST method that works the same way but filtering by car registration number is done using a Body in JSON. 
Example of POST request:
http://localhost:5000/CarInspections/GetCarInspections ('5000' is a current application port)
Body:
{
	"registrationNumber": "KR11357"
}

Example of response:
[
  {
    "registrationNumber": "KR11357",
    "brand": "BMW",
    "model": "530",
    "firstInspectionDate": "2018-12-03",
    "lastInspectionDate": "2021-12-03", 
    "nextInspectionDate": "2022-12-03",
    "currentInspectionIsExpired": false,
	"isRoadWorthy": true
  }
]

In order to run the application on your computer you should create a database on the PostgreSQL server using the scripts located in the "Database scripts" directory with following order:
1. "Create CarInspections database.sql" - a script that creates the CarInspections database
2. "Create CarInspections tables.sql" - script which creates tables to store information about cars and their inspections
3. "Insert CarInspections sample data.sql" - a script that inserts sample data to the database

Next, you need to set the ConnectionString in the appsettings.json file to set up the connection to your database.

In order to facilitate testing of the solution, added Swagger interface to the project, which is available at:
http://localhost:5000/Swagger ('5000' is a current application port)
