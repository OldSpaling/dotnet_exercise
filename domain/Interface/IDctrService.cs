using domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Interface
{
    public interface IDctrService : IBaseService<Dctr>, IDependence
    {
      List<Dctr> GetMeetingPersonByMeetingId(int meetingId);
        List<Dctr> GetMeetingPersonByMeetingIdCount(int meetingId);
    }
}