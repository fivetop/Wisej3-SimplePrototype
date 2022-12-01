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
    public class EMBsController : ApiController
    {
        private simplePAEntities db = new simplePAEntities();

        // GET: api/EMBs
        public IQueryable<EMBs> GetEMBs()
        {
            return db.EMBs;
        }

        // GET: api/EMBs/5
        [ResponseType(typeof(EMBs))]
        public async Task<IHttpActionResult> GetEMBs(int id)
        {
            EMBs eMBs = await db.EMBs.FindAsync(id);
            if (eMBs == null)
            {
                return NotFound();
            }

            return Ok(eMBs);
        }

        // PUT: api/EMBs/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutEMBs(int id, EMBs eMBs)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != eMBs.EMBsId)
            {
                return BadRequest();
            }

            db.Entry(eMBs).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EMBsExists(id))
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

        // POST: api/EMBs
        [ResponseType(typeof(EMBs))]
        public async Task<IHttpActionResult> PostEMBs(EMBs eMBs)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.EMBs.Add(eMBs);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = eMBs.EMBsId }, eMBs);
        }

        // DELETE: api/EMBs/5
        [ResponseType(typeof(EMBs))]
        public async Task<IHttpActionResult> DeleteEMBs(int id)
        {
            EMBs eMBs = await db.EMBs.FindAsync(id);
            if (eMBs == null)
            {
                return NotFound();
            }

            db.EMBs.Remove(eMBs);
            await db.SaveChangesAsync();

            return Ok(eMBs);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EMBsExists(int id)
        {
            return db.EMBs.Count(e => e.EMBsId == id) > 0;
        }
    }
}