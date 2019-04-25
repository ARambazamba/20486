using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace SkillsApi
{
    // [Authorize]
    [Route("api/skills")]
    public class SkillsController : Microsoft.AspNetCore.Mvc.Controller
    {
        private IHubContext<SkillHub> skillHub;
        private SkillDBContext ctx;

        public SkillsController(IHubContext<SkillHub> hub, SkillDBContext dbctx)
        {
            skillHub = hub;
            ctx = dbctx;
        }

        // http://localhost:5000/api/skills
        [HttpGet]
        public Skill[] Get()
        {
            return this.ctx.Skills.ToArray();
        }

        // http://localhost:5000/api/skills/1
        [HttpGet("{id}")]
        public Skill Get(int id)
        {
            return ctx.Skills.FirstOrDefault(v => v.id == id);
        }

        [HttpGet]
        [Route("init")]
        public IActionResult Init()
        {
            BroadcastMarkers();
            return Ok();
        }

        // http://localhost:5000/api/skills
        //Sample payload for POST
        // {
        //     "name": "Angular"
        // }
        [HttpPost]
        public IActionResult Post([FromBody]Skill m)
        {
            if (m.id == 0)
            {
                ctx.Skills.Add(m);
            }
            else
            {
                ctx.Skills.Attach(m);
                ctx.Entry(m).State = EntityState.Modified;
            }

            ctx.SaveChanges();
            BroadcastMarkers();
            return Ok();
        }

        [HttpPut]
         public ActionResult Put([FromBody]Skill value) //Classic .NET Core WebApi pattern: public void Put(int id, [FromBody]Skill value)
        {
            ctx.Skills.Attach(value);
            ctx.Entry(value).State = EntityState.Modified;
            ctx.SaveChanges();
            return Ok(value);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var v = ctx.Skills.FirstOrDefault(m => m.id == id);
            if (v != null)
            {
                ctx.Remove(v);
                ctx.SaveChanges();
            }
            BroadcastMarkers();
            return Ok();
        }

        private void BroadcastMarkers()
        {
            Skill[] markers = this.ctx.Skills.ToArray();
            skillHub.Clients.All.SendAsync("skillsChanged", markers);
        }
    }
}
