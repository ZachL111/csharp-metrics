# csharp-metrics

`csharp-metrics` is a compact C# repository for observability, centered on this goal: Expose counters, gauges, histograms, and text-format fixtures.

## Problem It Tries To Make Smaller

I want this repository to be useful as a quick reading exercise: fixtures first, implementation second, verifier last.

## Csharp Metrics Review Notes

`stress` and `recovery` are the cases worth reading first. They show the optimistic and cautious ends of the fixture.

## Working Pieces

- `fixtures/domain_review.csv` adds cases for span volume and latency skew.
- `metadata/domain-review.json` records the same cases in structured form.
- `config/review-profile.json` captures the read order and the two review questions.
- `examples/csharp-metrics-walkthrough.md` walks through the case spread.
- The C# code includes a review path for `latency skew` and `incident shape`.
- `docs/field-notes.md` explains the strongest and weakest cases.

## Design Notes

The repository has two validation layers: the original compact policy fixture and the domain review fixture. They are separate so one can change without hiding failures in the other.

The added C# path is deliberately direct, with fixtures doing most of the explaining.

## Example Run

```powershell
powershell -NoProfile -ExecutionPolicy Bypass -File scripts/verify.ps1
```

## Tests

The verifier is intentionally local. It should fail if the fixture score math, lane assignment, or language-specific test drifts.

## Known Limits

No external service is required. A deeper version would add more negative cases and a clearer boundary around invalid input.
