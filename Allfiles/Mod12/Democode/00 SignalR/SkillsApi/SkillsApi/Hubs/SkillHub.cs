using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SkillsApi
{
    public class SkillHub : Hub
    {
        public Task BroadcastMarkers(Skill[] skills)
        {
            return Clients.All.SendAsync("skillsChanged", skills);
        }
    }
}