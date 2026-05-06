using CsharpMetrics;

public static class DomainReviewTests
{
    public static void Run()
    {
        var item = new DomainReview(66, 24, 22, 83);
        if (DomainReviewLens.Score(item) != 173) throw new Exception("domain score mismatch");
        if (DomainReviewLens.Lane(item) != "ship") throw new Exception("domain lane mismatch");
    }
}
