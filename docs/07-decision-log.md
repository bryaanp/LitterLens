# Decision Log (Open)

| ID | Decision | Current default | Status / basis |
|---|---|---|---|
| D-01 | Camera count | One first; maybe second later | Open; depends on view |
| D-02 | Robot model/features | Unknown | Blocked on owner |
| D-03 | Compute | Existing PC first | Proposed, no purchase yet |
| D-04 | Offline vs cloud | Local-first | Proposed; privacy/cost |
| D-05 | API stack | ASP.NET Core | Proposed; fits developer background |
| D-06 | Edge vision | Python + OpenCV | Proposed; fastest iteration |
| D-07 | Database | SQLite first | Proposed; can change to PostgreSQL |
| D-08 | Waste classification | Best-effort + unknown | Needs ground truth |
| D-09 | Video retention | Short configurable TTL | Needs privacy/ML agreement |
| D-10 | Robot integration | Optional | Vendor API and device model not confirmed |
| D-11 | Frontend | Simple responsive web UI | Owner preference pending |
| D-12 | Deploy to Jetson/Pi | Only after profiling | Avoid premature hardware expense |

Add entries whenever a design tradeoff is resolved. Include alternatives rejected, rationale, consequences, and date.

## Confirmed development setup — 2026-10-24

- Name: LitterLens; one repository with worker and API folders.
- Python 3.13 with uv; .NET 10 API. Approved together before scaffolding.
- Keep Python metadata and its environment in `src/edge`; API in `src/api`.
- Use the installed Python 3.13 rather than installing 3.12 without a dependency compatibility need.
- Use .NET 10 rather than .NET 8 for the new project and its longer support runway.
- Docker remains a possible deployment option, not a development prerequisite.
- Learning gives equal attention to Python/computer vision and .NET; discuss major decisions together.
