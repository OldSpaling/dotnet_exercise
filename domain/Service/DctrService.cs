using domain.Entity;
using domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Service
{
    public class DctrService:BaseService<Dctr>, IDctrService
    {
        public DctrService(CustomerDBContext ctx) : base(ctx)
    {
    }
  
        public List<Dctr> GetMeetingPersonByMeetingId(int meetingId)
        {
            var rltnService = new BaseService<MeetingHcps>(ctx);
            var query = from iDoctor_Data_Dctr in Repository
                        join rltn in rltnService.Repository.Where(o => o.MeetingId == meetingId)
                        on iDoctor_Data_Dctr.Id equals rltn.DoctorId
                        select iDoctor_Data_Dctr;
            return query.ToList();
        }
        public List<Dctr> GetMeetingPersonByMeetingIdCount(int meetingId)
        {
            
                var rltnService = new BaseService<MeetingHcps>(ctx);
                var query = from iDoctor_Data_Dctr in Repository
                            join rltn in rltnService.Repository.Where(o => o.MeetingId == meetingId)
                            on iDoctor_Data_Dctr.Id equals rltn.DoctorId
                            select iDoctor_Data_Dctr;
                return query.ToList();
            }
        

    }
}
