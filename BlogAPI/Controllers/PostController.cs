using BlogAPI.DTOs.PostsDTOs;
using Microsoft.AspNetCore.Mvc;

namespace BlogAPI.Controllers
{
    [Route("api/[controller][action]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostService _service;
        public PostController(IPostService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<PostReadDTO>> GetAllPosts() => Ok(_service.GetAllPosts);

        [HttpGet("{id}")]
        public ActionResult<PostReadDTO> GetPostById(int id)=> Ok(_service.GetPostById(id));

        [HttpPost]
        public ActionResult<PostCreateDTO> CreatePost(PostCreateDTO createDTO)
        {
            _service.CreatePost(createDTO);
            return CreatedAtAction(nameof(CreatePost), createDTO);
        }

        [HttpDelete("{id}")]
        public ActionResult DeletePost(int id)
        {
            _service.DeletePost(id);
            return NoContent();
        }

        [HttpPut("{id}")]   

        public ActionResult<PostUpdateDTO> UpdatePost(int id, PostUpdateDTO updateDTO)
        {
            _service.UpdatePost(id, updateDTO);
            return CreatedAtAction(nameof(UpdatePost), updateDTO);
        }

     




    }
}
