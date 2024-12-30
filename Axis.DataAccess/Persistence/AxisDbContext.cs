using Axis.Core.Models.HR;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
