using domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Interface
{

    public interface IMeetingAllService : IBaseService<MeetingAll>, IDependence
    {
        List<MeetingAll> GetMeetingInformationBySRId(int srId);
        List<MeetingAll> GetMeetingInformationsByDoctorId(int docId);
    }
}
