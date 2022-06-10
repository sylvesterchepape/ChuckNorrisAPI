using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ChuckNorrisAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChuckNorrisController : ControllerBase
    {
     

        private readonly ILogger<ChuckNorrisController> _logger;
        private readonly IChucknorrisServices _chucknorrisServices;


        public ChuckNorrisController(ILogger<ChuckNorrisController> logger, IChucknorrisServices chucknorrisServices)
        {
            _logger = logger;
            _chucknorrisServices = chucknorrisServices;

        }

        [HttpGet]
        public async Task<string> Get()
        {
            return await _chucknorrisServices.Get();
          
        }
    }
}
