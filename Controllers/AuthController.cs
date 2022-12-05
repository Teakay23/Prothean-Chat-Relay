using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Prothean_Chat_Relay.Models;
using Microsoft.AspNetCore.Identity;
using PusherServer;

namespace Prothean_Chat_Relay.Controllers
{
    public class AuthController : Controller
    {
        private readonly GroupChatContext _context;

        private readonly UserManager<ApplicationUser> _userManager;

        public AuthController(GroupChatContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [HttpPost]
        public IActionResult ChannelAuth(string channel_name, string socket_id)
        {
            int group_id;
            if (!User.Identity.IsAuthenticated)
            {
                return new ContentResult { Content = "Access forbidden", ContentType = "application/json" };
            }

            try
            {
                group_id = Int32.Parse(channel_name.Replace("private-", ""));
            }
            catch (FormatException e)
            {
                return Json(new { Content = e.Message });
            }

            var IsInChannel = _context.UserGroup
                                        .Where(gb => gb.GroupId == group_id
                                            && gb.UserName == _userManager.GetUserName(User))
                                        .Count();

            if (IsInChannel > 0)
            {
                var options = new PusherOptions
                {
                    Cluster = "ap2",
                    Encrypted = true
                };
                
                var pusher = new Pusher("1514529", "fb6e3e7a51211b3164aa", "9effe79fa8fca4f041a9", options);
                var auth = pusher.Authenticate(channel_name, socket_id).ToJson();

                return new ContentResult { Content = auth, ContentType = "application/json" };
            }

            return new ContentResult { Content = "Access forbidden", ContentType = "application/json" };
        }
    }
}