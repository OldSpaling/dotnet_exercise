using domain.Entity;
using domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Service
{
    public class MeetingAllService : BaseService<MeetingAll>, IMeetingAllService
    {
        public MeetingAllService(CustomerDBContext ctx) : base(ctx)
        {
        }
        public List<MeetingAll> GetMeetingInformationBySRId(int srId)
        {
            var meetingInformation = new MeetingAll();
            var query = from iDoctor_Data_MeetingAll in Repository
                        .Where(o => o.SRId == srId)
                        select iDoctor_Data_MeetingAll;
            return query.ToList();
        }
        public List<MeetingAll> GetMeetingInformationsByDoctorId(int docId)
        {
            {
                var rltnService = new BaseService<MeetingHcps>(ctx);
                var query = from iDoctor_Data_MeetingAll in Repository
                            join rltn in rltnService.Repository.Where(o => o.DoctorId == docId)
                            on iDoctor_Data_MeetingAll.Id equals rltn.MeetingId
                            select iDoctor_Data_MeetingAll;
                return query.ToList();
            }
        }
    }
}
