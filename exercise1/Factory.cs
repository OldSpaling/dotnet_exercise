using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    public static class Factory
    {
        public static IContainer Builder { get; set; }
        public static T CreateInstance<T>()
        {
            return Builder.Resolve<T>();
        }
    }
}
