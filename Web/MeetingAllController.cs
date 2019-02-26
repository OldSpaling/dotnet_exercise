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
    public class MeetingAllController
    {
        //private MeetingAllService meetingInformationService = new MeetingAllService();

        //public List<MeetingAll> GetAllMeetingInformation()
        //{
        //    return meetingInformationService.GetList();
        //}
        //public int Create(MeetingAll model)
        //{
        //    return meetingInformationService.Create(model);
        //}
        //public List<MeetingAll> GetMeetingInformationBySRId(int srId)
        //{

        //    return meetingInformationService.GetMeetingInformationBySRId(srId);
        //}

        //public List<MeetingAll> GetMeetingInformationsByDoctorId(int docId)
        //{
        //    {
        //        return meetingInformationService.GetMeetingInformationsByDoctorId(docId);
        //    }

        //}
        private IMeetingAllService _meetingAllService;
        public MeetingAllController(IMeetingAllService meetingAllService)
        {
            _meetingAllService = meetingAllService;
        }
        public List<MeetingAllDTO> GetAllMeetingInformation()
        {
            return _meetingAllService.GetList<MeetingAllDTO>();
        }
        //public List<MeetingAllDTO> GetAll()
        //{
        //    return _meetingAllService.GetList<MeetingAllDTO>();
        //}
        public int Create(MeetingAllDTO model)
        {
            return _meetingAllService.Create(model);
        }
        public List<MeetingAll> GetMeetingInformationBySRId(int srId)
        {

            return _meetingAllService.GetMeetingInformationBySRId(srId);
        }
        public List<MeetingAll> GetMeetingInformationsByDoctorId(int docId)
        {
            {
                return _meetingAllService.GetMeetingInformationsByDoctorId(docId);
            }
        }
    }
}

