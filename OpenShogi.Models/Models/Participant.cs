namespace OpenShogi.Models.Models;

public record Participant
{
    public string LastName { get; init; } = "";
    public string FirstName { get; init; } = "";
    public string Nationality { get; init; } = "";
    public int Elo { get; init; }
}
