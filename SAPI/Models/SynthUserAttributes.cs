namespace SAPI.Models;

public class SynthUserAttributes
{
    public short id { get; } = 0;
    public bool admin { get; } = false;
    public string username { get; } = "Default";
    public string email { get; } = "guest@sapi";
    public string? first_name { get; } = "Guest";
    public string? last_name { get; } = "User";
    public string? language { get; } = "en";
}
