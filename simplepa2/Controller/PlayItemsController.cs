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
    public class PlayItemsController : ApiController
    {
        private simplePAEntities db = new simplePAEntities();

        // GET: api/PlayItems
        public IQueryable<PlayItem> GetPlayItem()
        {
            return db.PlayItem;
        }

        // GET: api/PlayItems/5
        [ResponseType(typeof(PlayItem))]
        public async Task<IHttpActionResult> GetPlayItem(int id)
        {
            PlayItem playItem = await db.PlayItem.FindAsync(id);
            if (playItem == null)
            {
                return NotFound();
            }

            return Ok(playItem);
        }

        // PUT: api/PlayItems/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPlayItem(int id, PlayItem playItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != playItem.PlayItemId)
            {
                return BadRequest();
            }

            db.Entry(playItem).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlayItemExists(id))
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

        // POST: api/PlayItems
        [ResponseType(typeof(PlayItem))]
        public async Task<IHttpActionResult> PostPlayItem(PlayItem playItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PlayItem.Add(playItem);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PlayItemExists(playItem.PlayItemId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = playItem.PlayItemId }, playItem);
        }

        // DELETE: api/PlayItems/5
        [ResponseType(typeof(PlayItem))]
        public async Task<IHttpActionResult> DeletePlayItem(int id)
        {
            PlayItem playItem = await db.PlayItem.FindAsync(id);
            if (playItem == null)
            {
                return NotFound();
            }

            db.PlayItem.Remove(playItem);
            await db.SaveChangesAsync();

            return Ok(playItem);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PlayItemExists(int id)
        {
            return db.PlayItem.Count(e => e.PlayItemId == id) > 0;
        }
    }
}