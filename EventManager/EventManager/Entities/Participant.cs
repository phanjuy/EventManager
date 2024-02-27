namespace EventManager.Entities;

public class Participant
{
    public Guid ParticipantId { get; set; }
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public string EmailAddress { get; set; } = default!;
    public int CountryCode { get; set; }
    public int PhoneNumber { get; set; }
}
