using Ontaz.Dal.DBOntaz.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ontaz.Service.Service
{
    public class ServiceService
    {
        private readonly APIContext _context;
        public ServiceService(APIContext context)
        {
            _context = context;
        }

        public async Task GetServices()
        {

        }
    }
}
