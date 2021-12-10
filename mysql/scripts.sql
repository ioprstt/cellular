CREATE DATABASE cellular;

USE cellular;

CREATE TABLE IF NOT EXISTS Passports(
    Id INT NOT NULL AUTO_INCREMENT,
    Series VARCHAR(4) NOT NULL,
    Num VARCHAR(6) NOT NULL,
    DateOfIssue DATE NOT NULL,
    IssuingAuthority VARCHAR(63) NOT NULL,
    Name VARCHAR(63) NOT NULL,
    Surname VARCHAR(63) NOT NULL,
    Patronymic VARCHAR(63) NULL DEFAULT NULL,
    DateOfBirth DATE NOT NULL,
    Address VARCHAR(255) NOT NULL,
    PRIMARY KEY(Id),
    UNIQUE KEY(Series, Num)
);

CREATE TABLE IF NOT EXISTS Clients(
    Id INT NOT NULL AUTO_INCREMENT,
	PassportId INT NOT NULL,
	PRIMARY KEY(Id),
	CONSTRAINT IX_Clients_PassportId FOREIGN KEY (PassportId) REFERENCES Passports (Id)
);

CREATE TABLE IF NOT EXISTS PhoneNumbers(
    Id INT NOT NULL AUTO_INCREMENT,
	Num VARCHAR(11) NOT NULL UNIQUE,
	ClientId INT NOT NULL,
	RegistrationDate DATE NOT NULL,
	PRIMARY KEY (Id),
	CONSTRAINT IX_PhoneNumbers_ClientId FOREIGN KEY (ClientId) REFERENCES Clients (Id),
    UNIQUE KEY(Num)
);

CREATE TABLE IF NOT EXISTS Calls(
    Id INT NOT NULL AUTO_INCREMENT,
	StartTime DATETIME NOT NULL,
	EndTime DATETIME NOT NULL,
	OutgoingPhoneNumberId INT not NULL,
	IncomingPhoneNumberId INT not NULL,
	PRIMARY KEY (Id),
    CONSTRAINT IX_Calls_OutgoingPhoneNumberId FOREIGN KEY (OutgoingPhoneNumberId) REFERENCES PhoneNumbers (Id),
    CONSTRAINT IX_Calls_IncomingPhoneNumberId FOREIGN KEY (IncomingPhoneNumberId) REFERENCES PhoneNumbers (Id)
);


-- remove tables

DELETE FROM Calls;
DELETE FROM PhoneNumbers;
DELETE FROM Clients;
DELETE FROM Passports;

-- inset

INSERT INTO `Passports` (`Id`, `Series`, `Num`, `DateOfIssue`, `IssuingAuthority`, `Surname`, `Name`, `Patronymic`, `DateOfBirth`, `Address`) VALUES (NULL, '5555', '111111', '2021-12-01', 'МВД г. Владимир', 'Пупкин', 'Василий', 'Петрович', '2000-12-01', 'г. Владимир');
INSERT INTO `Passports` (`Id`, `Series`, `Num`, `DateOfIssue`, `IssuingAuthority`, `Surname`, `Name`, `Patronymic`, `DateOfBirth`, `Address`) VALUES (NULL, '9999', '444444', '2021-12-02', 'МВД г. Москва', 'Бобриков', 'Игорь', 'Ильич', '2001-10-10', 'г. Мурманск');

INSERT INTO `Clients` (`Id`, `PassportId`) VALUES (NULL, '1');
INSERT INTO `Clients` (`Id`, `PassportId`) VALUES (NULL, '2');

INSERT INTO `PhoneNumbers` (`Id`, `Num`, `ClientId`, `RegistrationDate`) VALUES (NULL, '88005553535', '1', '2001-02-02');
INSERT INTO `PhoneNumbers` (`Id`, `Num`, `ClientId`, `RegistrationDate`) VALUES (NULL, '89057777777', '2', '2011-10-07');