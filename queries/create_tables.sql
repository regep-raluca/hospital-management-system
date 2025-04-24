CREATE TABLE Patients (
    PatientID INT PRIMARY KEY,
    LastName NVARCHAR(100),
    FirstName NVARCHAR(100),
    Phone NVARCHAR(20),
    Email NVARCHAR(100)
);

CREATE TABLE Doctors (
    DoctorID INT PRIMARY KEY,
    Name NVARCHAR(100),
    Specialty NVARCHAR(100)
);

CREATE TABLE Appointments (
    AppointmentID INT PRIMARY KEY,
    PatientID INT,
    DoctorID INT,
    AppointmentDate DATETIME,
    FOREIGN KEY (PatientID) REFERENCES Patients(PatientID),
    FOREIGN KEY (DoctorID) REFERENCES Doctors(DoctorID)
);
