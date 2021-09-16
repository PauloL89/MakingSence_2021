--DATABASE SQL SERVER

--CREATE DATABASE RentCarsDB;

--USE RentCarsDB;

CREATE TABLE Brand
(
	IdBrand int Identity(1,1) PRIMARY KEY,
	NameBrand varchar(50)
)

CREATE TABLE Color
(
	IdColor int Identity(1,1) PRIMARY KEY,
	NameColor Varchar(20)
);

CREATE TABLE Box
(
	IdBox int identity(1,1) Primary key,
	NameBox varchar(20)
);

CREATE TABLE Car
(
	IdCar int Identity(1,1) PRIMARY KEY,
	Model int,
	Doors int,
	IdBox int,
	IdBrand int,
	IdColor int,

	FOREIGN KEY (IdBrand)REFERENCES Brand(IdBrand),
	FOREIGN KEY(IdColor) REFERENCES Color(IdColor),
	Foreign key (IdBox) References Box(Idbox)
);

CREATE TABLE Customer
(
		Dni char(8) PRIMARY KEY, 
        Name varchar(50),
        LastName varchar(50),
        Telephone varchar(14),
        Address varchar(100), 
        Town varchar(50), 
        Province varchar(50), 
        PostalCode varchar(5),
        LastModificationDate Date
);

CREATE TABLE Rental
(
	IdRental int Primary key identity(1,1),
	RentalDuration int,
	DNICustomer char(8),
	IdCar int,
	ReturnDate date
	FOREIGN KEY (DNICustomer)REFERENCES Customer(Dni),
	FOREIGN KEY(IdCar) REFERENCES Car(IdCar)

)

INSERT INTO Brand(NameBrand)VALUES('Audi');
INSERT INTO Brand(NameBrand)VALUES('BMW');
INSERT INTO Brand(NameBrand)VALUES('Chevrolet');
INSERT INTO Brand(NameBrand)VALUES('Ford');
INSERT INTO Brand(NameBrand)VALUES('Fiat');
INSERT INTO Brand(NameBrand)VALUES('Peugeot');
INSERT INTO Brand(NameBrand)VALUES('Volskwagen');
INSERT INTO Brand(NameBrand)VALUES('Nissan');
INSERT INTO Brand(NameBrand)VALUES('Toyota');

INSERT INTO Color (NameColor)VALUES('Blue');
INSERT INTO Color (NameColor)VALUES('Yellow');
INSERT INTO Color (NameColor)VALUES('White');
INSERT INTO Color (NameColor)VALUES('Black');
INSERT INTO Color (NameColor)VALUES('Green');
INSERT INTO Color (NameColor)VALUES('Gray');
INSERT INTO Color (NameColor)VALUES('Pink');
INSERT INTO Color (NameColor)VALUES('Violet');

INSERT INTO Box (NameBox)Values('Manual');
INSERT INTO Box (NameBox)Values('Automatic');

