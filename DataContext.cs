
using Microsoft.EntityFrameworkCore;
using SchoolDataBaseApp.Models;

namespace SchoolDataBaseApp
{
    public class DataContext : DbContext
    {
        public DbSet<StaffModel> Staffs { get; set; }
        public DbSet<DepartmentModel> Departments { get; set; }
        public DbSet<SpecializationStaffModel> Specializations { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
