using Ontaz.Service.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ontaz.Service.InterfaceServices
{
    public interface ICountryService
    {
        Task<List<CountryResponse>> Getcountries();
    }
}
