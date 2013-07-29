using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PayrollSystem
{    
    class ZKDatabase
    {
        private SqlConnection connection;

        public ZKDatabase(string connectionstring)
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
                        break;

                    case 1045:
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
                return false;
            }
        }

        public List<UnRegisteredUser> SelectEmployee()
        {
            string query = "SELECT * FROM Userinfo";

            List<UnRegisteredUser> unReg = new List<UnRegisteredUser>();
            try
            {
                if (this.OpenConnection() == true)
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader dataReader = cmd.ExecuteReader();

                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        unReg.Add(new UnRegisteredUser
                        {
                            UserID = dataReader.GetInt32(0),
                        });

                    }

                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    this.CloseConnection();
                    return unReg;
                    //return list to be displayed
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return unReg;
        }

        public Employee SelectEmployee(int UserID)
        {
            string query = "SELECT * FROM Userinfo where UserId =" + UserID;

            Employee Emp = new Employee();
            //Open connection
            try
            {
                if (this.OpenConnection() == true)
                {
                    //Create Command
                    SqlCommand cmd = new SqlCommand(query, connection);
                    //Create a data reader and Execute the command
                    SqlDataReader dataReader = cmd.ExecuteReader();

                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        //MessageBox.Show(dataReader.GetInt32(0).ToString());
                        //Emp.Add(new Employee {
                        Emp.UserId = dataReader.GetInt32(0);
                            //);
                    }

                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    this.CloseConnection();
                    return Emp;
                    //return list to be displayed
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return Emp;
        }

        public void EmployeeAttendance(List<Attendance> att)
        {
            string query = "SELECT * FROM CHECKINOUT Where CHECKTIME Like '" + DateTime.Now.Date + "'";
            try
            {
                if (this.OpenConnection() == true)
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        UserAttendaceExist(dataReader.GetInt32(0), dataReader.GetDateTime(1), att);                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UserAttendaceExist(int UserIds, DateTime dt, List<Attendance> att)
        {
            using (var myContext = new EmployeeContext())
            {
                var em = (from s in myContext.Employees where s.UserId == UserIds join m in myContext.Schedules on s.ScheduleId equals m.ScheduleId select new {s.SalaryId, s.UserId, m.TimeIn, m.TimeOut, m.TimeInStart, m.TimeOutEnd}).FirstOrDefault();

                if (em.TimeOut > em.TimeIn)
                {
                    if (UserIds == em.UserId)
                    {
                        if (dt.TimeOfDay <= em.TimeOutEnd && dt.TimeOfDay >= em.TimeInStart)
                        {
                            var eat = (from s in myContext.Attendances where s.UserId == UserIds && s.TimeIn.TimeOfDay == em.TimeIn && s.TimeIn.Date == DateTime.Now.Date select s).FirstOrDefault();
                            eat.TimeOut = dt;
                            myContext.SaveChanges();
                        }
                    }
                    else
                    {
                        //var atn = (from s in myContext.Attendances where s.TimeIn.Date == DateTime.Now.AddDays(-1) && s.UserId == UserIds select s).FirstOrDefault();                        
                        var attend = new Attendance
                        {
                            UserId = UserIds,
                            TimeIn = dt,
                            SalaryId = em.SalaryId
                        };
                    }
                }
                else
                {
                    var atn = (from s in myContext.Attendances where s.TimeIn.Date == DateTime.Now.AddDays(-1) && s.UserId == UserIds select s).FirstOrDefault();
                    if (UserIds == em.UserId)
                    {
                        if (dt.TimeOfDay <= em.TimeOutEnd ||  dt.TimeOfDay <= new TimeSpan(23,59,59))
                        {
                            var eat = (from s in myContext.Attendances where s.UserId == UserIds && s.TimeIn.TimeOfDay == em.TimeIn && s.TimeIn.Date == DateTime.Now.Date select s).FirstOrDefault();
                            eat.TimeOut = dt;
                            myContext.SaveChanges();
                        }
                    }
                    else
                    {
                        //var atn = (from s in myContext.Attendances where s.TimeIn.Date == DateTime.Now.AddDays(-1) && s.UserId == UserIds select s).FirstOrDefault();                        
                        var attend = new Attendance
                        {
                            UserId = UserIds,
                            TimeIn = dt,
                            SalaryId = em.SalaryId
                        };
                    }    
                }
            }
        }


        public List<UnRegisteredUser> ToBeEnrollToPayroll(List<Employee> Employi)
        {
            string query = "SELECT UserID FROM UserInfo";
            List<UnRegisteredUser> unReg = new List<UnRegisteredUser>();
            try
            {
                if (this.OpenConnection() == true)
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        if(!UserIdExist(dataReader.GetInt32(0), Employi))
                        {
                            unReg.Add(new UnRegisteredUser { UserID = dataReader.GetInt32(0)});
                        }
                    }
                }
                return unReg;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return unReg;
        }

        public bool UserIdExist(int UserID, List<Employee> Emps)
        {
            foreach (var EmpUser in Emps)
            {
                if (UserID == EmpUser.UserId)
                {
                    return true;
                }
            }
            return false;
        }

        
    }    
}
