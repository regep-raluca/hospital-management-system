-- Retrieve all patients
SELECT * FROM Patients;

-- Retrieve all doctors
SELECT * FROM Doctors;

-- Retrieve all appointments
SELECT * FROM Appointments;

-- Retrieve appointments for a specific patient
SELECT p.LastName, p.FirstName, d.LastName AS Doctor, a.AppointmentDate
FROM Appointments a
JOIN Patients p ON a.PatientID = p.PatientID
JOIN Doctors d ON a.DoctorID = d.DoctorID
WHERE a.PatientID = 1;
