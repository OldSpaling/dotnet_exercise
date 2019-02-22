using domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
namespace domain.Entity
{
	public class TestDTO: IDTO
    {
		public int Id { get; set; }
		public string Name { get; set; }
    }
}
