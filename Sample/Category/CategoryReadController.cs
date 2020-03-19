using CQS.Mediator;
using Microsoft.AspNetCore.Mvc;
using Sample.Application.Category.List;
using System.Threading.Tasks;

namespace Sample.API.Category
{
    [Route("api/category")]
    [ApiController]
    public class CategoryReadController : ControllerBase
    {
        private readonly IMediatorService MediatorService;

        public CategoryReadController(IMediatorService mediatorService)
        {
            MediatorService = mediatorService;
        }

        [HttpGet]
        public async Task<ActionResult<CategoryListQueryViewModel>> List(CategoryListQuery query)
        {
            return CreatedAtAction("List Category", await MediatorService.ExecuteHandler(query));
        }

    }
}