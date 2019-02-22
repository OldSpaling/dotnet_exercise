using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Web
{
    public class WebStartup
    {
        public static void IOC(ContainerBuilder builder)
        {
            var test = builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(t => t.Name.EndsWith("Controller")).AsSelf().InstancePerLifetimeScope();
        }
    }
}
