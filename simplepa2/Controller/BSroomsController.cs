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
    public class BSroomsController : ApiController
    {
        private simplePAEntities db = new simplePAEntities();

        // GET: api/BSrooms
        public IQueryable<BSroom> GetBSroom()
        {
            return db.BSroom;
        }

        // GET: api/BSrooms/5
        [ResponseType(typeof(BSroom))]
        public async Task<IHttpActionResult> GetBSroom(int id)
        {
            BSroom bSroom = await db.BSroom.FindAsync(id);
            if (bSroom == null)
            {
                return NotFound();
            }

            return Ok(bSroom);
        }

        // PUT: api/BSrooms/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutBSroom(int id, BSroom bSroom)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bSroom.BSroomid)
            {
                return BadRequest();
            }

            db.Entry(bSroom).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BSroomExists(id))
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

        // POST: api/BSrooms
        [ResponseType(typeof(BSroom))]
        public async Task<IHttpActionResult> PostBSroom(BSroom bSroom)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.BSroom.Add(bSroom);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = bSroom.BSroomid }, bSroom);
        }

        // DELETE: api/BSrooms/5
        [ResponseType(typeof(BSroom))]
        public async Task<IHttpActionResult> DeleteBSroom(int id)
        {
            BSroom bSroom = await db.BSroom.FindAsync(id);
            if (bSroom == null)
            {
                return NotFound();
            }

            db.BSroom.Remove(bSroom);
            await db.SaveChangesAsync();

            return Ok(bSroom);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BSroomExists(int id)
        {
            return db.BSroom.Count(e => e.BSroomid == id) > 0;
        }
    }
}