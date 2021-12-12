CREATE DATABASE cellular CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;

USE cellular;

CREATE TABLE `Passports` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Series` VARCHAR(4) CHARACTER SET utf8mb4 NOT NULL,
    `Num` VARCHAR(6) CHARACTER SET utf8mb4 NOT NULL,
    `DateOfIssue` DATE NOT NULL,
    `IssuingAuthority` VARCHAR(63) CHARACTER SET utf8mb4 NOT NULL,
    `Surname` VARCHAR(63) CHARACTER SET utf8mb4 NOT NULL,
    `Name` VARCHAR(63) CHARACTER SET utf8mb4 NOT NULL,
    `Patronymic` VARCHAR(63) CHARACTER SET utf8mb4 NULL,
    `DateOfBirth` DATE NOT NULL,
    `Address` VARCHAR(255) CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK_Passports` PRIMARY KEY (`Id`)
) CHARACTER SET utf8mb4;


CREATE TABLE `Clients` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `PassportId` int NOT NULL,
    CONSTRAINT `PK_Clients` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Clients_Passports_PassportId` FOREIGN KEY (`PassportId`) REFERENCES `Passports` (`Id`) ON DELETE CASCADE
) CHARACTER SET utf8mb4;


CREATE TABLE `PhoneNumbers` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `ClientId` int NOT NULL,
    `Num` VARCHAR(11) CHARACTER SET utf8mb4 NOT NULL,
    `RegistrationDate` DATE NOT NULL,
    `Active` BOOLEAN(1) NOT NULL,
    CONSTRAINT `PK_PhoneNumbers` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_PhoneNumbers_Clients_ClientId` FOREIGN KEY (`ClientId`) REFERENCES `Clients` (`Id`) ON DELETE CASCADE
) CHARACTER SET utf8mb4;


CREATE TABLE `Calls` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `OutgoingPhoneNumberId` int NOT NULL,
    `IncomingPhoneNumberId` int NOT NULL,
    `StartTime` datetime(6) NOT NULL,
    `EndTime` datetime(6) NOT NULL,
    CONSTRAINT `PK_Calls` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Calls_PhoneNumbers_IncomingPhoneNumberId` FOREIGN KEY (`IncomingPhoneNumberId`) REFERENCES `PhoneNumbers` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_Calls_PhoneNumbers_OutgoingPhoneNumberId` FOREIGN KEY (`OutgoingPhoneNumberId`) REFERENCES `PhoneNumbers` (`Id`) ON DELETE CASCADE
) CHARACTER SET utf8mb4;


CREATE INDEX `IX_Calls_IncomingPhoneNumberId` ON `Calls` (`IncomingPhoneNumberId`);


CREATE INDEX `IX_Calls_OutgoingPhoneNumberId` ON `Calls` (`OutgoingPhoneNumberId`);


CREATE UNIQUE INDEX `IX_Clients_PassportId` ON `Clients` (`PassportId`);


CREATE UNIQUE INDEX `IX_Passport_SeriesAndNum` ON `Passports` (`Series`, `Num`);


CREATE UNIQUE INDEX `IX_PhoneNumber_Num` ON `PhoneNumbers` (`Num`);


CREATE INDEX `IX_PhoneNumbers_ClientId` ON `PhoneNumbers` (`ClientId`);


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

INSERT INTO `PhoneNumbers` (`Id`, `Num`, `ClientId`, `RegistrationDate`) VALUES (NULL, '89005553535', '1', '2001-02-02');
INSERT INTO `PhoneNumbers` (`Id`, `Num`, `ClientId`, `RegistrationDate`) VALUES (NULL, '89057777777', '2', '2011-10-07');

INSERT INTO `Calls` (`Id`, `OutgoingPhoneNumberId`, `IncomingPhoneNumberId`, `StartTime`, `EndTime`) VALUES (NULL, '1', '2', '2021-12-01 10:39:52.000000', '2021-12-12 13:39:52.000000');
INSERT INTO `Calls` (`Id`, `OutgoingPhoneNumberId`, `IncomingPhoneNumberId`, `StartTime`, `EndTime`) VALUES (NULL, '2', '1', '2021-12-01 10:39:52.000000', '2021-12-12 10:39:59.000000');
INSERT INTO `Calls` (`Id`, `OutgoingPhoneNumberId`, `IncomingPhoneNumberId`, `StartTime`, `EndTime`) VALUES (NULL, '1', '2', '2021-12-01 12:39:52.000000', '2021-12-12 12:51:52.000000');
