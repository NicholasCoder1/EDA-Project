CREATE DATABASE STC;
GO

USE STC;
GO

CREATE TABLE Patient
(
PatientID int Identity Primary key,
fName varchar(20),
lName varchar(30) not null,
gender varchar(20),
maritalStatus varchar(20),
homePhone bigint not null,
emergencyPhone bigint not null,
email varchar(30) unique,
medicalConditions varchar(100),
ad_dress varchar(100) unique,
postalCode bigint not null,
country varchar (100),
mailingAddress varchar(100) unique,
);
GO

insert into Patient(fName,lName,gender,maritalStatus,homePhone,emergencyPhone,email,medicalConditions,ad_dress,postalCode,country,mailingAddress)
VALUES
('Garfield','Robinson','Male','Single',8761325456,8765469078,'Robby@gmail.com','Asthma','25 Sky Drive',325,'Jamaica', '25 Sky Drive'),
('Alice','Smith','Female','Married',8766327808,8765002199,'Asmith@yahoo.com','Diabetes','102 Manor Avenue',973,'Jamaica', '90A Blue Road'),
('Chris','Foster','Male','Single',8767831050,8766782346,'fosterChris@gmail.com','Allegies','4 Skyline Lane',619,'Jamaica', '4 Skyline Lane'),
('Vanessa','Robertson','Female','Divorce',8762443243,8768901456,'VanRob@outlook.com','High Blood Pressure','3B Norbrook Avenue',554,'Jamaica', '3B Norbrook Avenue'),
('Lisa','Thorpe','Female','Widowed',8764620968,8762236757,'Lthorpe@gmail.com','Asthma','67C Hollywood Drive',489,'Jamaica', '25 Whitehall Avenue');
GO

select * from Patient
delete from Patient where PatientID=1
update Patient set fName ='Anthony' ,lName = 'Clark',gender ='Male',maritalStatus = 'Married',homePhone =8765930583 ,emergencyPhone = 8765943033,email = 'ClarkA@gmail.com' ,medicalConditions ='Asthma',ad_dress ='25 Molness Road',postalCode = 493,country = 'Jamaica',mailingAddress = '192 Highway Aveune' where PatientID = 2


CREATE TABLE Ad_min
(
Ad_minID int identity primary key,
Ad_minFName varchar(20)not null,
Ad_minLName varchar(20)not null,
Ad_minSpecialty varchar(40)not null,
);
GO

insert into Ad_min(Ad_minFName,Ad_minLName,Ad_minSpecialty)
VALUES
('Mark','Richards','Respriratory'),
('Sarah','Weeks','General'),
('Tia','Williams','Pediatric'),
('Josh','Miller','General'),
('Kate','Katsu','Cardio');
GO

select * from Ad_min
delete from Ad_min where Ad_minID=1
update Ad_min set Ad_minFName ='Anthony',Ad_minLName ='Robinson', Ad_minSpecialty ='Cardio' where Ad_minID = 2
GO



CREATE TABLE Appointment
(
AppID Int identity (1050,1)primary key,
Ad_minID int foreign key references Ad_min(Ad_minID),
App_Date date not null,
);
GO

insert into Appointment(App_Date)
VALUES
('2023-10-16'),
('2023-03-31'),
('2023-12-07'),
('2023-09-19'),
('2023-11-27');
GO

select * from Appointment
delete from Appointment where AppID=1050
update Appointment set Ad_minID = 200, App_date ='2023-04-18' where AppID = 1050



CREATE TABLE Prescription
(
PrescriptionID Int identity primary key,
PatientID int foreign key references Patient(PatientID),
AppID int foreign key references Appointment(AppID),
MedicationName varchar(30)not null,
);
GO

insert into Prescription(MedicationName)
VALUES
('Hydrocotisone'),
('Antibiotics'),
('Isotretinoin'),
('Antihisamines'),
('Pain Killers'),
('Metformin'),
('Lisinopril'),
('Aspirin'),
('Nasal Spray'),
('Iron Supplements');
GO

select * from Prescription
delete from Prescription where PrescriptionID=1
update Prescription set MedicationName ='Voltaren Emulgel' where PrescriptionID = 2
GO

 