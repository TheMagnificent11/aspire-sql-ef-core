using Microsoft.EntityFrameworkCore;

namespace AspireSqlEfCore;

public class TicketContext : DbContext
{
    public TicketContext(DbContextOptions options)
        : base(options)
    {
    }

    public DbSet<SupportTicket> Tickets => this.Set<SupportTicket>();
}
