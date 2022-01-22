using Microsoft.EntityFrameworkCore;
using Ontaz.Dal.DBOntaz.Context;
using Ontaz.Service.DTOs.Response;
using Ontaz.Service.helpers;
using Ontaz.Service.InterfaceServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ontaz.Service.Service
{
    public class ServiceService : IServiceService
    {
        private readonly APIContext _context;
        public ServiceService(APIContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel> GetServices(long IdCategory)
        {
            var result = new ResponseModel();

            try
            {
                var services = await _context.VwServices
                    .Where(x => x.IdCategory == IdCategory)
                    .Select( x => new ServiceListResponse {
                        IdService = x.IdService,
                        ImageService = x.ImageService ?? "",
                        NameService = x.NameService ?? "",
                        DescriptionService = x.DescriptionService ?? "",
                        DiscountService = x.DiscountService ?? 0,
                        Raiting = x.Raiting,
                    })
                    .ToListAsync();

                result = new ResponseModel()
                {
                    Data = services,
                    StatusCode = 200,
                    Success = true
                };


            }
            catch (Exception ex)
            {

              result.StatusCode = 500;
            }


            return result; 
        }
    }
}
