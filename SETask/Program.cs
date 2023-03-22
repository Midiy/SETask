// See https://aka.ms/new-console-template for more information

List<Func<int>> counterProviders = new();

for (int i = 0; i < 10; i++)
{
    // HACK: Really bad way to do this, demonstration purposes only.
    if (i % 2 != 0)
        continue;

    counterProviders.Add(() => i * 3);
    Console.WriteLine($"From 'for': {i}.");
}

IEnumerable<string> outputStrings = counterProviders.Select(provider => provider?.Invoke().ToString("X") ?? string.Empty);
foreach (string outputString in outputStrings)
    Console.WriteLine($"From lambdas: {outputString}.");
