using System;

namespace SchoolManagementSystem.Models
{
    public abstract class User
    {
        public int Id { get; set; }
        public string RegNo { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }

    public class Principal : User { }

    public class Teacher : User
    {
        public string Mobile { get; set; }
        public string Subject { get; set; }
    }

    public class Student : User
    {
        public DateTime Birthday { get; set; }
        public int ClassId { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public int ParentId { get; set; }
    }

    public class Parent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public string Occupation { get; set; }
    }

    public class Class
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ClassTeacherId { get; set; }
    }

    public class Attendance
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public int MarkedBy { get; set; }
    }
}
