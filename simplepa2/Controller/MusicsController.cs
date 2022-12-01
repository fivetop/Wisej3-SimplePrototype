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
    public class MusicsController : ApiController
    {
        private simplePAEntities db = new simplePAEntities();

        // GET: api/Musics
        public IQueryable<Musics> GetMusics()
        {
            return db.Musics;
        }

        // GET: api/Musics/5
        [ResponseType(typeof(Musics))]
        public async Task<IHttpActionResult> GetMusics(int id)
        {
            Musics musics = await db.Musics.FindAsync(id);
            if (musics == null)
            {
                return NotFound();
            }

            return Ok(musics);
        }

        // PUT: api/Musics/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutMusics(int id, Musics musics)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != musics.MusicId)
            {
                return BadRequest();
            }

            db.Entry(musics).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MusicsExists(id))
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

        // POST: api/Musics
        [ResponseType(typeof(Musics))]
        public async Task<IHttpActionResult> PostMusics(Musics musics)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Musics.Add(musics);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = musics.MusicId }, musics);
        }

        // DELETE: api/Musics/5
        [ResponseType(typeof(Musics))]
        public async Task<IHttpActionResult> DeleteMusics(int id)
        {
            Musics musics = await db.Musics.FindAsync(id);
            if (musics == null)
            {
                return NotFound();
            }

            db.Musics.Remove(musics);
            await db.SaveChangesAsync();

            return Ok(musics);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MusicsExists(int id)
        {
            return db.Musics.Count(e => e.MusicId == id) > 0;
        }
    }
}