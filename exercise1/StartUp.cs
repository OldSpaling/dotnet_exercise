using Autofac;
using AutoMapper;
using domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Web;

namespace exercise1
{
    public class StartUp
    {
        public static void Init()
        {
            InitMapper();
            IOC();
        }
        private static void IOC()
        {
            var builder = new ContainerBuilder();
            DomainStartUp.IOC(builder);
            WebStartup.IOC(builder);
            Factory.Builder= builder.Build();
        }
        private static void InitMapper()
        {
            Mapper.Initialize(config => 
            {
                DomainStartUp.InitMapper(config);
            });
        }
    }
}
