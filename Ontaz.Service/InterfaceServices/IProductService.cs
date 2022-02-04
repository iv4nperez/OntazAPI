using Ontaz.Service.helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ontaz.Service.InterfaceServices
{
    public interface IProductService
    {
        Task<ResponseModel> GetProductByService(long IdService);
    }
}
