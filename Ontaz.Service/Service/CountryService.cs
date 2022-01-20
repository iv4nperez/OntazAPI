using Microsoft.EntityFrameworkCore;
using Ontaz.Dal.DBOntaz.Context;
using Ontaz.Service.DTOs.Response;
using Ontaz.Service.InterfaceServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ontaz.Service.Service
{
    public class CountryService : ICountryService
    {
        private readonly APIContext _context;
        public CountryService(APIContext context)
        {
            _context = context; 
        }

        public async Task<List<CountryResponse>> Getcountries()
        {
            try
            {
                var result = await _context.Countries.Select( x => new CountryResponse
                {
                    IdCountry = x.IdCountry,
                    NameCountry = x.NameCountry
                }).ToListAsync();


                return result;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
