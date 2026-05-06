namespace CsharpMetrics;

public readonly record struct DomainReview(int Signal, int Slack, int Drag, int Confidence);

public static class DomainReviewLens
{
    public static int Score(DomainReview item) => item.Signal * 2 + item.Slack + item.Confidence - item.Drag * 3;

    public static string Lane(DomainReview item)
    {
        var score = Score(item);
        return score >= 140 ? "ship" : score >= 105 ? "watch" : "hold";
    }
}
