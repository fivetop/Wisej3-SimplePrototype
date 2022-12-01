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
    public class SimplepasController : ApiController
    {
        private simplePAEntities db = new simplePAEntities();

        // GET: api/Simplepas
        public IQueryable<Simplepa> GetSimplepa()
        {
            return db.Simplepa;
        }

        // GET: api/Simplepas/5
        [ResponseType(typeof(Simplepa))]
        public async Task<IHttpActionResult> GetSimplepa(int id)
        {
            Simplepa simplepa = await db.Simplepa.FindAsync(id);
            if (simplepa == null)
            {
                return NotFound();
            }

            return Ok(simplepa);
        }

        // PUT: api/Simplepas/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutSimplepa(int id, Simplepa simplepa)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != simplepa.SimplePAId)
            {
                return BadRequest();
            }

            db.Entry(simplepa).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SimplepaExists(id))
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

        // POST: api/Simplepas
        [ResponseType(typeof(Simplepa))]
        public async Task<IHttpActionResult> PostSimplepa(Simplepa simplepa)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Simplepa.Add(simplepa);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = simplepa.SimplePAId }, simplepa);
        }

        // DELETE: api/Simplepas/5
        [ResponseType(typeof(Simplepa))]
        public async Task<IHttpActionResult> DeleteSimplepa(int id)
        {
            Simplepa simplepa = await db.Simplepa.FindAsync(id);
            if (simplepa == null)
            {
                return NotFound();
            }

            db.Simplepa.Remove(simplepa);
            await db.SaveChangesAsync();

            return Ok(simplepa);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SimplepaExists(int id)
        {
            return db.Simplepa.Count(e => e.SimplePAId == id) > 0;
        }
    }
}