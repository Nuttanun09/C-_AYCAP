// See https://aka.ms/new-console-template for more information
for (int i = 0; i < 5; i++)
{
    Guid id4 = Guid.CreateVersion7(); // .NewGuid(); // UUID v4
    string secret = id4.ToString();
    Console.WriteLine($"Secret: {secret}");
}