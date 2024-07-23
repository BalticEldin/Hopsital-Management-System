create database hospital;


select * from PatientMore;
select * from AddPatient inner join PatientMore on AddPatient.pid = PatientMore.pid

create table medicine
(
MedicineName varchar(50)
)

INSERT INTO medicine (MedicineName) VALUES 
('Analgin'),
('Diazepam'),
('Ibuprofen'),
('VitaminC'),
('Tobradeks'),
('TylolHot'),
('Leksilium'),
('Xanax');

create table AddPatient 
(
Name varchar(150),
Full_Address varchar(300),
Contact bigint,
Age int,
Gender varchar(10),
Blood_Group varchar(20),
Major_Disease varchar(400),
pid bigint unique
)

create table PatientMore
(
pid bigint,
Symptoms varchar(150),
Diagnosis varchar(150),
Medicines varchar(150),
Ward varchar(15),
Ward_Type varchar(20)
)

create table loginn
(
username varchar(200),
password varchar(200)
)