namespace Shortly.Client.Data.Models;

public class Url
{
    public int Id { get; set; }

    public string OriginalLink { get; set; } = string.Empty;

    public string ShortenLink { get; set; } = string.Empty;

    public int NumberOfClicks { get; set; }

    public int? UserId { get; set; }

    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.Now;

    public DateTimeOffset UpdatedAt { get; set; } = DateTimeOffset.Now;
}
