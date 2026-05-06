# Csharp Metrics Walkthrough

The fixture is intentionally compact, so the review starts with the cases that pull farthest apart.

| Case | Focus | Score | Lane |
| --- | --- | ---: | --- |
| baseline | span volume | 173 | ship |
| stress | latency skew | 191 | ship |
| edge | signal loss | 182 | ship |
| recovery | incident shape | 165 | ship |
| stale | span volume | 175 | ship |

Start with `stress` and `recovery`. They create the widest contrast in this repository's fixture set, which makes them better review anchors than the middle cases.

If `recovery` becomes less cautious without a clear reason, I would inspect the drag input first.
