using domain.Entity;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain
{
	public class CustomerDBContext:DbContext
    {
		public CustomerDBContext() : base("connection")
		{
        }
        public CustomerDBContext(DbConnection conn) : base(conn, false)
        {

        }
		public DbSet<Test> Tests { get; set; }
        public DbSet<MeetingAll> MeetingInformations { get; set; }
        public DbSet<SalesOrgChart> SRs { get; set; }
        public DbSet<MeetingHcps> MeetingPersons { get; set; }
        public DbSet<Dctr> Doctors { get; set; }
    }
}
