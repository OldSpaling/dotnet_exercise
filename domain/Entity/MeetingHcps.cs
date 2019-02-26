using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Entity
{
    [Table("iDoctor_Data_MeetingHcps")]
    public class MeetingHcps : EntityBase
    {


        public int MeetingId { get; set; }
        public int DoctorId { get; set; }

    }
}
