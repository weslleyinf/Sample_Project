using CQS.Mediator;
using Microsoft.AspNetCore.Mvc;
using Sample.Application.Category.Delete;
using Sample.Application.Category.Insert;
using Sample.Application.Category.Update;
using System.Threading.Tasks;

namespace Sample.API.Category
{
    [Route("api/category")]
    [ApiController]
    public class CategoryWriteController : ControllerBase
    {
        private readonly IMediatorService MediatorService;

        public CategoryWriteController(IMediatorService mediatorService)
        {
            MediatorService = mediatorService;
        }

        [HttpPost]
        public async Task<ActionResult> Insert(CategoryInsertCommand command)
        {
            await MediatorService.ExecuteHandler(command);

            return NoContent();
        }

        [HttpPut]
        public async Task<ActionResult> Update(CategoryUpdateCommand command)
        {
            await MediatorService.ExecuteHandler(command);

            return NoContent();
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(CategoryDeleteCommand command)
        {
            await MediatorService.ExecuteHandler(command);

            return NoContent();
        }
    }
}