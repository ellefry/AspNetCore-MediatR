using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WebApi_MediatR.Requests;

namespace WebApi_MediatR.Handlers
{
    public class AreaHandler : AsyncRequestHandler<AreaRequest>
    {
        private readonly IMediator mediator;

        public AreaHandler(IMediator mediator)
        {
            this.mediator = mediator;
        }

        protected override async Task Handle(AreaRequest request, CancellationToken cancellationToken)
        {
            await Task.Delay(300);
            Console.WriteLine($"[Area] : This message from {request.Name}");
            await mediator.Send(new ProductFamilyRequest { AreaName = request.Name });
        }
    }
}
