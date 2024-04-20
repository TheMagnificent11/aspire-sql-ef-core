using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

namespace AspireSqlEfCore.Components.Pages;

public partial class Home
{
    [Inject]
    private TicketContext Context { get; set; }

    [SupplyParameterFromForm]
    private SupportTicket Ticket { get; set; } = new();

    private List<SupportTicket> Tickets { get; set; } = [];

    protected override async Task OnInitializedAsync()
    {
        this.Tickets = await this.Context.Tickets.ToListAsync();
    }

    private void ClearForm() => this.Ticket = new();

    private async Task HandleValidSubmit()
    {
        this.Context.Tickets.Add(this.Ticket);
        await this.Context.SaveChangesAsync();
        this.Tickets = await this.Context.Tickets.ToListAsync();
    }
}
