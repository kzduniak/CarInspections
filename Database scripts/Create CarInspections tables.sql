-- Database: CarInspections

DROP TABLE IF EXISTS "CarInspection";
DROP TABLE IF EXISTS "Car";

CREATE TABLE IF NOT EXISTS "Car" (
	"Id" serial PRIMARY KEY,
	"RegistrationNumber" varchar(9) UNIQUE NOT NULL,
	"Brand" varchar(100) NOT NULL,
	"Model" varchar(100) NOT NULL
);


CREATE TABLE IF NOT EXISTS "CarInspection" (
	"Id" serial PRIMARY KEY,
	"InspectionDate" date NOT NULL,
	"NextInspectionDate" date NOT NULL,
	"IsRoadWorthy" boolean NOT NULL,
	"CarId" int NOT NULL,	
	CONSTRAINT fk_car FOREIGN KEY("CarId") REFERENCES "Car"("Id")
);