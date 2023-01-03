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
    public class AssetPresetGroupsController : ApiController
    {
        private simplePAEntities db = new simplePAEntities();

        // GET: api/AssetPresetGroups
        public IQueryable<AssetPresetGroups> GetAssetPresetGroups()
        {
            return db.AssetPresetGroups;
        }

        // GET: api/AssetPresetGroups/5
        [ResponseType(typeof(AssetPresetGroups))]
        public async Task<IHttpActionResult> GetAssetPresetGroups(int id)
        {
            AssetPresetGroups assetPresetGroups = await db.AssetPresetGroups.FindAsync(id);
            if (assetPresetGroups == null)
            {
                return NotFound();
            }

            return Ok(assetPresetGroups);
        }

        // PUT: api/AssetPresetGroups/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutAssetPresetGroups(int id, AssetPresetGroups assetPresetGroups)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != assetPresetGroups.AssetPresetGroupId)
            {
                return BadRequest();
            }

            db.Entry(assetPresetGroups).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AssetPresetGroupsExists(id))
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

        // POST: api/AssetPresetGroups
        [ResponseType(typeof(AssetPresetGroups))]
        public async Task<IHttpActionResult> PostAssetPresetGroups(AssetPresetGroups assetPresetGroups)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.AssetPresetGroups.Add(assetPresetGroups);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = assetPresetGroups.AssetPresetGroupId }, assetPresetGroups);
        }

        // DELETE: api/AssetPresetGroups/5
        [ResponseType(typeof(AssetPresetGroups))]
        public async Task<IHttpActionResult> DeleteAssetPresetGroups(int id)
        {
            AssetPresetGroups assetPresetGroups = await db.AssetPresetGroups.FindAsync(id);
            if (assetPresetGroups == null)
            {
                return NotFound();
            }

            db.AssetPresetGroups.Remove(assetPresetGroups);
            await db.SaveChangesAsync();

            return Ok(assetPresetGroups);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AssetPresetGroupsExists(int id)
        {
            return db.AssetPresetGroups.Count(e => e.AssetPresetGroupId == id) > 0;
        }
    }
}