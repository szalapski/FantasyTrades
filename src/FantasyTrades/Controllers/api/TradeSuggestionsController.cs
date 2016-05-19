using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Szalapski.FantasyTrades.Controllers.api
{
    [Route("api/[controller]")]
    public class TradeSuggestionsController : Controller
    {

        [HttpGet]
        public IEnumerable<string> Get(string teamUrl)
        {
            Uri teamUri;
            bool isUri = Uri.TryCreate(teamUrl, UriKind.Absolute, out teamUri);
            if (!isUri) return new string[] { "error parsing URI" };
            return Get(teamUri);
        }

        private IEnumerable<string> Get(Uri teamUri)
        { 
            return new string[] { teamUri.ToString(), "value2" };
        }


        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
