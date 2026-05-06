# Review Journal

The cases below are the review handles I would use before changing the implementation.

The local checks classify each case as `ship`, `watch`, or `hold`. That gives the project a small review vocabulary that matches its observability focus without claiming live deployment or external usage.

## Cases

- `baseline`: `span volume`, score 173, lane `ship`
- `stress`: `latency skew`, score 191, lane `ship`
- `edge`: `signal loss`, score 182, lane `ship`
- `recovery`: `incident shape`, score 165, lane `ship`
- `stale`: `span volume`, score 175, lane `ship`

## Note

This file is intentionally plain so the fixture remains the source of truth.
