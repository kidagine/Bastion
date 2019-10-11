using System;
using System.Globalization;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Bastion.Core.Entity;
using Bastion.Core.ApplicationService;
using Bastion.Core.Entity.Filtering;
using Microsoft.AspNetCore.Cors;

namespace Bastion.UI.RestAPI.Controllers
{
	[EnableCors("CorsPolicy")]
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
        public ActionResult<IEnumerable<Speaker>> Get([FromQuery] Filter filter)
		{
			try
			{
				CultureInfo ci = new CultureInfo("fr-FR");
				ci.NumberFormat.CurrencyPositivePattern = 1;
				List<Speaker> listSpeakers = _speakerService.ReadAll(filter);
				List<Object> specifiedSpeakers = new List<object>();
				foreach (Speaker speaker in listSpeakers)
				{
					specifiedSpeakers.Add(new { speaker.Id, speaker.Name, price = speaker.Price.ToString("C", ci), speaker.Image, speaker.Color });
				}

				return Ok(specifiedSpeakers);
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
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