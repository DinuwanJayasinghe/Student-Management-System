using System;
using System.Data;
using System.Data.SqlClient;
using SchoolManagementSystem.DAL;

namespace SchoolManagementSystem.BLL
{
    public class AttendanceService
    {
        public bool MarkStudentAttendance(int studentId, string status, int teacherId)
        {
            if (!IsWithinAttendanceTime()) return false;

            string query = "INSERT INTO Attendance (student_id, date, status, marked_by) VALUES (@sid, @date, @status, @tid)";
            SqlParameter[] parameters = {
                new SqlParameter("@sid", studentId),
                new SqlParameter("@date", DateTime.Today),
                new SqlParameter("@status", status),
                new SqlParameter("@tid", teacherId)
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool MarkTeacherAttendance(int teacherId)
        {
            if (!IsWithinAttendanceTime()) return false;

            // Check if already marked
            string checkQuery = "SELECT COUNT(*) FROM TeacherAttendance WHERE teacher_id = @tid AND date = @date";
            SqlParameter[] checkParams = {
                new SqlParameter("@tid", teacherId),
                new SqlParameter("@date", DateTime.Today)
            };
            if ((int)DatabaseHelper.ExecuteScalar(checkQuery, checkParams) > 0) return true;

            string query = "INSERT INTO TeacherAttendance (teacher_id, date, status) VALUES (@tid, @date, 'Present')";
            SqlParameter[] parameters = {
                new SqlParameter("@tid", teacherId),
                new SqlParameter("@date", DateTime.Today)
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool IsWithinAttendanceTime()
        {
            DateTime now = DateTime.Now;
            // Before 7:30 AM (Monday-Friday)
            bool isWeekday = now.DayOfWeek != DayOfWeek.Saturday && now.DayOfWeek != DayOfWeek.Sunday;
            bool isBeforeTime = now.TimeOfDay < new TimeSpan(7, 30, 0);
            return isWeekday && isBeforeTime;
        }
    }
}
