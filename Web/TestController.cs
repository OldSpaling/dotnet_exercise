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
	public class TestController
	{
        private ITestService _testService;

        public TestController(ITestService testService)
        {
            _testService = testService;
        }

        public TestController()
        {
        }

        public List<TestDTO> GetAll()
		{
			return _testService.GetList<TestDTO>();
		}
		public int Create(TestDTO model)
		{
			return _testService.Create(model);
		}
	}
}
