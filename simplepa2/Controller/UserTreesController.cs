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
    public class UserTreesController : ApiController
    {
        private simplePAEntities db = new simplePAEntities();

        // GET: api/UserTrees
        public IQueryable<UserTrees> GetUserTrees()
        {
            return db.UserTrees;
        }

        // GET: api/UserTrees/5
        [ResponseType(typeof(UserTrees))]
        public async Task<IHttpActionResult> GetUserTrees(int id)
        {
            UserTrees userTrees = await db.UserTrees.FindAsync(id);
            if (userTrees == null)
            {
                return NotFound();
            }

            return Ok(userTrees);
        }

        // PUT: api/UserTrees/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutUserTrees(int id, UserTrees userTrees)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != userTrees.UserTreeId)
            {
                return BadRequest();
            }

            db.Entry(userTrees).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserTreesExists(id))
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

        // POST: api/UserTrees
        [ResponseType(typeof(UserTrees))]
        public async Task<IHttpActionResult> PostUserTrees(UserTrees userTrees)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.UserTrees.Add(userTrees);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = userTrees.UserTreeId }, userTrees);
        }

        // DELETE: api/UserTrees/5
        [ResponseType(typeof(UserTrees))]
        public async Task<IHttpActionResult> DeleteUserTrees(int id)
        {
            UserTrees userTrees = await db.UserTrees.FindAsync(id);
            if (userTrees == null)
            {
                return NotFound();
            }

            db.UserTrees.Remove(userTrees);
            await db.SaveChangesAsync();

            return Ok(userTrees);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UserTreesExists(int id)
        {
            return db.UserTrees.Count(e => e.UserTreeId == id) > 0;
        }
    }
}