using System;

class Program
{
    static void Main(string[] args)
    {
        string version = "6.0.0";
        string environment = Environment.GetEnvironmentVariable("RELEASE_ENVIRONMENTNAME") ?? "Unknown";
        Console.WriteLine($"Hello World version {version} from {environment} environment");
    }
}