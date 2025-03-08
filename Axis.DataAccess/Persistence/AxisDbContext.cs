using Axis.Core.Models;
using Axis.Core.Models.HouseKeeping;
using Axis.Core.Models.HR;
using Axis.Core.Models.HR.Attendance_Leave;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.DataAccess.Persistence
{
    public class AxisDbContext : DbContext, IAxisDbContext
    {
        public AxisDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeAddress> EmployeeAddresses { get; set; }
        public DbSet<JobInformation> JobInformations { get; set; }
        public DbSet<EmployeeFile> EmployeeFiles { get; set; }
        public DbSet<EmpTaxInfo> EmpTaxInfos { get; set; }
        public DbSet<FamilyInfo> FamilyInfos { get; set; }
        public DbSet<WorkExperience> WorkExperiences { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<BankInfo> BankInfo { get; set; }


        //HR
        // HouseKeeping
        public DbSet<Department> Departments { get; set; }
        public DbSet<Designation> Designations { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Line> Lines { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Floor> Floors { get; set; }
        public DbSet<Religion> Religiones { get; set; }
        public DbSet<BloodGroup> BloodGroups { get; set; }
        public DbSet<EmpCertificate> EmpCertificates { get; set; }  
        public DbSet<ContactInfo> ContactInfos { get; set; }

        public DbSet<Holiday> Holidays { get; set; }
        public DbSet<HolidayTemplate> HolidayTemplates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //company
            modelBuilder.Entity<Company>()
                .HasKey(c => c.ComId);



            base.OnModelCreating(modelBuilder);
        }
    }
}
