using System.Data;
using SchoolManagementSystem.DAL;

namespace SchoolManagementSystem.BLL
{
    public class ReportService
    {
        public DataTable GetFullStudentReport()
        {
            return DatabaseHelper.ExecuteQuery("SELECT * FROM vw_FullStudentDetails");
        }

        public DataTable GetContactList()
        {
            return DatabaseHelper.ExecuteQuery("SELECT * FROM vw_StudentContacts");
        }
    }
}
