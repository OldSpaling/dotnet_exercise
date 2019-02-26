using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Entity
{
    [Table("iDoctor_Data_SalesOrgChart")]
    public class SalesOrgChart : EntityBase
    {

        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
