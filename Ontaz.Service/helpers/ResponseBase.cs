using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ontaz.Service.helpers
{
    public abstract class ResponseBase
    {
        public object? Data { get; set; }
        public bool Success { get; set; } = false;
        public int StatusCode { get; set; } = 400;
        public string Messsage { get; set; } = "";
    }
}
