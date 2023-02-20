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
    public class SchdulesController : ApiController
    {
        private simplePAEntities db = new simplePAEntities();

        // GET: api/Schdules
        public IQueryable<Schdule> GetSchdule()
        {
            return db.Schdule;
        }

        // GET: api/Schdules/5
        [ResponseType(typeof(Schdule))]
        public async Task<IHttpActionResult> GetSchdule(int id)
        {
            Schdule schdule = await db.Schdule.FindAsync(id);
            if (schdule == null)
            {
                return NotFound();
            }

            return Ok(schdule);
        }

        // PUT: api/Schdules/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutSchdule(int id, Schdule schdule)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != schdule.SchduleId)
            {
                return BadRequest();
            }

            db.Entry(schdule).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SchduleExists(id))
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

        // POST: api/Schdules
        [ResponseType(typeof(Schdule))]
        public async Task<IHttpActionResult> PostSchdule(Schdule schdule)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Schdule.Add(schdule);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = schdule.SchduleId }, schdule);
        }

        // DELETE: api/Schdules/5
        [ResponseType(typeof(Schdule))]
        public async Task<IHttpActionResult> DeleteSchdule(int id)
        {
            Schdule schdule = await db.Schdule.FindAsync(id);
            if (schdule == null)
            {
                return NotFound();
            }

            db.Schdule.Remove(schdule);
            await db.SaveChangesAsync();

            return Ok(schdule);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SchduleExists(int id)
        {
            return db.Schdule.Count(e => e.SchduleId == id) > 0;
        }
    }
}