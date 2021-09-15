using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Tweetbook.Contracts;

namespace Tweetbook.Controllers
{
    [ApiController]
    //[Route("api/[controller]")]
    public class PostsController : ControllerBase
    {
        private List<Post> _post;
        public PostsController()
        {
            _post = new List<Post>();
            for (var i = 0; i < 5; i++)
            {
                _post.Add(new Post{Id = Guid.NewGuid().ToString()});
            }
        }

        [HttpGet]
        [Route(ApiRoutes.Post.GetAll)]
        public IActionResult GetAll(){
            return Ok(_post);
        }

    }
}