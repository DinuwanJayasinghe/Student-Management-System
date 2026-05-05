-- =========================================
-- DATABASE SETUP
-- =========================================
CREATE DATABASE SchoolManagementDB;
GO

USE SchoolManagementDB;
GO

-- =========================================
-- PARENT TABLE
-- =========================================
CREATE TABLE Parent (
    id INT IDENTITY(1,1) PRIMARY KEY,
    name NVARCHAR(100),
    contact_number NVARCHAR(15),
    occupation NVARCHAR(100)
);
GO

-- =========================================
-- PRINCIPAL TABLE
-- =========================================
CREATE TABLE Principal (
    id INT IDENTITY(1,1) PRIMARY KEY,
    name NVARCHAR(100),
    email NVARCHAR(100),
    password NVARCHAR(100) DEFAULT 'admin123',
    role NVARCHAR(20) DEFAULT 'Admin'
);
GO

-- =========================================
-- TEACHER TABLE
-- =========================================
CREATE TABLE Teacher (
    id INT IDENTITY(1,1) PRIMARY KEY,
    reg_no AS ('TCH-' + RIGHT('0000' + CAST(id AS VARCHAR), 4)) PERSISTED,
    name NVARCHAR(100),
    email NVARCHAR(100),
    mobile NVARCHAR(15),
    subject NVARCHAR(50),
    password NVARCHAR(100) DEFAULT 'teacher123',
    role NVARCHAR(20) DEFAULT 'Teacher'
);
GO

-- =========================================
-- CLASS TABLE
-- =========================================
CREATE TABLE Class (
    id INT IDENTITY(1,1) PRIMARY KEY,
    name NVARCHAR(50),
    class_teacher_id INT,
    FOREIGN KEY (class_teacher_id) REFERENCES Teacher(id)
);
GO

-- =========================================
-- STUDENT TABLE
-- =========================================
CREATE TABLE Student (
    id INT IDENTITY(1,1) PRIMARY KEY,
    reg_no AS ('STU-' + RIGHT('0000' + CAST(id AS VARCHAR), 4)) PERSISTED,
    name NVARCHAR(100),
    birthday DATE,
    class_id INT,
    address NVARCHAR(200),
    mobile NVARCHAR(15),
    parent_id INT,
    password NVARCHAR(100) DEFAULT 'student123',
    role NVARCHAR(20) DEFAULT 'Student',
    created_at DATETIME DEFAULT GETDATE(),

    FOREIGN KEY (class_id) REFERENCES Class(id),
    FOREIGN KEY (parent_id) REFERENCES Parent(id)
);
GO

-- =========================================
-- ATTENDANCE TABLE (Students)
-- =========================================
CREATE TABLE Attendance (
    id INT IDENTITY(1,1) PRIMARY KEY,
    student_id INT,
    date DATE,
    status NVARCHAR(10), -- 'Present', 'Absent'
    marked_by INT,
    created_time DATETIME DEFAULT GETDATE(),

    FOREIGN KEY (student_id) REFERENCES Student(id),
    FOREIGN KEY (marked_by) REFERENCES Teacher(id)
);
GO

-- =========================================
-- TEACHER ATTENDANCE TABLE
-- =========================================
CREATE TABLE TeacherAttendance (
    id INT IDENTITY(1,1) PRIMARY KEY,
    teacher_id INT,
    date DATE,
    status NVARCHAR(10), -- 'Present'
    marked_time DATETIME DEFAULT GETDATE(),

    FOREIGN KEY (teacher_id) REFERENCES Teacher(id)
);
GO

-- =========================================
-- SAMPLE DATA
-- =========================================

-- Principal
INSERT INTO Principal (name,email) VALUES
('Mr. Silva','silva@school.lk'),
('Mrs. Perera','perera@school.lk');

-- Parent
INSERT INTO Parent (name,contact_number,occupation) VALUES
('Nimal Perera','0711111111','Engineer'),
('Kamal Silva','0712222222','Teacher');

-- Teacher
INSERT INTO Teacher (name,email,mobile,subject) VALUES
('Kasun Perera','kasun@school.lk','0771111111','Math'),
('Ishara Silva','ishara@school.lk','0772222222','Science');

-- Class
INSERT INTO Class (name,class_teacher_id) VALUES
('Grade 6 A',1),
('Grade 6 B',2);

-- Student
INSERT INTO Student (name,birthday,class_id,address,mobile,parent_id) VALUES
('Kavindu Perera','2011-05-10',1,'Colombo','0751111111',1),
('Nethmi Silva','2011-06-11',2,'Gampaha','0752222222',2);

GO

-- =========================================
-- VIEWS
-- =========================================
CREATE VIEW vw_FullStudentDetails AS
SELECT
    s.reg_no,
    s.name AS student_name,
    c.name AS class_name,
    p.name AS parent_name,
    p.contact_number,
    s.mobile,
    s.address
FROM Student s
JOIN Class c ON s.class_id = c.id
JOIN Parent p ON s.parent_id = p.id;
GO

CREATE VIEW vw_StudentContacts AS
SELECT name, mobile FROM Student;
GO
