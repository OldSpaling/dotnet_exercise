using domain.DTO;
using domain.Entity;
using domain.Interface;
using domain.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web
{
    public class DctrController
    {
       
        private IDctrService _dctrService;

        public DctrController()
        {
        }

        public DctrController(IDctrService dctrService)
        {
            _dctrService = dctrService;
        }
        public List<Dctr> GetMeetingPersonByMeetingId(int meetingId)
        {
            {            
                return _dctrService.GetMeetingPersonByMeetingId(meetingId);
            }
        }
        public List<Dctr> GetMeetingPersonByMeetingIdCount(int meetingId)
        {
            {
                return _dctrService.GetMeetingPersonByMeetingIdCount(meetingId);
            }
        }
        //public List<Dctr> GetMeetingPersonByMeetingIdCount(int meetingId)
        //{
        //    {
        //        var doctorService = new DctrService();
        //        return doctorService.GetMeetingPersonByMeetingIdCount(meetingId);
        //    }
        //}
        //public List<DctrDTO> GetAll()
        //{
        //    return _dctrService.GetList<DctrDTO>();
        //}

        //public int Create(TestDTO model)
        //{
        //    return _dctrService.Create(model);
        //}

    }
}