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
    public class EventdevicesController : ApiController
    {
        private simplePAEntities db = new simplePAEntities();

        // GET: api/Eventdevices
        public IQueryable<Eventdevice> GetEventdevice()
        {
            return db.Eventdevice;
        }

        // GET: api/Eventdevices/5
        [ResponseType(typeof(Eventdevice))]
        public async Task<IHttpActionResult> GetEventdevice(int id)
        {
            Eventdevice eventdevice = await db.Eventdevice.FindAsync(id);
            if (eventdevice == null)
            {
                return NotFound();
            }

            return Ok(eventdevice);
        }

        // PUT: api/Eventdevices/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutEventdevice(int id, Eventdevice eventdevice)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != eventdevice.EventdeviceId)
            {
                return BadRequest();
            }

            db.Entry(eventdevice).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventdeviceExists(id))
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

        // POST: api/Eventdevices
        [ResponseType(typeof(Eventdevice))]
        public async Task<IHttpActionResult> PostEventdevice(Eventdevice eventdevice)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Eventdevice.Add(eventdevice);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = eventdevice.EventdeviceId }, eventdevice);
        }

        // DELETE: api/Eventdevices/5
        [ResponseType(typeof(Eventdevice))]
        public async Task<IHttpActionResult> DeleteEventdevice(int id)
        {
            Eventdevice eventdevice = await db.Eventdevice.FindAsync(id);
            if (eventdevice == null)
            {
                return NotFound();
            }

            db.Eventdevice.Remove(eventdevice);
            await db.SaveChangesAsync();

            return Ok(eventdevice);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EventdeviceExists(int id)
        {
            return db.Eventdevice.Count(e => e.EventdeviceId == id) > 0;
        }
    }
}