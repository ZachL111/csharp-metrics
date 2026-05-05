namespace CsharpMetrics;

public readonly record struct Signal(int Demand, int Capacity, int Latency, int Risk, int Weight);

public static class Policy
{
    private const int Threshold = 151;
    private const int RiskPenalty = 5;
    private const int LatencyPenalty = 2;
    private const int WeightBonus = 6;

    public static int Score(Signal signal) =>
        signal.Demand * 2 + signal.Capacity + signal.Weight * WeightBonus
        - signal.Latency * LatencyPenalty - signal.Risk * RiskPenalty;

    public static string Classify(Signal signal) => Score(signal) >= Threshold ? "accept" : "review";
}
