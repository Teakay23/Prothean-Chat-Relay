using Microsoft.EntityFrameworkCore;

namespace Prothean_Chat_Relay.Models
{
    public class GroupChatContext : DbContext
    {
        public GroupChatContext(DbContextOptions<GroupChatContext> options) : base(options)
        {}

        public DbSet<Group> Groups { get; set; }

        public DbSet<Message> Message { get; set; }
        
        public DbSet<UserGroup> UserGroup { get; set; }
    }
}