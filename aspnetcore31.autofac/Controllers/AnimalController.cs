using aspnetcore31.autofac.model;
using Autofac.Features.Indexed;
using Microsoft.AspNetCore.Mvc;

namespace aspnetcore31.autofac.Controllers
{
    [Route("api/animal")]
    [ApiController]
    public class AnimalController : Controller
    {
        private readonly IAnimal _animal;
        private readonly IIndex<string, IAnimal> _serviceIndexes;

        public AnimalController(IIndex<string, IAnimal> serviceIndexes)
        {
            _serviceIndexes = serviceIndexes;
            _animal = serviceIndexes["dog"];

        }
        
        // GET
        public IActionResult Index() => new ObjectResult(_animal.Sound());
        
    }
}