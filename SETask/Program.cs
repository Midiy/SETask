// See https://aka.ms/new-console-template for more information

List<Func<int>> counterProviders = new();

for (int i = 0; i < 10; i++)
{
    int counterValue = i;
    counterProviders.Add(() => counterValue);
}

IEnumerable<string> outputStrings = counterProviders.Select(provider => provider?.Invoke().ToString("X") ?? string.Empty);
foreach (string outputString in outputStrings)
    Console.WriteLine(outputString);
