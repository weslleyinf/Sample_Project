using CQS.Mediator;
using Microsoft.AspNetCore.Mvc;
using Sample.Application.Product.Delete;
using Sample.Application.Product.Insert;
using Sample.Application.Product.Update;
using System.Threading.Tasks;

namespace Sample.API.Product
{
    [Route("api/product")]
    [ApiController]
    public class ProductWriteController : ControllerBase
    {
        private readonly IMediatorService MediatorService;

        public ProductWriteController(IMediatorService mediatorService)
        {
            MediatorService = mediatorService;
        }

        [HttpPost]
        public async Task<ActionResult> Insert(ProductInsertCommand command)
        {
            await MediatorService.ExecuteHandler(command);

            return NoContent();
        }

        [HttpPut]
        public async Task<ActionResult> Update(ProductUpdateCommand command)
        {
            await MediatorService.ExecuteHandler(command);

            return NoContent();
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(ProductDeleteCommand command)
        {
            await MediatorService.ExecuteHandler(command);

            return NoContent();
        }
    }
}