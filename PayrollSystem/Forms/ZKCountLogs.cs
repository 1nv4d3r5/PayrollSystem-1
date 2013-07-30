using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Entity;
using PayrollSystem;

namespace ActiveZKReader
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public int UserId { get; set; }
        public int SalaryId { get; set; }
        public int ScheduleId { get; set; }
        public int BranchId { get; set; }
        public int DepartmentId { get; set; }
        public int PositionId { get; set; }
        public int EmploymentTypeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string CivilStatus { get; set; }
        public string NoDependnt { get; set; }
        public string Address { get; set; }
        public byte[] EmployeePic { get; set; }
        public string Tin { get; set; }
        public string SSS { get; set; }
        public string PhilHealth { get; set; }
        public string Pagibig { get; set; }
    }

    public class CountAttendance
    {
        public int UserID { get; set; }
        public int LogCount { get; set; }
    }

    public class ZKPayroll : DbContext
    {
        public ZKPayroll(string connectionstring)
            : base(connectionstring)
        {

        }

        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }

    class Payroll
    {
        public List<CountAttendance> PayrollAttendance(DateTime Start, DateTime End, int UserID, string connectionstring)
        {
            ConnectDatabase CD = new ConnectDatabase(connectionstring);

            List<CountAttendance> Att = new List<CountAttendance>();
            using (var myContext = new ZKPayroll(connectionstring))
            {
                var CheckMe = from s in myContext.Employees where s.UserId == UserID select s;
                foreach (var att in CheckMe)
                {
                    int count = CD.PayrollCountAttendance(Start, End, att.UserId);
                    Att.Add(new CountAttendance { UserID = att.UserId, LogCount = count });
                }
            }
            return Att;

        }

    }

    class ConnectDatabase
    {
        private SqlConnection connection;

        public ConnectDatabase(string connectionstring)
        {
            Initialize(connectionstring);
        }

        private void Initialize(string connectionsting)
        {
            connection = new SqlConnection(connectionsting);
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        //MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        //                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message);
                return false;
            }
        }

        public int PayrollCountAttendance(DateTime Start, DateTime End, int UserID)
        {
            Start = Start.Add(new TimeSpan(00, 00, 00));
            End = End.Add(new TimeSpan(23, 59, 59));
            List<CountAttendance> CA = new List<CountAttendance>();
            string SQLquery = "SELECT count(*) from CHECKINOUT where USERID = '" + UserID + "' and CHECKTIME between '" + Start + "' and '" + End + "';";
            int NumOfLogs = -1;
            try
            {
                if (OpenConnection() == true)
                {
                    SqlCommand cmd = new SqlCommand(SQLquery, connection);
                    NumOfLogs = int.Parse(cmd.ExecuteScalar() + "");
                    this.CloseConnection();
                    return NumOfLogs;
                }
            }
            catch (Exception ex) { }
            return NumOfLogs;
        }
    }

}
