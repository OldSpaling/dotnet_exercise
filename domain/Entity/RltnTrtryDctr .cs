using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Entity
{
    [Table("iDoctor_Data_RltnTrtryDctr")]
    public class SR_Doctor : EntityBase
    {

        public int SRId { get; set; }
        public int DocId { get; set; }
    }
}
