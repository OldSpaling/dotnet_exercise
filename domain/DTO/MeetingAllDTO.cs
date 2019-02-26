using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.DTO
{
    public class MeetingAllDTO : IDTO
    {
        public int SRId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
