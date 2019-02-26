using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.DTO
{
    public class MeetingHcpsDTO : IDTO
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public int MeetingId { get; set; }
        public int DoctorId { get; set; }
    }
}
