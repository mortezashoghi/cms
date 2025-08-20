using cms.core.Interface.Repository;
using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace cms.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostController : ControllerBase
    {
        public IpostRepository _postRepository { get; }

        public PostController(IpostRepository postRepository) {
            _postRepository = postRepository;
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll() { 
        return Ok(await _postRepository.GetAll());
        }

        
    }
}
