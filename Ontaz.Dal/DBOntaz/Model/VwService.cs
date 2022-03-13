using System;
using System.Collections.Generic;

namespace Ontaz.Dal.DBOntaz.Model
{
    public partial class VwService
    {
        public long IdService { get; set; }
        public long? IdUser { get; set; }
        public long? IdCategory { get; set; }
        public string? NameService { get; set; }
        public string? DescriptionService { get; set; }
        public string? ImageService { get; set; }
        public int? DiscountService { get; set; }
        public int Raiting { get; set; }
    }
}
