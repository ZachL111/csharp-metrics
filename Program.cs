using CsharpMetrics;

if (args.Contains("--test"))
{
    PolicyTests.Run();
    return;
}

var signal = new Signal(80, 95, 12, 8, 7);
Console.WriteLine($"score={Policy.Score(signal)} decision={Policy.Classify(signal)}");
