using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_MediatR.Requests
{
    public class ProductFamilyRequest : IRequest
    {
        public string AreaName { get; set; }
    }
}
