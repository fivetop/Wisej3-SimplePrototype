using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace simplepa2.Controller
{
    public class HolidaysController : ApiController
    {
        private simplePAEntities db = new simplePAEntities();

        // GET: api/Holidays
        public IQueryable<Holidays> GetHolidays()
        {
            return db.Holidays;
        }

        // GET: api/Holidays/5
        [ResponseType(typeof(Holidays))]
        public async Task<IHttpActionResult> GetHolidays(int id)
        {
            Holidays holidays = await db.Holidays.FindAsync(id);
            if (holidays == null)
            {
                return NotFound();
            }

            return Ok(holidays);
        }

        // PUT: api/Holidays/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutHolidays(int id, Holidays holidays)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != holidays.HolidayId)
            {
                return BadRequest();
            }

            db.Entry(holidays).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HolidaysExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Holidays
        [ResponseType(typeof(Holidays))]
        public async Task<IHttpActionResult> PostHolidays(Holidays holidays)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Holidays.Add(holidays);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = holidays.HolidayId }, holidays);
        }

        // DELETE: api/Holidays/5
        [ResponseType(typeof(Holidays))]
        public async Task<IHttpActionResult> DeleteHolidays(int id)
        {
            Holidays holidays = await db.Holidays.FindAsync(id);
            if (holidays == null)
            {
                return NotFound();
            }

            db.Holidays.Remove(holidays);
            await db.SaveChangesAsync();

            return Ok(holidays);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool HolidaysExists(int id)
        {
            return db.Holidays.Count(e => e.HolidayId == id) > 0;
        }
    }
}