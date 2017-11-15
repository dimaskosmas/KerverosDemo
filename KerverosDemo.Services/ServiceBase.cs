using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KerverosDemo.Services
{
    public class ServiceBase<T> where T : IService
    {
        public ServiceBase()
        {
        }
    }
}
