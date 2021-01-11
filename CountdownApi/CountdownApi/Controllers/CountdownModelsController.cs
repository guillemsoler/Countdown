using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CountdownApi.Models;
using CountdownApi.Utils;

namespace CountdownApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountdownModelsController : ControllerBase
    {
        private static int time = -1;
        private readonly CountdownContext _context;

        public CountdownModelsController(CountdownContext context)
        {
            _context = context;
        }

        // GET: api/CountdownModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CountdownModel>>> GetCountdownModels()
        {
            return await _context.CountdownModels.ToListAsync();
        }

        // GET: api/CountdownModels/5
        [HttpGet("{number}")]
        public ActionResult CalculateNumber(int number)
        {
            Timer.CalculateNumber(number, ref time);
            return Ok(new { time = time });

        }

        // PUT: api/CountdownModels/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCountdownModel(long id, CountdownModel countdownModel)
        {
            if (id != countdownModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(countdownModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CountdownModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }
        // DELETE: api/CountdownModels/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CountdownModel>> DeleteCountdownModel(long id)
        {
            var countdownModel = await _context.CountdownModels.FindAsync(id);
            if (countdownModel == null)
            {
                return NotFound();
            }

            _context.CountdownModels.Remove(countdownModel);
            await _context.SaveChangesAsync();

            return countdownModel;
        }

        private bool CountdownModelExists(long id)
        {
            return _context.CountdownModels.Any(e => e.Id == id);
        }
    }
}
