using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Bastion.Core.Entity;
using Bastion.Core.ApplicationService;

namespace Bastion.UI.RestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpeakersController : ControllerBase
    {
        private readonly ISpeakerService _speakerService;


        public SpeakersController(ISpeakerService speakerService)
        {
            _speakerService = speakerService;
        }

        // GET api/speakers -- READ ALL
        [HttpGet]
        public ActionResult<IEnumerable<Speaker>> Get()
        {
            return Ok(_speakerService.ReadAll());
        }

        // GET api/speakers.5 -- READ BY ID
        [HttpGet("{id}")]
        public ActionResult<Speaker> Get(int id)
        {
            return _speakerService.ReadById(id);
        }

        // POST api/speakers -- CREATE
        [HttpPost]
        public ActionResult Post([FromBody] Speaker speaker)
        {
            try
            {
                return Ok(_speakerService.Create(speaker));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // PUT api/speakers/5 -- UPDATE
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Speaker speaker)
        {
            try
            {
                if (id != speaker.Id)
                {
                    return BadRequest("Parameter ID and speaker ID have to be the same");
                }
                return Ok(_speakerService.Update(speaker));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // DELETE api/speakers/5 -- DELETE
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                _speakerService.Delete(id);
                return Ok($"Deleted speaker with Id: {id}");
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }

        }
    }
}