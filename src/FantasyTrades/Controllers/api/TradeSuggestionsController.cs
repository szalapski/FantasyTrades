using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Szalapski.FantasyTrades.Lib;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Szalapski.FantasyTrades.Controllers.api
{
    [Route("api/[controller]")]
    public class TradeSuggestionsController : Controller
    {
        public TradeSuggestionsController()
        {

        }
        ISuggestor _suggestor = new Suggestor(new DummyTeamScraper(), new Engine(new FantasyPros2016PlayerRater()));


        [HttpGet]
        public IActionResult Get(string teamUrl) { 
            Uri teamUri;
            bool isUri = Uri.TryCreate(teamUrl, UriKind.Absolute, out teamUri);
            if (!isUri) return this.BadRequest(new TradeSuggestion(new Uri("http://example.com/error"), new Uri("http://example.com/error")));
            return Get(teamUri);
        }

        private IActionResult Get(Uri teamUri)
        {
            TradeSuggestion suggestion = _suggestor.SuggestTrade(teamUri);

            return this.Ok(suggestion);
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
