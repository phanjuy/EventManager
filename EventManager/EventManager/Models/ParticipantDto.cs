namespace EventManager.Entities;

public class ParticipantDto
{
    public Guid ParticipantId { get; set; }
    public string FullName { get; set; } = default!;
    public string Email { get; set; } = default!;
    public int PhoneNumber { get; set; }
}
