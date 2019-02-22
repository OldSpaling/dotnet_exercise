using Autofac;
using AutoMapper;
using domain;
using domain.DTO;
using domain.Entity;
using domain.Interface;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    public class DomainStartUp
    {
        public static void IOC(ContainerBuilder builder)
        {
            builder.RegisterType<CustomerDBContext>().AsSelf();
            //注入这个会引起多构造歧义异常
            //builder.RegisterType<DbConnection>().AsSelf();
            //.InstancePerRequest();
            var types = builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(t => t.IsClass && typeof(IDependence).IsAssignableFrom(t))
                .AsImplementedInterfaces().InstancePerLifetimeScope();
        }
        public static void InitMapper(IMapperConfigurationExpression config)
        {
            var types = Assembly.GetExecutingAssembly().GetTypes();
            var dtoTypes=types.Where(o => o.IsClass && typeof(IDTO).IsAssignableFrom(o));
            var enityTypes = types.Where(o => o.IsClass && typeof(EntityBase).IsAssignableFrom(o));
            //Mapper.Initialize(config => {
            foreach(var tDTO in dtoTypes)
            {
                var tEntity = enityTypes.FirstOrDefault(o => o.Name.Equals(tDTO.Name.Substring(0, tDTO.Name.Length - 3)));
                if (tEntity != null)
                {
                    config.CreateMap(tEntity, tDTO);
                    config.CreateMap(tDTO, tEntity);
                }
            }
            //});
        }
    }
}
