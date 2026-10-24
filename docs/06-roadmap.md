# Implementation Roadmap

## Phase 0 — Discovery / feasibility

- [ ] Answer questionnaire; choose robot model and success metric.
- [ ] Validate power, mounting, entrance visibility, night conditions.
- [ ] Capture a few harmless test clips with temporary camera placement.
- [ ] Decide cloud/local and video retention.

**Exit:** evidence that entrance-based identity is possible, clear scope for waste classification.

## Phase 1 — Vision + logging MVP

- [ ] Connect RTSP to OpenCV/FFmpeg; stabilize reconnection.
- [ ] Detect cats and enter/exit state machine.
- [ ] Generate one unique visit ID per visit.
- [ ] ASP.NET Core `POST /api/visits` and local persistent DB.
- [ ] Minimal history dashboard; manually label cat identity and waste type.
- [ ] Basic daily metrics and error logs.

**Exit:** reliable visit log with corrections and recordings on demand.

## Phase 2 — Identification

- [ ] Create image profiles, identity classifier/embeddings + unknown fallback.
- [ ] Aggregate across frames, build held-out test set.
- [ ] Compare camera identity against robot weight-based ID if available.

**Exit:** measured identity accuracy on completely unseen visits.

## Phase 3 — Waste classification experiment

- [ ] Prove camera footage actually captures differentiating visual information.
- [ ] Label ground truth and implement baseline posture/timing model.
- [ ] Add conservative classification/abstention; require evaluation report.
- [ ] If unsuitable, retain manual review or optional robot telemetry instead.

**Exit:** publish accuracy/coverage, including unknown rate; no misleading claims.

## Phase 4 — Harden and polish

- [ ] Outbox retry, auth, private networking, clip TTL, telemetry/health.
- [ ] Docker + deployment scripts; optional dedicated Pi/Jetson.
- [ ] Retraining/evaluation pipeline; versioned models, rollback.
- [ ] Technical architecture diagram, API contracts, tests, and a case-study README.

**Exit:** maintainable, demonstrable system with documented tradeoffs.
