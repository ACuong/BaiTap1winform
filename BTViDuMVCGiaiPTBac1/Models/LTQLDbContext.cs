using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace BTViDuMVCGiaiPTBac1.Models
{
    public partial class LTQLDbContext : DbContext
    {
        public LTQLDbContext()
            : base("name=LTQLDbContext")
        {
        }

        public virtual DbSet<Person> Persons { get;set; }
        public virtual DbSet<Employee> Employees { get;set; }

        internal void DeleteObject(Func<string, ActionResult> delete)
        {
            throw new NotImplementedException();
        }

    }
}
