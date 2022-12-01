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
    public class AssetGroupsController : ApiController
    {
        private simplePAEntities db = new simplePAEntities();

        // GET: api/AssetGroups
        public IQueryable<AssetGroups> GetAssetGroups()
        {
            return db.AssetGroups;
        }

        // GET: api/AssetGroups/5
        [ResponseType(typeof(AssetGroups))]
        public async Task<IHttpActionResult> GetAssetGroups(int id)
        {
            AssetGroups assetGroups = await db.AssetGroups.FindAsync(id);
            if (assetGroups == null)
            {
                return NotFound();
            }

            return Ok(assetGroups);
        }

        // PUT: api/AssetGroups/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutAssetGroups(int id, AssetGroups assetGroups)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != assetGroups.AssetGroupId)
            {
                return BadRequest();
            }

            db.Entry(assetGroups).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AssetGroupsExists(id))
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

        // POST: api/AssetGroups
        [ResponseType(typeof(AssetGroups))]
        public async Task<IHttpActionResult> PostAssetGroups(AssetGroups assetGroups)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.AssetGroups.Add(assetGroups);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = assetGroups.AssetGroupId }, assetGroups);
        }

        // DELETE: api/AssetGroups/5
        [ResponseType(typeof(AssetGroups))]
        public async Task<IHttpActionResult> DeleteAssetGroups(int id)
        {
            AssetGroups assetGroups = await db.AssetGroups.FindAsync(id);
            if (assetGroups == null)
            {
                return NotFound();
            }

            db.AssetGroups.Remove(assetGroups);
            await db.SaveChangesAsync();

            return Ok(assetGroups);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AssetGroupsExists(int id)
        {
            return db.AssetGroups.Count(e => e.AssetGroupId == id) > 0;
        }
    }
}