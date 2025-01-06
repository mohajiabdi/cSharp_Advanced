Create database Pharmacy

use pharmacy

drop database Pharmacy;

create table

CREATE TABLE Roles (
    RoleID INT PRIMARY KEY IDENTITY(1,1),
    RoleName NVARCHAR(20) NOT NULL UNIQUE
);

CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL UNIQUE,
    PasswordHash NVARCHAR(255) NOT NULL,
    RoleID INT NOT NULL,
    FOREIGN KEY (RoleID) REFERENCES Roles(RoleID)
);

/*
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL UNIQUE,
    PasswordHash NVARCHAR(255) NOT NULL,
    Role NVARCHAR(30) NOT NULL
);
*/

CREATE TABLE UserDt (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(50) NOT NULL
);

CREATE TABLE UserDt (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(50) NOT NULL,
    Role NVARCHAR(20) NOT NULL CHECK (Role IN ('Admin', 'Staff'))
);


drop table userdt





CREATE TABLE Medicines (
    MedicineID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    Manufacturer NVARCHAR(50) NOT NULL,
    ExpiryDate DATE NOT NULL,
    Price DECIMAL(10,2) NOT NULL,
    Quantity INT NOT NULL
);


SELECT Quantity FROM Medicines WHERE MedicineID = 2;


CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY IDENTITY(1,1),
    CustomerName NVARCHAR(100) NOT NULL,
    ContactNumber NVARCHAR(15) Not NULL unique
);

select * from sales
select * from SalesDetails

CREATE TABLE Sales (
    SaleID INT PRIMARY KEY IDENTITY(1,1),
    CustomerID INT NULL,
    SaleDate DATETIME DEFAULT GETDATE(),
    TotalAmount DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID) ON DELETE SET NULL
);

CREATE TABLE SalesDetails (
    SaleDetailID INT PRIMARY KEY IDENTITY(1,1),
    SaleID INT NOT NULL,
    MedicineID INT NOT NULL,
    Quantity INT NOT NULL,
    Price DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (SaleID) REFERENCES Sales(SaleID) ON DELETE CASCADE,
    FOREIGN KEY (MedicineID) REFERENCES Medicines(MedicineID) ON DELETE CASCADE
);

SELECT SUM(sd.Quantity * sd.Price) AS TotalIncome
FROM Sales s
INNER JOIN SalesDetails sd ON s.SaleID = sd.SaleID

INSERT INTO Roles (RoleName) VALUES ('Admin'), ('Staff');


INSERT INTO Users (Username, PasswordHash, RoleID)
VALUES ('admin', 'root', 1); -- RoleID for Admin

select * from users
--delete from users where USER_ID =1;

---------------

-- Inserting 50 sample medicines with ExpiryDate after May 2025

INSERT INTO Medicines (Name, Manufacturer, ExpiryDate, Price, Quantity)
VALUES
    ('Paracetamol 500mg', 'Pharmex', '2025-06-01', 1.50, 100),
    ('Ibuprofen 400mg', 'Meditech', '2025-07-15', 2.00, 80),
    ('Amoxicillin 500mg', 'Biopharm', '2025-08-30', 3.50, 70),
    ('Azithromycin 500mg', 'Unipharm', '2025-09-10', 5.00, 60),
    ('Metformin 500mg', 'GlaxoSmithKline', '2025-10-25', 4.25, 90),
    ('Losartan 50mg', 'Novartis', '2025-11-15', 6.00, 50),
    ('Amlodipine 5mg', 'Pfizer', '2025-12-31', 3.75, 85),
    ('Simvastatin 20mg', 'Merck', '2026-01-15', 4.50, 75),
    ('Omeprazole 20mg', 'AstraZeneca', '2026-02-28', 2.50, 100),
    ('Pantoprazole 40mg', 'Sanofi', '2026-03-30', 3.00, 95),
    ('Fluoxetine 20mg', 'Eli Lilly', '2026-04-15', 5.50, 65),
    ('Sertraline 50mg', 'GlaxoSmithKline', '2026-05-31', 4.75, 80),
    ('Citalopram 20mg', 'Lundbeck', '2026-06-15', 3.25, 70),
    ('Venlafaxine 75mg', 'Wyeth', '2026-07-31', 6.25, 55),
    ('Duloxetine 60mg', 'Eli Lilly', '2026-08-15', 7.00, 60),
    ('Escitalopram 10mg', 'Forest Laboratories', '2026-09-20', 4.50, 85),
    ('Diazepam 5mg', 'Roche', '2026-10-15', 2.75, 75),
    ('Lorazepam 1mg', 'Novartis', '2026-11-28', 3.50, 90),
    ('Alprazolam 0.5mg', 'Pfizer', '2026-12-10', 4.00, 50),
    ('Clonazepam 0.5mg', 'Roche', '2027-01-31', 5.25, 80),
    ('Vitamin C 500mg', 'Pharmex', '2025-06-30', 1.00, 150),
    ('Vitamin D3 400IU', 'Meditech', '2025-07-31', 1.25, 120),
    ('Calcium 600mg', 'Biopharm', '2025-08-15', 0.75, 100),
    ('Magnesium 250mg', 'Unipharm', '2025-09-30', 1.50, 90),
    ('Zinc 30mg', 'GlaxoSmithKline', '2025-10-15', 2.00, 80),
    ('Iron 30mg', 'Novartis', '2025-11-30', 1.75, 70),
    ('Folic Acid 400mcg', 'Pfizer', '2025-12-15', 0.50, 120),
    ('Vitamin B12 1000mcg', 'Merck', '2026-01-31', 2.50, 100),
    ('Multivitamins', 'AstraZeneca', '2026-02-28', 3.00, 90),
    ('Omeprazole 40mg', 'Sanofi', '2025-06-30', 3.00, 95),
    ('Pantoprazole 40mg', 'Sanofi', '2025-07-31', 3.00, 95),
    ('Fluoxetine 20mg', 'Eli Lilly', '2025-08-15', 5.50, 65),
    ('Sertraline 50mg', 'GlaxoSmithKline', '2025-09-30', 4.75, 80),
    ('Citalopram 20mg', 'Lundbeck', '2025-10-15', 3.25, 70),
    ('Venlafaxine 75mg', 'Wyeth', '2025-11-30', 6.25, 55),
    ('Duloxetine 60mg', 'Eli Lilly', '2025-12-15', 7.00, 60),
    ('Escitalopram 10mg', 'Forest Laboratories', '2026-01-20', 4.50, 85),
    ('Diazepam 5mg', 'Roche', '2026-02-15', 2.75, 75),
    ('Lorazepam 1mg', 'Novartis', '2026-03-28', 3.50, 90),
    ('Alprazolam 0.5mg', 'Pfizer', '2026-04-10', 4.00, 50),
    ('Clonazepam 0.5mg', 'Roche', '2026-05-31', 5.25, 80),
    ('Vitamin C 500mg', 'Pharmex', '2025-06-30', 1.00, 150),
    ('Vitamin D3 400IU', 'Meditech', '2025-07-31', 1.25, 120),
    ('Calcium 600mg', 'Biopharm', '2025-08-15', 0.75, 100),
    ('Magnesium 250mg', 'Unipharm', '2025-09-30', 1.50, 90),
    ('Zinc 30mg', 'GlaxoSmithKline', '2025-10-15', 2.00, 80),
    ('Iron 30mg', 'Novartis', '2025-11-30', 1.75, 70),
    ('Folic Acid 400mcg', 'Pfizer', '2025-12-15', 0.50, 120),
    ('Vitamin B12 1000mcg', 'Merck', '2026-01-31', 2.50, 100),
    ('Multivitamins', 'AstraZeneca', '2026-02-28', 3.00, 90);

	select * from Medicines



INSERT INTO Customers (CustomerName, ContactNumber)
VALUES
    ('Abdirahman', '+252611234567'),
    ('Abdulkadir', '+252612345678'),
    ('Ahmed', '+252613456789'),
    ('Ali', '+252614321098'),
    ('Hassan', '+252615678901'),
    ('Hussein', '+252616789012'),
    ('Ismail', '+252617654321'),
    ('Jamaal', '+252618901234'),
    ('Mohamed', '+252619012345'),
    ('Mustafa', '+252611111111'),
    ('Said', '+252612222222'),
    ('Saad', '+252613333333'),
    ('Saciid', '+252614444444'),
    ('Sahra', '+252615555555'),
    ('Samira', '+252616666666'),
    ('Salma', '+252617777777'),
    ('Samia', '+252618888888'),
    ('Shamso', '+252619999999'),
    ('Shukri', '+252611010101'),
    ('Suad', '+252612020202'),
    ('Aisha', '+252613030303'),
    ('Amina', '+252614040404'),
    ('Asma', '+252615050505'),
    ('Faduma', '+252616060606'),
    ('Halima', '+252617070707'),
    ('Hawlwo', '+252618080808'),
    ('Ikram', '+252619090909'),
    ('Iman', '+252611122334'),
    ('Leyla', '+252612233445'),
    ('Maryam', '+252613344556'),
    ('Nimo', '+252614455667'),
    ('Sahra', '+252615566778'),
    ('Saliho', '+252616677889'),
    ('Zakiya', '+252617788990'),
    ('Zainab', '+252618899001'),
    ('Zahra', '+252619900112'),
    ('Zaki', '+252611011223'),
    ('Zakariya', '+252612022334'),
    ('Zubeir', '+252613033445'),
    ('Yusuf', '+252614044556'),
    ('Yahya', '+252615055667'),
    ('Yasin', '+252616066778'),
    ('Yusuf', '+252617077889'),
    ('Yacqub', '+252618088990'),
    ('Yunis', '+252619099001'),
    ('Yusuf', '+252611111112'), 
    ('Yumna', '+252612222223'), 
    ('Yusuf', '+252613333334'), 
    ('Yusuf', '+252614444445'); 



	truncate table customers
	select * from Customers











	-- Inserting 41 Sales records with varying CustomerIDs (20-60)

INSERT INTO Sales (CustomerID, SaleDate, TotalAmount) VALUES
    (20, DATEADD(DAY, -10, GETDATE()), 150.00),
    (21, DATEADD(DAY, -5, GETDATE()), 200.50),
    (22, GETDATE(), 120.00),
    (23, DATEADD(DAY, -20, GETDATE()), 80.75),
    (24, DATEADD(DAY, -30, GETDATE()), 350.00),
    (25, DATEADD(DAY, -15, GETDATE()), 180.25),
    (26, DATEADD(DAY, -7, GETDATE()), 90.00),
    (27, DATEADD(DAY, -12, GETDATE()), 250.00),
    (28, DATEADD(DAY, -25, GETDATE()), 110.50),
    (29, GETDATE(), 400.00),
    (30, DATEADD(DAY, -10, GETDATE()), 175.00),
    (31, DATEADD(DAY, -5, GETDATE()), 220.50),
    (32, GETDATE(), 130.00),
    (33, DATEADD(DAY, -20, GETDATE()), 90.75),
    (34, DATEADD(DAY, -30, GETDATE()), 375.00),
    (35, DATEADD(DAY, -15, GETDATE()), 190.25),
    (36, DATEADD(DAY, -7, GETDATE()), 100.00),
    (37, DATEADD(DAY, -12, GETDATE()), 275.00),
    (38, DATEADD(DAY, -25, GETDATE()), 120.50),
    (39, GETDATE(), 420.00),
    (40, DATEADD(DAY, -10, GETDATE()), 185.00),
    (41, DATEADD(DAY, -5, GETDATE()), 230.50),
    (42, GETDATE(), 140.00),
    (43, DATEADD(DAY, -20, GETDATE()), 100.75),
    (44, DATEADD(DAY, -30, GETDATE()), 395.00),
    (45, DATEADD(DAY, -15, GETDATE()), 200.25),
    (46, DATEADD(DAY, -7, GETDATE()), 110.00),
    (47, DATEADD(DAY, -12, GETDATE()), 295.00),
    (48, DATEADD(DAY, -25, GETDATE()), 130.50),
    (49, GETDATE(), 440.00),
    (50, DATEADD(DAY, -10, GETDATE()), 195.00),
    (51, DATEADD(DAY, -5, GETDATE()), 240.50),
    (52, GETDATE(), 150.00),
    (53, DATEADD(DAY, -20, GETDATE()), 110.75),
    (54, DATEADD(DAY, -30, GETDATE()), 415.00),
    (55, DATEADD(DAY, -15, GETDATE()), 210.25),
    (56, DATEADD(DAY, -7, GETDATE()), 120.00),
    (57, DATEADD(DAY, -12, GETDATE()), 315.00),
    (58, DATEADD(DAY, -25, GETDATE()), 140.50),
    (59, GETDATE(), 460.00),
    (60, DATEADD(DAY, -10, GETDATE()), 205.00);

-- Note:
-- This script inserts 41 Sales records with CustomerIDs ranging from 20 to 60.
-- SaleDates are within the past month for better realism.
-- TotalAmounts are sample values and can be adjusted as needed.


select * from sales



SELECT RoleName FROM Users u , Roles r where u.RoleID = r.RoleID and u.Username = 'Admin' AND u.PasswordHash = 'root'

SELECT RoleName FROM Users u , Roles r where u.RoleID = r.RoleID and u.Username = @Username AND u.PasswordHash = @Password




select customerID from Customers order by CustomerID asc



-- Disable the IDENTITY property for the CustomerID column

ALTER TABLE Customers 
ALTER COLUMN CustomerID INT NOT NULL;

-- Insert 12 customers with specified CustomerIDs and English names

INSERT INTO Customers (CustomerID, CustomerName, ContactNumber)
VALUES
    (1, 'John Doe', '+252611234567'),
    (2, 'Jane Smith', '+252612345678'),
    (3, 'David Lee', '+252613456789'),
    (4, 'Sarah Jones', '+252614321098'),
    (5, 'Michael Brown', '+252615678901'),
    (6, 'Emily Davis', '+252616789012'),
    (7, 'Daniel Wilson', '+252617654321'),
    (8, 'Olivia Johnson', '+252618901234'),
    (9, 'James Anderson', '+252619012345'),
    (10, 'Sophia Taylor', '+252611111111'),
    (11, 'William Moore', '+252612222222'),
    (12, 'Emma Clark', '+252613333333');

-- Re-enable the IDENTITY property for the CustomerID column

ALTER TABLE Customers 
ALTER COLUMN CustomerID INT IDENTITY(1,1) PRIMARY KEY;





INSERT INTO Customers (CustomerName, ContactNumber)
VALUES
    ('John Doe', '+252611232167'),
    ('Jane Smith', '+252614345678'),
    ('David Lee', '+252616456789'),
    ('Sarah Jones', '+252615321098'),
    ('Michael Brown', '+252613678901'),
    ('Emily Davis', '+252619789012'),
    ('Daniel Wilson', '+252610654321'),
    ('Olivia Johnson', '+252612901234'),
    ('James Anderson', '+252611012345'),
    ('Sophia Taylor', '+252611011111'),
    ('William Moore', '+252613222222'),
    ('Emma Clark', '+252614333333');