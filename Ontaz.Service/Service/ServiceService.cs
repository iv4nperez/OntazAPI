using Microsoft.EntityFrameworkCore;
using Ontaz.Dal.DBOntaz.Context;
using Ontaz.Dal.DBOntaz.Model;
using Ontaz.Service.DTOs.Params;
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


        public async Task<ResponseModel> GetServiceByID(long IdService)
        {
            var result = new ResponseModel();

            try
            {
                var service = await _context.VwServicesDetails
                    .Where(x => x.IdService == IdService && x.RegDeleted == false && x.VerifiedService == true)
                    .Select( x => new ServiceResponse
                    {
                        IdService = x.IdService,
                        IdCategory = x.IdCategory ?? 0,
                        DescriptionService = x.DescriptionService ?? "",
                        DiscountService = x.DiscountService ?? 0,
                        HomeService = x.HomeService ?? false,
                        ImageService = x.ImageService ?? "",
                        NameService = x.NameService ?? "",
                        InternationalCode = x.InternationalCode ?? "",
                        Latitud = x.Latitud ?? 0.0,
                        Longitud = x.Longitud ?? 0.0,
                        PhoneService = x.PhoneService ?? "",
                        VerifiedService = x.VerifiedService ?? false,
                        Raiting = x.Raiting!.Value,
                        WhatsappService = x.WhatsappService ?? ""

                    })
                    .SingleAsync();

                result = new ResponseModel()
                {
                    Data= service,
                    StatusCode = 200,
                    Success= true
                };
            }
            catch (Exception ex)
            {

                throw;
            }
            return result;
        }

        public async Task<ResponseModel> GetServiceByIdUser(long IdUser)
        {
            var result = new ResponseModel();

            try
            {
                var service = await _context.VwServicesDetails
                    .Where(x => x.IdUser == IdUser && x.RegDeleted == false)
                    .Select(x => new ServiceResponse
                    {
                        IdService = x.IdService,
                        IdCategory = x.IdCategory ?? 0,
                        DescriptionService = x.DescriptionService ?? "",
                        DiscountService = x.DiscountService ?? 0,
                        HomeService = x.HomeService ?? false,
                        ImageService = x.ImageService ?? "",
                        NameService = x.NameService ?? "",
                        InternationalCode = x.InternationalCode ?? "",
                        Latitud = x.Latitud ?? 0.0,
                        Longitud = x.Longitud ?? 0.0,
                        PhoneService = x.PhoneService ?? "",
                        VerifiedService = x.VerifiedService ?? false,
                        Raiting = x.Raiting!.Value,
                        WhatsappService = x.WhatsappService ?? ""
                    })
                    .ToListAsync();

                result = new ResponseModel()
                {
                    Data = service,
                    StatusCode = 200,
                    Success = true
                };
            }
            catch (Exception ex)
            {

                throw;
            }
            return result;
        }
    
        public async Task<ResponseModel> SaveOrEdit(ServiceParamModel paramModel)
        {
            var result = new ResponseModel();

            try
            {
                if (paramModel.IdService > 0)
                {

                }
                else
                {
                    var service = new ServiceCommerce()
                    {
                        IdUser = paramModel.IdUser,
                        DescriptionService = paramModel.DescriptionService,
                        NameService = paramModel.NameService,
                        DiscountService = paramModel.DiscountService,
                        HomeService = paramModel.HomeService,
                        IdCategory = paramModel.IdCategory,
                        ImageService = "",
                        InternationalCode = "+52",
                        Latitud = paramModel.Latitud,
                        Longitud = paramModel.Longitud,
                        PhoneService = paramModel.PhoneService,
                        RegDeleted = false,
                        VerifiedService = false,
                        WhatsappService = paramModel.WhatsappService
                    };

                    _context.Entry(service).State = EntityState.Added;
                    await _context.SaveChangesAsync();

                    result.StatusCode = 200;
                    result.Messsage = "Registro guardado correctamente";
                    result.Success = true;
                }
            }
            catch (Exception ex)
            {
                result.Messsage = ex.Message;
            }

            return result;
        }
    }
}
