using BookStore_API.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookStore_API.Controllers
{
   
    /// <summary>
    /// This is test API controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class Home1Controller : ControllerBase
    {
        private readonly ILoggerService _logger;

        public Home1Controller(ILoggerService logger)
        {
            _logger = logger;
        }
        /// <summary>
        /// GET gets values
        /// </summary>
        /// <returns></returns>

        // GET: api/<Home1Controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            _logger.LogInfo("Accessed Home Controller");
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Get gets a value
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET api/<Home1Controller>/5
        [HttpGet("{id}")]
        
        public string Get(int id)
        {
            _logger.LogDebug("Got a value");
            return "value";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        // POST api/<Home1Controller>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            _logger.LogError("This is an error");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        // PUT api/<Home1Controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        // DELETE api/<Home1Controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _logger.LogWarn("This is a warning");
        }
    }
}
