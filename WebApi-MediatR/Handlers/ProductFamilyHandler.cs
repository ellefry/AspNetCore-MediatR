using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WebApi_MediatR.Requests;

namespace WebApi_MediatR.Handlers
{
    public class ProductFamilyHandler : AsyncRequestHandler<ProductFamilyRequest>
    {
        private readonly IMediator mediator;

        public ProductFamilyHandler(IMediator mediator)
        {
            this.mediator = mediator;
        }

        protected override async Task Handle(ProductFamilyRequest request, CancellationToken cancellationToken)
        {
            await Task.Delay(500);
            Console.WriteLine($"[ProductFamily] : This message from {request.AreaName}");
            var families = new List<string> { "ProductFamily_A", "ProductFamily_B" };

            var tasks = new List<Task<Unit>>();
            foreach (var fa in families)
            {
                tasks.Add( mediator.Send(new ProductTypeRequest { ProductFamily = fa }));
            }
            await Task.WhenAll(tasks);
        }
    }
}
