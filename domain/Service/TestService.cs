using domain.Entity;
using domain.Interface;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Service
{
	public class TestService:BaseService<Test>,ITestService
	{
        public TestService(CustomerDBContext ctx):base(ctx)
        {
        }
        public TestService(DbConnection conn):base(conn)
        {
        }
    }
}
