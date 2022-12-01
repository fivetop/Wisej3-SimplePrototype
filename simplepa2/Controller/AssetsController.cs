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
    public class AssetsController : ApiController
    {
        private simplePAEntities db = new simplePAEntities();

        // GET: api/Assets
        public IQueryable<Assets> GetAssets()
        {
            return db.Assets;
        }

        // GET: api/Assets/5
        [ResponseType(typeof(Assets))]
        public async Task<IHttpActionResult> GetAssets(int id)
        {
            Assets assets = await db.Assets.FindAsync(id);
            if (assets == null)
            {
                return NotFound();
            }

            return Ok(assets);
        }

        // PUT: api/Assets/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutAssets(int id, Assets assets)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != assets.AssetId)
            {
                return BadRequest();
            }

            db.Entry(assets).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AssetsExists(id))
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

        // POST: api/Assets
        [ResponseType(typeof(Assets))]
        public async Task<IHttpActionResult> PostAssets(Assets assets)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Assets.Add(assets);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = assets.AssetId }, assets);
        }

        // DELETE: api/Assets/5
        [ResponseType(typeof(Assets))]
        public async Task<IHttpActionResult> DeleteAssets(int id)
        {
            Assets assets = await db.Assets.FindAsync(id);
            if (assets == null)
            {
                return NotFound();
            }

            db.Assets.Remove(assets);
            await db.SaveChangesAsync();

            return Ok(assets);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AssetsExists(int id)
        {
            return db.Assets.Count(e => e.AssetId == id) > 0;
        }
    }
}