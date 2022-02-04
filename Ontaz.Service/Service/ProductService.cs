using Microsoft.EntityFrameworkCore;
using Ontaz.Dal.DBOntaz.Context;
using Ontaz.Service.helpers;
using Ontaz.Service.InterfaceServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ontaz.Service.Service
{
    public class ProductService : IProductService
    {
        private readonly APIContext _context;
        public ProductService(APIContext context)
        {
            _context = context;
        }


        public async Task<ResponseModel> GetProductByService(long IdService)
        {
            var result = new ResponseModel();
            try
            {
                var response = await _context.Products
                        .Where(x => x.IdService == IdService && x.RegDeleted == false)
                        .ToListAsync();

                result.Data = response;
            }
            catch (Exception)
            {

                throw;
            }

            return result;
        }
    }
}
