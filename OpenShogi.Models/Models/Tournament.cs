using OpenShogi.Models.Enums;

namespace OpenShogi.Models.Models;

public record Tournament
{
    public string Name { get; set; } = "";
    public TournamentType TournamentType { get; set; }
    public int NumberOfRounds { get; set; }
    public string Location { get; set; } = "";
    public DateTime StartDate { get; set; } = DateTime.Now;
    public DateTime EndDate { get; set; } = DateTime.Now;
    public TieBreaker FirstTieBreaker { get; set; }
    public TieBreaker? SecondTieBreaker { get; set; }
    public TieBreaker? ThirdTieBreaker { get; set; }
    public Protection? Protection { get; set; }

    public IEnumerable<Participant> Participants { get; set; } = Enumerable.Empty<Participant>();
}
