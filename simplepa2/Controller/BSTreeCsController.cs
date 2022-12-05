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
    public class BSTreeCsController : ApiController
    {
        private simplePAEntities db = new simplePAEntities();

        // GET: api/BSTreeCs
        public IQueryable<BSTreeC> GetBSTreeC()
        {
            return db.BSTreeC;
        }

        // GET: api/BSTreeCs/5
        [ResponseType(typeof(BSTreeC))]
        public async Task<IHttpActionResult> GetBSTreeC(int id)
        {
            BSTreeC bSTreeC = await db.BSTreeC.FindAsync(id);
            if (bSTreeC == null)
            {
                return NotFound();
            }

            return Ok(bSTreeC);
        }

        // PUT: api/BSTreeCs/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutBSTreeC(int id, BSTreeC bSTreeC)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bSTreeC.BSTreeCId)
            {
                return BadRequest();
            }

            db.Entry(bSTreeC).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BSTreeCExists(id))
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

        // POST: api/BSTreeCs
        [ResponseType(typeof(BSTreeC))]
        public async Task<IHttpActionResult> PostBSTreeC(BSTreeC bSTreeC)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.BSTreeC.Add(bSTreeC);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = bSTreeC.BSTreeCId }, bSTreeC);
        }

        // DELETE: api/BSTreeCs/5
        [ResponseType(typeof(BSTreeC))]
        public async Task<IHttpActionResult> DeleteBSTreeC(int id)
        {
            BSTreeC bSTreeC = await db.BSTreeC.FindAsync(id);
            if (bSTreeC == null)
            {
                return NotFound();
            }

            db.BSTreeC.Remove(bSTreeC);
            await db.SaveChangesAsync();

            return Ok(bSTreeC);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BSTreeCExists(int id)
        {
            return db.BSTreeC.Count(e => e.BSTreeCId == id) > 0;
        }
    }
}