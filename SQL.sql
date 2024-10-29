create database najib;
use najib;



CREATE TABLE info (
    name VARCHAR(255),
    phone_no VARCHAR(20),
    password VARCHAR(255),
    confirm_password VARCHAR(255),
    balance DECIMAL(10, 2) DEFAULT 0,
    PRIMARY KEY (name, phone_no)
);

SELECT * FROM info;
drop table info;

CREATE TABLE point (
    team_name VARCHAR(255) NOT NULL,
    matches INT NOT NULL,
    wins INT NOT NULL,
    losses INT NOT NULL,
    points INT NOT NULL DEFAULT 0, 
    PRIMARY KEY (team_name)
);
Select * From point;



/////////////////A////////////////

CREATE TABLE playerDetailsA (
    jersey_no INT PRIMARY KEY,
    name NVARCHAR(MAX),
    country NVARCHAR(MAX),
    playing_role NVARCHAR(MAX)
);


Select * From playerDetailsA
drop table playerDetails

CREATE TABLE staffsA (
    id INT PRIMARY KEY,
    name VARCHAR(255),
    role VARCHAR(255)
);

Select * From staffsA;



//////////////////////////B///////////////////////
CREATE TABLE playerDetailsB (
    jersey_no INT PRIMARY KEY,
    name NVARCHAR(MAX),
    country NVARCHAR(MAX),
    playing_role NVARCHAR(MAX)
);
Select * From playerDetailsB


CREATE TABLE staffsB (
    id INT PRIMARY KEY,
    name VARCHAR(255),
    role VARCHAR(255)
);

Select * From staffsB;
////////////////////////////////C///////////////////
CREATE TABLE playerDetailsC (
    jersey_no INT PRIMARY KEY,
    name NVARCHAR(MAX),
    country NVARCHAR(MAX),
    playing_role NVARCHAR(MAX)
);
Select * From playerDetailsC

CREATE TABLE staffsC (
    id INT PRIMARY KEY,
    name VARCHAR(255),
    role VARCHAR(255)
);

Select * From staffsC;
////////////////////////////////D///////////////////
CREATE TABLE playerDetailsD(
    jersey_no INT PRIMARY KEY,
    name NVARCHAR(MAX),
    country NVARCHAR(MAX),
    playing_role NVARCHAR(MAX)
);
Select * From playerDetailsD

CREATE TABLE staffsD (
    id INT PRIMARY KEY,
    name VARCHAR(255),
    role VARCHAR(255)
);

Select * From staffsD;
////////////////////////////////E///////////////////
CREATE TABLE playerDetailsE(
    jersey_no INT PRIMARY KEY,
    name NVARCHAR(MAX),
    country NVARCHAR(MAX),
    playing_role NVARCHAR(MAX)
);
Select * From playerDetailsE

CREATE TABLE staffsE (
    id INT PRIMARY KEY,
    name VARCHAR(255),
    role VARCHAR(255)
);

Select * From staffsE;
////////////////////////////////F///////////////////
CREATE TABLE playerDetailsF(
    jersey_no INT PRIMARY KEY,
    name NVARCHAR(MAX),
    country NVARCHAR(MAX),
    playing_role NVARCHAR(MAX)
);
Select * From playerDetailsF

CREATE TABLE staffsF (
    id INT PRIMARY KEY,
    name VARCHAR(255),
    role VARCHAR(255)
);

Select * From staffsF;
////////////////////////////////G///////////////////
CREATE TABLE playerDetailsG(
    jersey_no INT PRIMARY KEY,
    name NVARCHAR(MAX),
    country NVARCHAR(MAX),
    playing_role NVARCHAR(MAX)
);
Select * From playerDetailsG

CREATE TABLE staffsG (
    id INT PRIMARY KEY,
    name VARCHAR(255),
    role VARCHAR(255)
);

Select * From staffsG;
///////////////////////TeamManagmentId////////////////////////
CREATE TABLE TeamManagementId (
    username NVARCHAR(50) PRIMARY KEY,
    password NVARCHAR(50) NOT NULL
);
INSERT INTO TeamManagementId (username, password) 
VALUES 
    ('TeamA', '1111'),
    ('TeamB', '2222'),
    ('TeamC', '3333'),
    ('TeamD', '4444'),
    ('TeamE', '5555'),
    ('TeamF', '6666'),
    ('TeamG', '7777');


Select * From TeamManagementId;