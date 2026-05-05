using System;
using System.Data;
using System.Data.SqlClient;
using SchoolManagementSystem.DAL;
using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.BLL
{
    public static class AuthService
    {
        public static User CurrentUser { get; private set; }

        public static bool Login(string regNoOrEmail, string password, string role)
        {
            string table = role == "Admin" ? "Principal" : (role == "Teacher" ? "Teacher" : "Student");
            string idColumn = role == "Admin" ? "email" : "reg_no";

            string query = $"SELECT * FROM {table} WHERE {idColumn} = @id AND password = @password";
            SqlParameter[] parameters = {
                new SqlParameter("@id", regNoOrEmail),
                new SqlParameter("@password", password)
            };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                if (role == "Admin")
                {
                    CurrentUser = new Principal { Id = (int)row["id"], Name = row["name"].ToString(), Email = row["email"].ToString(), Role = "Admin" };
                }
                else if (role == "Teacher")
                {
                    CurrentUser = new Teacher { Id = (int)row["id"], RegNo = row["reg_no"].ToString(), Name = row["name"].ToString(), Role = "Teacher" };
                }
                else
                {
                    CurrentUser = new Student { Id = (int)row["id"], RegNo = row["reg_no"].ToString(), Name = row["name"].ToString(), Role = "Student" };
                }
                return true;
            }
            return false;
        }

        public static void Logout()
        {
            CurrentUser = null;
        }
    }
}
