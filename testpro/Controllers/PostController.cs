
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testpro.models;
namespace WebApplication1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {


        private readonly AppDbContext _dbContext;
        public PostController(AppDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        [HttpGet]
        public IEnumerable<Post> getall()
        {
            return _dbContext.Posts.ToList();

        }
       
        [HttpPost]
        public void addPost([FromBody] Post u)
        {
            _dbContext.Posts.Add(u);
            _dbContext.SaveChanges();
        }


    }

}