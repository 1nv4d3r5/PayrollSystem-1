using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayrollSystem
{
    public class Populator
    {
        public List<EmploymentType> emType = new List<EmploymentType>();
        public List<Branch> branch = new List<Branch>();
        public List<Department> department = new List<Department>();
        public List<Position> position = new List<Position>();
        public List<Salary> salary = new List<Salary>();
        public List<EmploymentType> employmentType = new List<EmploymentType>();
        public List<Schedule> schedule = new List<Schedule>();
        //public List<UnRegisteredUser> unregisteredUser = new List<UnRegisteredUser>();
        public List<Employee> employee = new List<Employee>();

        public Populator()
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
                    department.Add(new Department { DepartmentId = d.DepartmentId, DepartmentName = d.DepartmentName });
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
        }
    }
}
