using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Windows.Forms;
using System.ComponentModel;

namespace PayrollSystem
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
        public string Contact { get; set;}
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

    public class EmploymentType
    {
        public int EmploymentTypeId { get; set; }
        public string EmploymentName { get; set; }
    }
    public class Branch
    {
        public int BranchId { get; set; }
        public string BranchName { get; set; }
    }

    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
    }

    public class Position
    {
        public int PositionId { get; set; }
        public string PositionName { get; set; }
    }

    public class Salary
    {
        public int SalaryId { get; set; }
       
        public string SalaryCode { get; set; }
        public double SalaryAmount { get; set; }
    }

    public class Schedule
    {
        public int ScheduleId { get; set; }
        public string ScheduleCode { get; set; }
        public TimeSpan TimeIn { get; set; }
        public TimeSpan TimeInStart { get; set; }
        public TimeSpan TimeOut { get; set; }
        public TimeSpan TimeOutEnd { get; set; }
        public TimeSpan GracefulTime { get; set; }
        
    }

    public class AttendanceType
    {
        public int AttendanceTypeId {get; set;}
        public string Name {get; set;}
    }

    public class Attendance
    {
        public int AttendanceId { get; set; }
        public int UserId { get; set; }
        public int EmployeeId { get; set; }
        public int ScheduleId { get; set; }
        public int SalaryId { get; set; }
        public int AttendanceTypeId { get; set; }
        public DateTime TimeIn { get; set; }
        public DateTime TimeOut { get; set; }
    }

    public class Overtime
    {
        public int OvertimeId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime DateStarted { get; set; }
        public DateTime DateEnd { get; set; }
        public string OvertimeReason { get; set; }
        public DateTime DateCreated { get; set; }
    }
    
    public class Earn
    {
        public int EarnId { get; set; }
        public int EmployeeId { get; set; }
        public int BranchId { get; set; }
        public int DepartmentId { get; set; }
        public int PositionId { get; set; }
        public string EarnName { get; set; }
        public DateTime DateCreated { get; set; }
        public double EarnAmount { get; set; }
    }

    public class Deduct
    {
        public int DeductId { get; set; }
        public int EmployeeId { get; set; }
        public int BranchId { get; set; }
        public int DepartmentId { get; set; }
        public int PositionId { get; set; }
        public string DeductName { get; set; }
        public DateTime DateCreated { get; set; }
        public double DeductAmount { get; set; }
    }

    public class HolidayList
    {
        public int HolidayListID { get; set; }
        public DateTime HolidayDate { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }

    public class Allowance
    {
        public int AllowanceID { get; set; }
        public string Name { get; set; }
        public double Rate { get; set; }
    }


    public class EmployeeContext : DbContext
    {
//        public EmployeeContext(string connectionstring = @"user id=" + settings.userid + ";password=" + settings.password + ";server=" + settings.server + ";Trusted_Connection=yes;database=" + settings.database + ";connection timeout=30";
//)

        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmploymentType> EmploymentTypes { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Salary> Salaries { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<AttendanceType> AttendancesTypes { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Overtime> Overtimes { get; set; }
        public DbSet<Earn> Earns { get; set; }
        public DbSet<Deduct> Deducts { get; set; }
        public DbSet<HolidayList> HL { get; set; }
        public DbSet<Allowance> Allowances { get; set; }

    }
    public class UnRegisteredUser
    {
        public int UserID { get; set; }
    }

    static class Dummy
    {
        public static List<EmploymentType> emType = new List<EmploymentType>();
        public static List<Branch> branch = new List<Branch>();
        public static List<Department> department = new List<Department>();
        public static List<Position> position = new List<Position>();
        public static List<Salary> salary = new List<Salary>();
        //public static List<EmploymentType> employmentType = new List<EmploymentType>();
        public static List<Schedule> schedule = new List<Schedule>();
        public static List<UnRegisteredUser> unregisteredUser = new List<UnRegisteredUser>();
        public static List<Employee> employee = new List<Employee>();

        public static void DummyInitialize()
        {
            using (var myContext = new EmployeeContext())
            {
                var em = from s in myContext.EmploymentTypes select s;
                foreach (var e in em)
                {
                    emType.Add(new EmploymentType { EmploymentTypeId = e.EmploymentTypeId, EmploymentName = e.EmploymentName });
                }

                var br = from s in myContext.Branches select s;
                foreach (var b in br)
                {
                    branch.Add(new Branch { BranchId = b.BranchId, BranchName = b.BranchName });
                }                

                var de = from s in myContext.Departments select s;
                foreach (var d in de)
                {
                    department.Add(new Department { DepartmentId = 1, DepartmentName = "Accounting Department" });
                }

                var po = from s in myContext.Positions select s;
                foreach (var p in po)
                {
                    position.Add(new Position { PositionId = p.PositionId, PositionName = p.PositionName });
                }


                var sa = from s in myContext.Salaries select s;
                foreach (var s in sa)
                {
                    salary.Add(new Salary { SalaryId = s.SalaryId, SalaryCode = s.SalaryCode, SalaryAmount = s.SalaryAmount });
                }

                var sc = from s in myContext.Schedules select s;
                foreach (var s in sc)
                {
                    schedule.Add(new Schedule { ScheduleId = s.ScheduleId, ScheduleCode = s.ScheduleCode, TimeIn = s.TimeIn, TimeOut = s.TimeOut, TimeInStart = s.TimeInStart, TimeOutEnd = s.TimeOutEnd, GracefulTime = s.GracefulTime });
                }
            }

            unregisteredUser.Add(new UnRegisteredUser { UserID = 1 });
            unregisteredUser.Add(new UnRegisteredUser { UserID = 2 });
            unregisteredUser.Add(new UnRegisteredUser { UserID = 3 });
            unregisteredUser.Add(new UnRegisteredUser { UserID = 4 });
        }
    }


    class EmployeeTable
    {
        public List<Employee> EmployeeList = new List<Employee>();

        public List<Employee> Employees()
        {

            EmployeeList.Add(new Employee { UserId = 1, FirstName = "Ivy", LastName = "Bravo", PositionId = 1, DepartmentId = 1, CivilStatus = "Single", NoDependnt = "0", EmploymentTypeId = 1, SalaryId = 1 });
            EmployeeList.Add(new Employee { UserId = 2, FirstName = "Ruben", LastName = "Flores", PositionId = 2, DepartmentId = 2, CivilStatus = "Married", NoDependnt = "1", EmploymentTypeId = 2, SalaryId = 2 });
            EmployeeList.Add(new Employee { UserId = 3, FirstName = "Alexis Calingasan", PositionId = 3, DepartmentId = 3, CivilStatus = "Single", NoDependnt = "1", EmploymentTypeId = 3, SalaryId = 3 });
            EmployeeList.Add(new Employee { UserId = 4, FirstName = "Florida Manahan", PositionId = 3, DepartmentId = 4, CivilStatus = "Widowed", NoDependnt = "0", EmploymentTypeId = 4, SalaryId = 4 });

            return EmployeeList;
        }
    }


    class EmployeeDataGrid
    {
        public void BindGrid(DataGridView dg)
        {
            dg.AutoGenerateColumns = false;
            DataGridViewCell cell = new DataGridViewTextBoxCell();


            DataGridViewTextBoxColumn colUserID = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "UserID",
                HeaderText = "UserID",
                DataPropertyName = "UserID",
                Width = 30

            };

            dg.Columns.Add(colUserID);

            DataGridViewTextBoxColumn colName = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "Name",
                HeaderText = "Name",
                DataPropertyName = "Name",
                Width = 100


            };

            dg.Columns.Add(colName);


            DataGridViewTextBoxColumn colPosition = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "Position",
                HeaderText = "Position",
                DataPropertyName = "Position",
                Width = 75



            };

            dg.Columns.Add(colPosition);

            DataGridViewTextBoxColumn colDepartment = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "Department",
                HeaderText = "Department",
                DataPropertyName = "Department",
                Visible = false



            };

            dg.Columns.Add(colDepartment);

            DataGridViewTextBoxColumn colCivilStatus = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "CivilStatus",
                HeaderText = "CivilStatus",
                DataPropertyName = "CivilStatus",
                Visible = false

            };

            dg.Columns.Add(colCivilStatus);

            DataGridViewTextBoxColumn colnoOfDependents = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "noOfDependents",
                HeaderText = "Dependents",
                DataPropertyName = "noOfDependents",
                Visible = false

            };

            dg.Columns.Add(colnoOfDependents);

            DataGridViewTextBoxColumn colEmployeeType = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "EmployeeType",
                HeaderText = "EmployeeType",
                DataPropertyName = "EmployeeType",
                Visible = false


            };

            dg.Columns.Add(colEmployeeType);

            DataGridViewTextBoxColumn colDailyRate = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "DailyRate",
                HeaderText = "DailyRate",
                DataPropertyName = "DailyRate",
                Visible = false

            };

            dg.Columns.Add(colDailyRate);

            DataGridViewTextBoxColumn colActivation = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "Activation",
                HeaderText = "Activation",
                DataPropertyName = "Activation",
                Visible = false

            };

            dg.Columns.Add(colActivation);

            DataGridViewTextBoxColumn colRender = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "DaysRendered",
                HeaderText = "DaysRendered",
                DataPropertyName = "DaysRendered",
                Visible = false

            };
            dg.Columns.Add(colRender);

            DataGridViewTextBoxColumn colAbsent = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "TotalAbsents",
                HeaderText = "TotalAbsents",
                DataPropertyName = "TotalAbsents",
                Visible = false

            };
            dg.Columns.Add(colAbsent);


            DataGridViewTextBoxColumn colBasicSalary = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "BasicSalary",
                HeaderText = "BasicSalary",
                DataPropertyName = "BasicSalary",
                Visible = false

            };
            dg.Columns.Add(colBasicSalary);



            EmployeeTable et = new EmployeeTable();
            var filelist = et.Employees().ToList();
            var filenamesList = new BindingList<Employee>(filelist);
            dg.DataSource = filenamesList;


        }

        public void BindGrid(DataGridView dg, List<Attendance> Attendans)
        {
            dg.AutoGenerateColumns = false;
            DataGridViewCell cell = new DataGridViewTextBoxCell();

            DataGridViewTextBoxColumn colUserID = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "UserID",
                HeaderText = "File Name",
                DataPropertyName = "UserID"

            };

            dg.Columns.Add(colUserID);

            DataGridViewTextBoxColumn colName = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "Value",
                HeaderText = "File Name",
                DataPropertyName = "TimeIn"

            };

            dg.Columns.Add(colName);

            DataGridViewTextBoxColumn colDepartment = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "Department",
                HeaderText = "Department",
                DataPropertyName = "TimeOut"

            };

            dg.Columns.Add(colDepartment);

            DataGridViewTextBoxColumn colCivilStatus = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "CivilStatus",
                HeaderText = "CivilStatus",
                DataPropertyName = "CivilStatus"

            };

            dg.Columns.Add(colCivilStatus);

            DataGridViewTextBoxColumn colnoOfDependents = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "noOfDependents",
                HeaderText = "Dependents",
                DataPropertyName = "noOfDependents"

            };

            dg.Columns.Add(colnoOfDependents);

            DataGridViewTextBoxColumn colEmployeeType = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "EmployeeType",
                HeaderText = "EmployeeType",
                DataPropertyName = "EmployeeType"

            };

            dg.Columns.Add(colEmployeeType);

            DataGridViewTextBoxColumn colDailyRate = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "DailyRate",
                HeaderText = "DailyRate",
                DataPropertyName = "DailyRate"

            };

            dg.Columns.Add(colDailyRate);

            DataGridViewTextBoxColumn colActivation = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "Activation",
                HeaderText = "Activation",
                DataPropertyName = "Activation"

            };

            dg.Columns.Add(colActivation);

            var filelist = Attendans.ToList();
            var filenamesList = new BindingList<Attendance>(filelist);
            dg.DataSource = filenamesList;

        }
    }   
}
