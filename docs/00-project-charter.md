# Project Charter

## Problem

Traditional litter-robot metrics may not identify each visit reliably for cats of similar weight, or may not distinguish whether a visit produced urine, feces, both, or neither. A home-built camera-assisted monitoring system could capture more granular per-cat visit history.

## Intended users

- Primary: cat owner reviewing visit patterns and correcting predictions.
- Secondary: developer evaluating practical ML/edge/software design trade-offs.

## Functional requirements (draft)

- FR-01 Register/edit cat profiles; store one or more photo references per cat.
- FR-02 Detect a single litter-box visit (entry, dwell, exit), including repeated entry/exit edge cases.
- FR-03 Attribute a visit to Cat A, Cat B or Unknown, with a confidence and evidence record.
- FR-04 Classify the visit as urine/feces/both/none/unknown **only where evidence allows**.
- FR-05 Save start/end timestamps, model version, event state, and manual corrections.
- FR-06 Show activity history, by-cat trends and uncertain events requiring review.
- FR-07 Recover from loss of Wi-Fi, API crash, or power interruption without losing completed events.
- FR-08 Optional robot telemetry integration, subject to feasibility and permission.

## Non-functional requirements (provisional)

- Local-only mode works without cloud or subscription.
- Durable deduplicated visit IDs; at-least-once delivery from edge worker is acceptable.
- Credentials, camera streams, and raw videos are not exposed publicly.
- Lightweight storage and automatic retention policy; user controls clips kept.
- No hardware inside/on moving Litter-Robot parts or obstructing sensors.
- Accuracy measurements use **held-out complete visits**, not randomly split frames.

## Initial success gates (TBD thresholds)

1. Every observed visit receives a single deduplicated session (goal metric: visit detection recall).
2. Cat assignment performs meaningfully above weight-only baseline on held-out visits.
3. System abstains from pee/poop classification when video does not support it.
4. One-week unattended run has no critical data loss, and status is visible on dashboard.

## Explicitly not guaranteed

- Camera-only determination of urination vs defecation from a hidden/occluded litter-box interior.
- Veterinary diagnosis; do not infer illness from classifier output.
- A stable public API exposing Litter-Robot sensors or event streams.
- Fully autonomous, unsupervised ground-truth collection.
