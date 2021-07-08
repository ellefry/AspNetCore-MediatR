using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_MediatR.Requests
{
    public class AreaRequest : IRequest
    {
        public string Name { get; set; }
    }
}
