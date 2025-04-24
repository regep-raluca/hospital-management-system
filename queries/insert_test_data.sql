-- Insert patients
INSERT INTO Patients (PatientID, LastName, FirstName, Phone, Email)
VALUES (1, 'Popescu', 'Ion', '0712345678', 'ion.popescu@example.com');

INSERT INTO Patients (PatientID, LastName, FirstName, Phone, Email)
VALUES (2, 'Ionescu', 'Maria', '0723456789', 'maria.ionescu@example.com');

-- Insert doctors
INSERT INTO Doctors (DoctorID, LastName, Specialty)
VALUES (1, 'Ionescu', 'Cardiologist');

INSERT INTO Doctors (DoctorID, LastName, Specialty)
VALUES (2, 'Popa', 'Dermatologist');

-- Insert appointments
INSERT INTO Appointments (AppointmentID, PatientID, DoctorID, AppointmentDate)
VALUES (1, 1, 1, '2025-04-25 10:00:00');

INSERT INTO Appointments (AppointmentID, PatientID, DoctorID, AppointmentDate)
VALUES (2, 2, 2, '2025-04-26 12:30:00');
