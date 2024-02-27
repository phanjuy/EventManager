namespace EventManager.Entities;

public class EventDto
{
    public Guid EventId { get; set; }
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public DateTimeOffset DateTime { get; set; }
}
