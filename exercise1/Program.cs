using Autofac;
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
			//var router = args[0];
			//switch (router)
			//{
			//	case "/test/getall":
			//		new TestController().GetAll();
			//		break;
			//	default:
			//		throw new Exception("illeagal arguments");
			//}
            StartUp.Init();
            ITestService testService = Factory.CreateInstance<ITestService>();
            TestController testController = Factory.CreateInstance<TestController>();
            var tests = testService.GetList<TestDTO>();
            var test2 = testController.GetAll();
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
