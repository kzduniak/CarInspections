-- Database: CarInspections

delete from "CarInspection";
delete from "Car";

INSERT INTO "Car" ("RegistrationNumber","Brand","Model") VALUES ('PKA23456','Peugeot','206');
INSERT INTO "Car" ("RegistrationNumber","Brand","Model") VALUES ('SG8743C','Audi','A6');
INSERT INTO "Car" ("RegistrationNumber","Brand","Model") VALUES ('WW76567','Fiat','Punto');
INSERT INTO "Car" ("RegistrationNumber","Brand","Model") VALUES ('KR11357','BMW','530');
INSERT INTO "Car" ("RegistrationNumber","Brand","Model") VALUES ('SK37YT4','Volkswagen','Passat');
INSERT INTO "Car" ("RegistrationNumber","Brand","Model") VALUES ('DW54637','Dacia','Logan');
INSERT INTO "Car" ("RegistrationNumber","Brand","Model") VALUES ('SG72846','Renault','Megane');

INSERT INTO "CarInspection" ("InspectionDate","NextInspectionDate","IsRoadWorthy","CarId") VALUES ('2018-02-01','2019-02-01',true, (select "Id" from "Car" where "RegistrationNumber"='PKA23456'));
INSERT INTO "CarInspection" ("InspectionDate","NextInspectionDate","IsRoadWorthy","CarId") VALUES ('2019-02-01','2020-02-01',true, (select "Id" from "Car" where "RegistrationNumber"='PKA23456'));
INSERT INTO "CarInspection" ("InspectionDate","NextInspectionDate","IsRoadWorthy","CarId") VALUES ('2020-02-01','2021-02-01',true, (select "Id" from "Car" where "RegistrationNumber"='PKA23456'));
INSERT INTO "CarInspection" ("InspectionDate","NextInspectionDate","IsRoadWorthy","CarId") VALUES ('2021-02-01','2022-02-01',true, (select "Id" from "Car" where "RegistrationNumber"='PKA23456'));

INSERT INTO "CarInspection" ("InspectionDate","NextInspectionDate","IsRoadWorthy","CarId") VALUES ('2018-03-22','2019-03-22',true, (select "Id" from "Car" where "RegistrationNumber"='SG8743C'));
INSERT INTO "CarInspection" ("InspectionDate","NextInspectionDate","IsRoadWorthy","CarId") VALUES ('2019-03-22','2020-03-22',true, (select "Id" from "Car" where "RegistrationNumber"='SG8743C'));
INSERT INTO "CarInspection" ("InspectionDate","NextInspectionDate","IsRoadWorthy","CarId") VALUES ('2020-03-22','2021-03-22',true, (select "Id" from "Car" where "RegistrationNumber"='SG8743C'));
INSERT INTO "CarInspection" ("InspectionDate","NextInspectionDate","IsRoadWorthy","CarId") VALUES ('2021-03-22','2022-03-22',false,(select "Id" from "Car" where "RegistrationNumber"='SG8743C'));

INSERT INTO "CarInspection" ("InspectionDate","NextInspectionDate","IsRoadWorthy","CarId") VALUES ('2018-01-18','2019-01-18',true, (select "Id" from "Car" where "RegistrationNumber"='WW76567'));
INSERT INTO "CarInspection" ("InspectionDate","NextInspectionDate","IsRoadWorthy","CarId") VALUES ('2019-01-18','2020-01-18',true, (select "Id" from "Car" where "RegistrationNumber"='WW76567'));
INSERT INTO "CarInspection" ("InspectionDate","NextInspectionDate","IsRoadWorthy","CarId") VALUES ('2020-01-18','2021-01-18',true, (select "Id" from "Car" where "RegistrationNumber"='WW76567'));
INSERT INTO "CarInspection" ("InspectionDate","NextInspectionDate","IsRoadWorthy","CarId") VALUES ('2021-01-18','2022-01-18',true, (select "Id" from "Car" where "RegistrationNumber"='WW76567'));
INSERT INTO "CarInspection" ("InspectionDate","NextInspectionDate","IsRoadWorthy","CarId") VALUES ('2022-01-18','2023-01-18',true, (select "Id" from "Car" where "RegistrationNumber"='WW76567'));

INSERT INTO "CarInspection" ("InspectionDate","NextInspectionDate","IsRoadWorthy","CarId") VALUES ('2018-12-03','2019-12-03',true, (select "Id" from "Car" where "RegistrationNumber"='KR11357'));
INSERT INTO "CarInspection" ("InspectionDate","NextInspectionDate","IsRoadWorthy","CarId") VALUES ('2019-12-03','2020-12-03',true, (select "Id" from "Car" where "RegistrationNumber"='KR11357'));
INSERT INTO "CarInspection" ("InspectionDate","NextInspectionDate","IsRoadWorthy","CarId") VALUES ('2020-12-03','2021-12-03',true, (select "Id" from "Car" where "RegistrationNumber"='KR11357'));
INSERT INTO "CarInspection" ("InspectionDate","NextInspectionDate","IsRoadWorthy","CarId") VALUES ('2021-12-03','2022-12-03',true, (select "Id" from "Car" where "RegistrationNumber"='KR11357'));

INSERT INTO "CarInspection" ("InspectionDate","NextInspectionDate","IsRoadWorthy","CarId") VALUES ('2018-07-30','2019-07-30',true, (select "Id" from "Car" where "RegistrationNumber"='SK37YT4'));
INSERT INTO "CarInspection" ("InspectionDate","NextInspectionDate","IsRoadWorthy","CarId") VALUES ('2019-07-30','2020-07-30',true, (select "Id" from "Car" where "RegistrationNumber"='SK37YT4'));
INSERT INTO "CarInspection" ("InspectionDate","NextInspectionDate","IsRoadWorthy","CarId") VALUES ('2020-07-30','2021-07-30',true, (select "Id" from "Car" where "RegistrationNumber"='SK37YT4'));
INSERT INTO "CarInspection" ("InspectionDate","NextInspectionDate","IsRoadWorthy","CarId") VALUES ('2021-07-30','2022-07-30',false,(select "Id" from "Car" where "RegistrationNumber"='SK37YT4'));