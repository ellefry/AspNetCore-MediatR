using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WebApi_MediatR.Requests;

namespace WebApi_MediatR.Handlers
{
    public class ProductTypeHandler : AsyncRequestHandler<ProductTypeRequest>
    {
        protected override async Task Handle(ProductTypeRequest request, CancellationToken cancellationToken)
        {
            await Task.Delay(2000);
            Console.WriteLine($"[ProductType] : This message from {request.ProductFamily}");
        }
    }
}
