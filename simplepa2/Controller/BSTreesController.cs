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
    public class BSTreesController : ApiController
    {
        private simplePAEntities db = new simplePAEntities();

        // GET: api/BSTrees
        public IQueryable<BSTree> GetBSTree()
        {
            return db.BSTree;
        }

        // GET: api/BSTrees/5
        [ResponseType(typeof(BSTree))]
        public async Task<IHttpActionResult> GetBSTree(int id)
        {
            BSTree bSTree = await db.BSTree.FindAsync(id);
            if (bSTree == null)
            {
                return NotFound();
            }

            return Ok(bSTree);
        }

        // PUT: api/BSTrees/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutBSTree(int id, BSTree bSTree)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bSTree.BSTreeId)
            {
                return BadRequest();
            }

            db.Entry(bSTree).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BSTreeExists(id))
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

        // POST: api/BSTrees
        [ResponseType(typeof(BSTree))]
        public async Task<IHttpActionResult> PostBSTree(BSTree bSTree)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.BSTree.Add(bSTree);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = bSTree.BSTreeId }, bSTree);
        }

        // DELETE: api/BSTrees/5
        [ResponseType(typeof(BSTree))]
        public async Task<IHttpActionResult> DeleteBSTree(int id)
        {
            BSTree bSTree = await db.BSTree.FindAsync(id);
            if (bSTree == null)
            {
                return NotFound();
            }

            db.BSTree.Remove(bSTree);
            await db.SaveChangesAsync();

            return Ok(bSTree);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BSTreeExists(int id)
        {
            return db.BSTree.Count(e => e.BSTreeId == id) > 0;
        }
    }
}