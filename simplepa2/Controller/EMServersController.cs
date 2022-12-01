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
    public class EMServersController : ApiController
    {
        private simplePAEntities db = new simplePAEntities();

        // GET: api/EMServers
        public IQueryable<EMServer> GetEMServer()
        {
            return db.EMServer;
        }

        // GET: api/EMServers/5
        [ResponseType(typeof(EMServer))]
        public async Task<IHttpActionResult> GetEMServer(int id)
        {
            EMServer eMServer = await db.EMServer.FindAsync(id);
            if (eMServer == null)
            {
                return NotFound();
            }

            return Ok(eMServer);
        }

        // PUT: api/EMServers/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutEMServer(int id, EMServer eMServer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != eMServer.EMServerId)
            {
                return BadRequest();
            }

            db.Entry(eMServer).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EMServerExists(id))
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

        // POST: api/EMServers
        [ResponseType(typeof(EMServer))]
        public async Task<IHttpActionResult> PostEMServer(EMServer eMServer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.EMServer.Add(eMServer);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = eMServer.EMServerId }, eMServer);
        }

        // DELETE: api/EMServers/5
        [ResponseType(typeof(EMServer))]
        public async Task<IHttpActionResult> DeleteEMServer(int id)
        {
            EMServer eMServer = await db.EMServer.FindAsync(id);
            if (eMServer == null)
            {
                return NotFound();
            }

            db.EMServer.Remove(eMServer);
            await db.SaveChangesAsync();

            return Ok(eMServer);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EMServerExists(int id)
        {
            return db.EMServer.Count(e => e.EMServerId == id) > 0;
        }
    }
}