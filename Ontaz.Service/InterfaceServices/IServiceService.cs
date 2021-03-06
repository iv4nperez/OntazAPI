using Ontaz.Service.DTOs.Params;
using Ontaz.Service.helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ontaz.Service.InterfaceServices
{
    public interface IServiceService
    {
        Task<ResponseModel> GetServices(long IdCategory);
        Task<ResponseModel> GetServiceByID(long IdService);
        Task<ResponseModel> GetServiceByIdUser(long IdUser);
        Task<ResponseModel> SaveOrEdit(ServiceParamModel paramModel);
    }
}
