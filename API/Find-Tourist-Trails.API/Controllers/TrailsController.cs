﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Find_Tourist_Trails.Data;
using Find_Tourist_Trails.Models;
using Find_Tourist_Trails.Repositories;
using Find_Tourist_Trails.Models.DTO;

namespace Find_Tourist_Trails.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrailsController : ControllerBase
    {
        private readonly TrailsDbContext _context;
        private readonly ITrailRepository trailRepository;

        public TrailsController(TrailsDbContext context, ITrailRepository trailRepository)
        {
            _context = context;
            this.trailRepository = trailRepository;
        }

        // GET: api/Trails
        [HttpGet]


        public async Task<ActionResult<IEnumerable<Trails>>> GetTrails([FromQuery] string? filterOn, [FromQuery] string? filterQuery)
        {
            if (_context.Trails == null)
            {
                return NotFound();
            }

            var TrailsDomainList = await trailRepository.GetAllAsync(filterOn, filterQuery);

            var TrailsDTOList = new List<TrailsDTO>();
            foreach (var item in TrailsDomainList)
            {
                TrailsDTOList.Add(new TrailsDTO
                {
                    Id = item.Id,
                    Name = item.Name,
                    Description = item.Description,
                    LengthInKm = item.LengthInKm,
                    WalkImageUrl = item.WalkImageUrl,
                    Difficulty = item.Difficulty,
                    Region = item.Region,
                    MapLink = item.MapLink,

                });
            }

            return Ok(TrailsDTOList);
            //return Ok(await _context.Trails.ToListAsync());
        }

        //GET: api/SpecificTrail/5
        [HttpGet()]
        [Route("{id:Guid}")]
        public async Task<ActionResult<Trails>> GetSpecificTrail([FromRoute] Guid id)
        {
            if (_context.Trails == null)
            {
                return NotFound();
            }
            var trails = await _context.Trails.FindAsync(id);

            if (trails == null)
            {
                return NotFound();
            }

            return trails;
        }

        //PoST: api/RandomTrails
        [HttpPost]
        [Route("Login")]
        public async Task<ActionResult<Trails>> PostRandomTrails()
        {
            if (_context.Trails == null)
            {
                return NotFound();
            }

            var randomTrailsList = await _context.Trails.OrderBy(r => Guid.NewGuid()).Take(3).ToListAsync();

            var TrailsDTOList = new List<TrailsDTO>();

            foreach (var item in randomTrailsList)
            {
                TrailsDTOList.Add(new TrailsDTO
                {
                    Id = item.Id,
                    Name = item.Name,
                    Description = item.Description,
                    LengthInKm = item.LengthInKm,
                    WalkImageUrl = item.WalkImageUrl,
                    Difficulty = item.Difficulty,
                    Region = item.Region,
                    MapLink = item.MapLink,
                });

            }

            return Ok(randomTrailsList);
        }

        // PUT: api/Trails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTrails(Guid id, Trails trails)
        {
            if (id != trails.Id)
            {
                return BadRequest();
            }

            _context.Entry(trails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrailsExists(id))
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

        // POST: api/Trails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Trails>> PostTrails(Trails trails)
        {
            if (_context.Trails == null)
            {
                return Problem("Entity set 'TrailsDbContext.Trails'  is null.");
            }
            _context.Trails.Add(trails);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TrailsExists(trails.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTrails", new { id = trails.Id }, trails);
        }

        // DELETE: api/Trails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTrails(Guid id)
        {
            if (_context.Trails == null)
            {
                return NotFound();
            }
            var trails = await _context.Trails.FindAsync(id);
            if (trails == null)
            {
                return NotFound();
            }

            _context.Trails.Remove(trails);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TrailsExists(Guid id)
        {
            return (_context.Trails?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
