using SAPI.Common;

namespace SAPI.Tests;

internal class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Starting: SAPI Tests...");
        var _client = new SynthClient("ptlc_bAOzdlOKZVfZYobqaXBuACT0f4ViSSA1VEzNnehAj5T", "https://gaming.terabit.io");

        var _user = await _client.GetUser();
        Console.WriteLine($"User Details: USERNAME: {_user?.attributes?.username} | EMAIL: {_user?.attributes?.email} | ADMIN: {_user?.attributes?.admin}");
    }
}
