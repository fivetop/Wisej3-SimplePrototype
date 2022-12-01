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
    public class EventvmsController : ApiController
    {
        private simplePAEntities db = new simplePAEntities();

        // GET: api/Eventvms
        public IQueryable<Eventvm> GetEventvm()
        {
            return db.Eventvm;
        }

        // GET: api/Eventvms/5
        [ResponseType(typeof(Eventvm))]
        public async Task<IHttpActionResult> GetEventvm(int id)
        {
            Eventvm eventvm = await db.Eventvm.FindAsync(id);
            if (eventvm == null)
            {
                return NotFound();
            }

            return Ok(eventvm);
        }

        // PUT: api/Eventvms/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutEventvm(int id, Eventvm eventvm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != eventvm.EventVMId)
            {
                return BadRequest();
            }

            db.Entry(eventvm).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventvmExists(id))
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

        // POST: api/Eventvms
        [ResponseType(typeof(Eventvm))]
        public async Task<IHttpActionResult> PostEventvm(Eventvm eventvm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Eventvm.Add(eventvm);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = eventvm.EventVMId }, eventvm);
        }

        // DELETE: api/Eventvms/5
        [ResponseType(typeof(Eventvm))]
        public async Task<IHttpActionResult> DeleteEventvm(int id)
        {
            Eventvm eventvm = await db.Eventvm.FindAsync(id);
            if (eventvm == null)
            {
                return NotFound();
            }

            db.Eventvm.Remove(eventvm);
            await db.SaveChangesAsync();

            return Ok(eventvm);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EventvmExists(int id)
        {
            return db.Eventvm.Count(e => e.EventVMId == id) > 0;
        }
    }
}