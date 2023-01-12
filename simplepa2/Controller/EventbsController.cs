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
    public class EventbsController : ApiController
    {
        private simplePAEntities db = new simplePAEntities();

        // GET: api/Eventbs
        public IQueryable<Eventbs> GetEventbs()
        {
            return db.Eventbs;
        }

        // GET: api/Eventbs/5
        [ResponseType(typeof(Eventbs))]
        public async Task<IHttpActionResult> GetEventbs(int id)
        {
            Eventbs eventbs = await db.Eventbs.FindAsync(id);
            if (eventbs == null)
            {
                return NotFound();
            }

            return Ok(eventbs);
        }

        // PUT: api/Eventbs/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutEventbs(int id, Eventbs eventbs)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != eventbs.EventbsId)
            {
                return BadRequest();
            }

            db.Entry(eventbs).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventbsExists(id))
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

        // POST: api/Eventbs
        [ResponseType(typeof(Eventbs))]
        public async Task<IHttpActionResult> PostEventbs(Eventbs eventbs)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Eventbs.Add(eventbs);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = eventbs.EventbsId }, eventbs);
        }

        // DELETE: api/Eventbs/5
        [ResponseType(typeof(Eventbs))]
        public async Task<IHttpActionResult> DeleteEventbs(int id)
        {
            Eventbs eventbs = await db.Eventbs.FindAsync(id);
            if (eventbs == null)
            {
                return NotFound();
            }

            db.Eventbs.Remove(eventbs);
            await db.SaveChangesAsync();

            return Ok(eventbs);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EventbsExists(int id)
        {
            return db.Eventbs.Count(e => e.EventbsId == id) > 0;
        }
    }
}