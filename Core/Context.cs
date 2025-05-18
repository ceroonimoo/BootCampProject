using Entity;
using System.Collections.Generic;
using System.Data.Entity;

namespace Core
{
    public class Context:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<Blacklist> Blacklists { get; set; }


    }
}