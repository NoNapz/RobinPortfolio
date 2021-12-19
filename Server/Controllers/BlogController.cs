using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Server.Data;
using Shared.Models;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly AppDBContext _appDBContext;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public BlogController(AppDBContext appDBContext, IWebHostEnvironment webHostEnvironment)
        {
            _appDBContext = appDBContext;
            _webHostEnvironment = webHostEnvironment;
        }

        #region CRUD

        [HttpGet]
        public async Task<ActionResult<List<BlogPost>>> Get()
        {
            return Ok(await _appDBContext.BlogPosts.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult<List<BlogPost>>> AddBlogPost(BlogPost blogpost)
        {
            _appDBContext.BlogPosts.Add(blogpost);
            await _appDBContext.SaveChangesAsync();
            return Ok(await _appDBContext.BlogPosts.ToListAsync());
        }

        #endregion
    }
}
