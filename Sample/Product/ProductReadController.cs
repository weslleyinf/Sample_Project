using CQS.Mediator;
using Microsoft.AspNetCore.Mvc;
using Sample.Application.Product.List;
using System.Threading.Tasks;

namespace Sample.API.Product
{
    [Route("api/product")]
    [ApiController]
    public class ProductReadController : ControllerBase
    {
        private readonly IMediatorService MediatorService;

        public ProductReadController(IMediatorService mediatorService)
        {
            MediatorService = mediatorService;
        }

        [HttpGet]
        public async Task<ActionResult<ProductListQueryViewModel>> List(ProductListQuery query)
        {
            return CreatedAtAction("List Product", await MediatorService.ExecuteHandler(query));
        }
    }
}