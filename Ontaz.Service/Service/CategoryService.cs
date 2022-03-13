using Microsoft.EntityFrameworkCore;
using Ontaz.Dal.DBOntaz.Context;
using Ontaz.Dal.DBOntaz.Model;
using Ontaz.Service.helpers;
using Ontaz.Service.InterfaceServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ontaz.Service.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly APIContext _context;
        public CategoryService(APIContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel> GetCategories(bool AddPromotions)
        {
            var result = new ResponseModel();

            try
            {
                var categories = await _context.Categories
                    .Where(x => x.RegDeleted == false)
                    .ToListAsync();

                if (!AddPromotions)
                {
                    categories = categories.Where(x => x.IdCategory != 1).ToList();
                }

                result.Data = categories;
                result.Success = true;
                result.StatusCode = 200;

            }
            catch (Exception ex)
            {
                result.Messsage = ex.Message;
            }

            return result;
        }
    }
}
