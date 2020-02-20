using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using rapnetApi.BLL;
using rapnetApi.Models;

namespace rapnetApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class DiamondsController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public DiamondsController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: api/Diamonds
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Diamond>>> GetDiamonds()
        {
            return await _context.Diamonds.ToListAsync();
        }

        // POST: api/Diamonds
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Diamond>> PostDiamond(Diamond diamond)
        {
            // check data is full
            BLDiamonds blDiamonds = new BLDiamonds();
            if (!blDiamonds.validation(diamond))
            {
                return BadRequest("Missing Data");
            }

            // generate unique id
            GeneralFunctions generalFunctions = new GeneralFunctions();
            diamond.Id = generalFunctions.genarateUniqueID();

            _context.Diamonds.Add(diamond);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DiamondExists(diamond.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetDiamond", new { id = diamond.Id }, diamond);
        }


        // GET: api/Diamonds/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Diamond>> GetDiamond(decimal id)
        //{
        //    var diamond = await _context.Diamonds.FindAsync(id);

        //    if (diamond == null)
        //    {
        //        return NotFound();
        //    }

        //    return diamond;
        //}

        // PUT: api/Diamonds/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutDiamond(decimal id, Diamond diamond)
        //{
        //    if (id != diamond.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(diamond).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!DiamondExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        // DELETE: api/Diamonds/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<Diamond>> DeleteDiamond(decimal id)
        //{
        //    var diamond = await _context.Diamonds.FindAsync(id);
        //    if (diamond == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Diamonds.Remove(diamond);
        //    await _context.SaveChangesAsync();

        //    return diamond;
        //}

        private bool DiamondExists(decimal id)
        {
            return _context.Diamonds.Any(e => e.Id == id);
        }
    }
}
