using Autofac;
using AutoMapper;
using domain.DTO;
using domain.Entity;
using domain.Interface;
using domain.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web;

namespace exercise1
{
	class Program
	{
		static void Main(string[] args)
		{
			
            StartUp.Init();          
            var router = Console.ReadLine();
            switch (router)
            {
                case "/meetinginformation/getall":
                    //IMeetingAllService testService = Factory.CreateInstance<IMeetingAllService>();
                    MeetingAllController meetingAllController1 = Factory.CreateInstance<MeetingAllController>();
                    var meetingList = meetingAllController1.GetAllMeetingInformation(); 
                    meetingList.ForEach(meetingInfo =>
                    {
                        var meetingInfoDTO = Mapper.Map<MeetingAllDTO>(meetingInfo);
                        Console.WriteLine(meetingInfoDTO.Id);
                        Console.WriteLine(meetingInfoDTO.Adress);
                        Console.WriteLine(meetingInfoDTO.Name);
                        Console.WriteLine(meetingInfoDTO.SRId);
                        Console.WriteLine(meetingInfoDTO.StartTime);
                        Console.WriteLine(meetingInfoDTO.EndTime);
                    });
                    break;
                case "/meetinginformation/addmeeting":
                    Console.WriteLine("请依次输入会议名称，会议地点，会议开始时间，会议结束时间，SRId(以空格间隔)");

                    var list1 = Console.ReadLine().Split(' ');
                    var meetingInformation = new MeetingAll
                    {
                        Name = list1[0],
                        Adress = list1[1],
                        StartTime = Convert.ToDateTime(list1[2]),
                        EndTime = Convert.ToDateTime(list1[3]),
                        SRId = Convert.ToInt32(list1[4])
                    };
                    var meetingInformationDTO = Mapper.Map<MeetingAllDTO>(meetingInformation);
                    MeetingAllController meetingAllController2 = Factory.CreateInstance<MeetingAllController>();
                    var Createmeeting = meetingAllController2.Create(meetingInformationDTO); 
                    Console.WriteLine("MeetingName:{0},MeetingAdress:{1},StartTime:{2},EndTime:{3},SRId:{4}", meetingInformationDTO.Name, meetingInformationDTO.Adress, meetingInformationDTO.StartTime, meetingInformationDTO.EndTime, meetingInformationDTO.SRId);
                    break;
                case "/meetinginformation/getbysrid":
                    MeetingAllController meetingAllController3 = Factory.CreateInstance<MeetingAllController>();
                    Console.WriteLine("请输入对应会议的SRID");
                    var meetingId = Console.ReadLine();
                    var id = Convert.ToInt32(meetingId);
                    var meetingList1 = meetingAllController3.GetMeetingInformationBySRId(id);    
                    meetingList1.ForEach(meetingInforBySRId =>
                    {
                        var meetingInfoDTO = Mapper.Map<MeetingAllDTO>(meetingInforBySRId);

                        Console.WriteLine("Id:{0},MeetingName:{1},MeetingAdress{2},StartTime{3},EndTime{4},SRId{5}", meetingInfoDTO.Id, meetingInfoDTO.Name, meetingInfoDTO.Adress, meetingInfoDTO.StartTime, meetingInfoDTO.EndTime, meetingInfoDTO.SRId);
                    });
                    break;
                case "/meetinginformation/getbydoctorid":
                    MeetingAllController meetingAllController4 = Factory.CreateInstance<MeetingAllController>();
                   
                    Console.WriteLine("请输入对应会议的DOCID");
                    var doctorId = Console.ReadLine();
                    var docId = Convert.ToInt32(doctorId);
                    var meetingList2 = meetingAllController4.GetMeetingInformationsByDoctorId(docId);
                    meetingList2.ForEach(meetingInforByDoctorId =>
                    {
                        var meetingInfoDTO = Mapper.Map<MeetingAllDTO>(meetingInforByDoctorId);
                        Console.WriteLine("Id:{0},MeetingName:{1},MeetingAdress{2},StartTime{3},EndTime{4},SRId{5}", meetingInfoDTO.Id, meetingInfoDTO.Name, meetingInfoDTO.Adress, meetingInfoDTO.StartTime, meetingInfoDTO.EndTime, meetingInfoDTO.SRId);
                    });
                    break;
                case "/meetinginformation/getbymeetingid":
                    DctrController dctrController = Factory.CreateInstance<DctrController>();
                    Console.WriteLine("请输入对应Doctor的会议的Id");
                    var meetinginfoId = Console.ReadLine();
                    var meetId = Convert.ToInt32(meetinginfoId);
                    var dctrList1 = dctrController.GetMeetingPersonByMeetingId(meetId);
                    dctrList1.ForEach(meetingInforByMeetingId =>
                    {
                        var dctrDTO = Mapper.Map<Dctr>(meetingInforByMeetingId);
                        Console.WriteLine("Id:{0},DocName:{1},DocPhone{2},DocAddress{3},DocDepartment{4},DocGender{5}", dctrDTO.Id, dctrDTO.Name, dctrDTO.Phone, dctrDTO.Address, dctrDTO.Department, dctrDTO.Gender);
                    });
                    break;
                case "/meetinginformation/getbymeetingidandcount":
                    Console.WriteLine("请输入对应Doctor的会议的Id");
                    DctrController dctrController2 = Factory.CreateInstance<DctrController>();
                    var meetinginforId = Console.ReadLine();
                    var meetTingId = Convert.ToInt32(meetinginforId);
                    int count = 0;
                    var dctrList2 = dctrController2.GetMeetingPersonByMeetingId(meetTingId);
                    dctrList2.ForEach(meetingInforByMeetingId =>
                    {
                        count++;
                    });
                    Console.WriteLine("参会人员的数量是:{0}", count);
                    break;
                default:
                    throw new Exception("illeagal arguments");
            }
        }
	}
	public class Class
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int StudentNO { get; set; }
		public string Chief { get; set; }
		public bool IsDeleted { get; set; }
	}
}
