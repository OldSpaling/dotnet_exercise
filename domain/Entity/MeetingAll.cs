using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Entity
{
    [Table("iDoctor_Data_MeetingAll")]
    public class MeetingAll : EntityBase
    {
        //public string meetingName;
        //public string meetingAddress;
        //public DateTime startTime;
        //public DateTime endTime;
        public static DbConnection conn { get; set; }
        public int SRId { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

    }
}
