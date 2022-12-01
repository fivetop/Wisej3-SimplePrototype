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
    public class DeviceChannelsController : ApiController
    {
        private simplePAEntities db = new simplePAEntities();

        // GET: api/DeviceChannels
        public IQueryable<DeviceChannel> GetDeviceChannel()
        {
            return db.DeviceChannel;
        }

        // GET: api/DeviceChannels/5
        [ResponseType(typeof(DeviceChannel))]
        public async Task<IHttpActionResult> GetDeviceChannel(int id)
        {
            DeviceChannel deviceChannel = await db.DeviceChannel.FindAsync(id);
            if (deviceChannel == null)
            {
                return NotFound();
            }

            return Ok(deviceChannel);
        }

        // PUT: api/DeviceChannels/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutDeviceChannel(int id, DeviceChannel deviceChannel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != deviceChannel.DeviceChnnelId)
            {
                return BadRequest();
            }

            db.Entry(deviceChannel).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeviceChannelExists(id))
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

        // POST: api/DeviceChannels
        [ResponseType(typeof(DeviceChannel))]
        public async Task<IHttpActionResult> PostDeviceChannel(DeviceChannel deviceChannel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.DeviceChannel.Add(deviceChannel);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = deviceChannel.DeviceChnnelId }, deviceChannel);
        }

        // DELETE: api/DeviceChannels/5
        [ResponseType(typeof(DeviceChannel))]
        public async Task<IHttpActionResult> DeleteDeviceChannel(int id)
        {
            DeviceChannel deviceChannel = await db.DeviceChannel.FindAsync(id);
            if (deviceChannel == null)
            {
                return NotFound();
            }

            db.DeviceChannel.Remove(deviceChannel);
            await db.SaveChangesAsync();

            return Ok(deviceChannel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DeviceChannelExists(int id)
        {
            return db.DeviceChannel.Count(e => e.DeviceChnnelId == id) > 0;
        }
    }
}