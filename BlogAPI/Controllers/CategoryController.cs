using Microsoft.AspNetCore.Mvc;

namespace BlogAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }


        [HttpGet]
      //  [Route("~/GetAll")]
        public ActionResult<List<CategoryReadDTO>> GetAll() => Ok(_categoryService.GetAllCategories());

        [HttpGet("{id}")]

        public ActionResult<CategoryReadDTO> GetCategoryById(int id) => Ok(_categoryService.GetCategoryById(id));

        [HttpGet]
        [Route("{id}")]
        public ActionResult<CategoryWithPostsDTO> GetCategoryWithPosts(int id) => Ok(_categoryService.GetCategoryWithPosts(id));

        [HttpPost]
        public ActionResult<CategoryReadDTO> CreateCategory(CategoryCreateDTO categoryCreateDTO)
        {
            _categoryService.CreateCategory(categoryCreateDTO);
            return CreatedAtAction(nameof(CreateCategory), categoryCreateDTO);
        }

        [HttpPut("{id}")]
        public ActionResult<CategoryReadDTO> UpdateCategory(int id, CategoryUpdateDTO categoryUpdateDTO)
        {
            _categoryService.UpdateCategory(id, categoryUpdateDTO);
            return CreatedAtAction(nameof(CreateCategory), categoryUpdateDTO);
        }


        [HttpDelete("{id}")]
        public ActionResult DeleteCategory(int id)
        {
            _categoryService.DeleteCategory(id);
            return NoContent();
        }

     


    }
}
