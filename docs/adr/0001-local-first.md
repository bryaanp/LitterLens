# ADR-0001 — Local-first processing (Proposed)

**Date:** 2026-10-17  
**Status:** Proposed / not yet approved

## Context

Video is captured in a private living area and the use case is narrow (one litter box). Continuous cloud video transport imposes privacy, networking, and cost overhead. A household computer is likely available for initial development.

## Decision

Process the camera stream locally, produce visit-level events, retain clips only where desired, and keep the MVP operable without cloud. Separate the edge model worker from ASP.NET Core application responsibilities through explicit HTTP/JSON contract.

## Consequences

- Privacy and lower recurring cost; fewer external dependencies.
- Local hardware and physical access are needed for uptime and maintenance.
- Remote phone access requires a safe access method (VPN/tunnel or authenticated cloud API), not public camera port forwarding.
- ML training may be offloaded temporarily to a development GPU or cloud job if needed.

## Alternatives

- Always-cloud streaming: easy centralized compute, costly and privacy-sensitive.
- Jetson day one: capable but purchase premature before dataset/camera validation.
- Direct C# ONNX edge: viable after model/inference contract stabilizes.
