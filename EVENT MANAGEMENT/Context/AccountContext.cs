using EVENT_MANAGEMENT.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVENT_MANAGEMENT.Context
{
    class AccountContext:DbContext
    {
        public AccountContext()
                : base("name=AccountContext")
        {
        }
        public virtual DbSet<Category> Categorys { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<EventCategory> EventCategories { get; set; }
        public virtual DbSet<Judges> Judgeses { get; set; }
        public virtual DbSet<UserLogin> UserLogins { get; set; }
        public virtual DbSet<Qualification> Qualifications { get; set; }
        public virtual DbSet<Register> Registers { get; set; }
        public virtual DbSet<Result> Results { get; set; }
        public virtual DbSet<School> Schools { get; set; }
        public virtual DbSet<QualificationCategory> QualificationCategorys { get; set; }

    }

}
