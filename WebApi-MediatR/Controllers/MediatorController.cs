using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApi_MediatR.Requests;

namespace WebApi_MediatR.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MediatorController : ControllerBase
    {
        private readonly IMediator mediator;

        public MediatorController(IMediator mediator)
        {
            this.mediator = mediator;

        }

        [HttpGet]
        public async Task<Unit> AreaRequest()
        {
            var areas = new AreaRequest [] { new AreaRequest { Name = "Area_A" }, new AreaRequest { Name = "Area_B" } };

            var tasks = new List<Task<Unit>>();
            foreach (var area in areas)
            {
                var task =  mediator.Send(area);
                tasks.Add(task);
            }
            Stopwatch sw = new Stopwatch();
            sw.Start();
            await Task.WhenAll(tasks);
            sw.Stop();
            Console.WriteLine($"Spend: {sw.ElapsedMilliseconds}");
            return Unit.Value;
        }
    }
}
