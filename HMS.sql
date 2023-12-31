CREATE DATABASE Project_KIA
DROP DATABASE Project_KIA;

DROP TABLE LOGIN;
CREATE TABLE LOGIN(
Username varchar(30) NOT NULL PRIMARY KEY,
Pasword varchar(30) NOT NULL,
);

SELECT *
FROM LOGIN;

DROP TABLE PATIENT;
CREATE TABLE PATIENT(
Patient_CNIC varchar(30) NOT NULL PRIMARY KEY,
Patient_ID int NOT NULL IDENTITY(1,1),
Patient_Name varchar(30) NOT NULL,
Adress varchar(30) NOT NULL,
Age int NOT NULL,
Gender varchar(30) NOT NULL,
CellNo varchar(30) NOT NULL);

SELECT *
FROM PATIENT;

DROP TABLE DOCTOR
CREATE TABLE DOCTOR(
Doctor_CNIC varchar(30) NOT NULL PRIMARY KEY,
Doctor_ID varchar(30) NOT NULL,
Doctor_Name varchar(30) NOT NULL,
Adress varchar(30) NOT NULL,
Dept varchar(30) NOT NULL,
Qualification varchar(30) NOT NULL,
CellNo varchar(30) NOT NULL);

SELECT *
FROM DOCTOR;

DROP TABLE APPOINTMENT;
CREATE TABLE APPOINTMENT(
Appointment_No int NOT NULL PRIMARY KEY IDENTITY(1,1),
Appointment_Date varchar(30) NOT NULL,
Appoitment_Time varchar(30) NOT NULL,
Patient_CNIC varchar(30) NOT NULL,
CONSTRAINT con_fk1 FOREIGN KEY(Patient_CNIC) REFERENCES PATIENT(Patient_CNIC) ON UPDATE CASCADE ON DELETE CASCADE
);

SELECT *
FROM APPOINTMENT;

DROP TABLE ADMIN;
CREATE TABLE ADMIN(
Admin_ID varchar(30) NOT NULL PRIMARY KEY,
Admin_CNIC varchar(30) NOT NULL,
Admin_Name varchar(30) NOT NULL,
Adress varchar(30) NOT NULL,
CellNo varchar(30) NOT NULL,
);

SELECT *
FROM ADMIN;

DROP TABLE PRESCRIPTION;
CREATE TABLE PRESCRIPTION(
Prescription_No int NOT NULL PRIMARY KEY IDENTITY(1000,1),
Medicine_Name varchar(30) NOT NULL,
Medicine_Code varchar(30) NOT NULL,
Medicine_Dozage varchar(30) NOT NULL,
Patient_CNIC varchar(30) FOREIGN KEY REFERENCES PATIENT(Patient_CNIC));

SELECT *
FROM PRESCRIPTION;

DROP TABLE PHARMACY;
CREATE TABLE PHARMACY(
Pharmacy_No varchar(30) NOT NULL PRIMARY KEY,
Alter_medicine varchar(30),
Patient_CNIC varchar(30) FOREIGN KEY REFERENCES PATIENT(Patient_CNIC));

SELECT *
FROM PHARMACY;


INSERT INTO LOGIN
VALUES('Aleesha','1094'),
('Khadija','1110'),
('Iqra','1108');

INSERT INTO DOCTOR
VALUES('12345678','1110','Nisar Ahmed','Abc','Physician','MBBS','0502625255'),
('12345','1094','Aleesha','Abc','Cardiology','MBBS','0502625255'),
('1234567','1108','Iqra','Abc','Nose & Thraot','MBBS','0502625255');

SELECT *
FROM LOGIN
WHERE Username='Aleesha' AND Pasword='1094';
