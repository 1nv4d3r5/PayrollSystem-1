namespace PayrollSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        SalaryId = c.Int(nullable: false),
                        ScheduleId = c.Int(nullable: false),
                        BranchId = c.Int(nullable: false),
                        DepartmentId = c.Int(nullable: false),
                        PositionId = c.Int(nullable: false),
                        EmploymentTypeId = c.Int(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Contact = c.String(),
                        Email = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        Gender = c.String(),
                        CivilStatus = c.String(),
                        Address = c.String(),
                        EmployeePic = c.Binary(),
                        Tin = c.String(),
                        SSS = c.String(),
                        PhilHealth = c.String(),
                        Pagibig = c.String(),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
            CreateTable(
                "dbo.EmploymentTypes",
                c => new
                    {
                        EmploymentTypeId = c.Int(nullable: false, identity: true),
                        EmploymentName = c.String(),
                    })
                .PrimaryKey(t => t.EmploymentTypeId);
            
            CreateTable(
                "dbo.Branches",
                c => new
                    {
                        BranchId = c.Int(nullable: false, identity: true),
                        BranchName = c.String(),
                    })
                .PrimaryKey(t => t.BranchId);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepartmentId = c.Int(nullable: false, identity: true),
                        DepartmentName = c.String(),
                    })
                .PrimaryKey(t => t.DepartmentId);
            
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        PositionId = c.Int(nullable: false, identity: true),
                        PositionName = c.String(),
                    })
                .PrimaryKey(t => t.PositionId);
            
            CreateTable(
                "dbo.Salaries",
                c => new
                    {
                        SalaryId = c.Int(nullable: false, identity: true),
                        SalaryAmount = c.Double(nullable: false),
                        SalaryCode = c.String(),
                    })
                .PrimaryKey(t => t.SalaryId);
            
            CreateTable(
                "dbo.Schedules",
                c => new
                    {
                        ScheduleId = c.Int(nullable: false, identity: true),
                        TimeIn = c.Time(nullable: false),
                        TimeInStart = c.Time(nullable: false),
                        TimeOut = c.Time(nullable: false),
                        TimeOutEnd = c.Time(nullable: false),
                        GracefulTime = c.Time(nullable: false),
                        ScheduleCode = c.String(),
                    })
                .PrimaryKey(t => t.ScheduleId);
            
            CreateTable(
                "dbo.AttendanceTypes",
                c => new
                    {
                        AttendanceTypeId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.AttendanceTypeId);
            
            CreateTable(
                "dbo.Attendances",
                c => new
                    {
                        AttendanceId = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        ScheduleId = c.Int(nullable: false),
                        SalaryId = c.Int(nullable: false),
                        AttendanceTypeId = c.Int(nullable: false),
                        TimeIn = c.DateTime(nullable: false),
                        TimeOut = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AttendanceId);
            
            CreateTable(
                "dbo.Overtimes",
                c => new
                    {
                        OvertimeId = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        DateStarted = c.DateTime(nullable: false),
                        DateEnd = c.DateTime(nullable: false),
                        OvertimeReason = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.OvertimeId);
            
            CreateTable(
                "dbo.Earns",
                c => new
                    {
                        EarnId = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        BranchId = c.Int(nullable: false),
                        DepartmentId = c.Int(nullable: false),
                        PositionId = c.Int(nullable: false),
                        EarnName = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        EarnAmount = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.EarnId);
            
            CreateTable(
                "dbo.Deducts",
                c => new
                    {
                        DeductId = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        BranchId = c.Int(nullable: false),
                        DepartmentId = c.Int(nullable: false),
                        PositionId = c.Int(nullable: false),
                        DeductName = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        DeductAmount = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.DeductId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Deducts");
            DropTable("dbo.Earns");
            DropTable("dbo.Overtimes");
            DropTable("dbo.Attendances");
            DropTable("dbo.AttendanceTypes");
            DropTable("dbo.Schedules");
            DropTable("dbo.Salaries");
            DropTable("dbo.Positions");
            DropTable("dbo.Departments");
            DropTable("dbo.Branches");
            DropTable("dbo.EmploymentTypes");
            DropTable("dbo.Employees");
        }
    }
}
