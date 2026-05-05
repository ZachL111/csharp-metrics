using CsharpMetrics;

public static class PolicyTests
{
    public static void Run()
    {
        var signalcase_1 = new Signal(52, 82, 8, 7, 9);
        if (Policy.Score(signalcase_1) != 189) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_1) != "accept") throw new Exception("decision mismatch");
        var signalcase_2 = new Signal(59, 75, 27, 17, 8);
        if (Policy.Score(signalcase_2) != 102) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_2) != "review") throw new Exception("decision mismatch");
        var signalcase_3 = new Signal(97, 74, 15, 15, 13);
        if (Policy.Score(signalcase_3) != 241) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_3) != "accept") throw new Exception("decision mismatch");
    }
}
