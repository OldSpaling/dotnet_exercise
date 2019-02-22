using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Entity
{
	[Table("Test")]
	public class Test: EntityBase
    {
		public string Name { get; set; }
	}
}
