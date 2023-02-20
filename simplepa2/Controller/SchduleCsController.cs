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
    public class SchduleCsController : ApiController
    {
        private simplePAEntities db = new simplePAEntities();

        // GET: api/SchduleCs
        public IQueryable<SchduleC> GetSchduleC()
        {
            return db.SchduleC;
        }

        // GET: api/SchduleCs/5
        [ResponseType(typeof(SchduleC))]
        public async Task<IHttpActionResult> GetSchduleC(int id)
        {
            SchduleC schduleC = await db.SchduleC.FindAsync(id);
            if (schduleC == null)
            {
                return NotFound();
            }

            return Ok(schduleC);
        }

        // PUT: api/SchduleCs/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutSchduleC(int id, SchduleC schduleC)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != schduleC.SchduleCId)
            {
                return BadRequest();
            }

            db.Entry(schduleC).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SchduleCExists(id))
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

        // POST: api/SchduleCs
        [ResponseType(typeof(SchduleC))]
        public async Task<IHttpActionResult> PostSchduleC(SchduleC schduleC)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.SchduleC.Add(schduleC);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = schduleC.SchduleCId }, schduleC);
        }

        // DELETE: api/SchduleCs/5
        [ResponseType(typeof(SchduleC))]
        public async Task<IHttpActionResult> DeleteSchduleC(int id)
        {
            SchduleC schduleC = await db.SchduleC.FindAsync(id);
            if (schduleC == null)
            {
                return NotFound();
            }

            db.SchduleC.Remove(schduleC);
            await db.SaveChangesAsync();

            return Ok(schduleC);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SchduleCExists(int id)
        {
            return db.SchduleC.Count(e => e.SchduleCId == id) > 0;
        }
    }
}