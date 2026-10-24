# LitterLens — Computer Vision for Feline Litter-Box Monitoring

**Status:** Discovery / architecture planning  
**Created:** 2026-10-17  
**Project name:** LitterLens  
**Objective:** Observe visits to an existing Litter-Robot, associate each visit with an enrolled cat, and estimate whether the visit involved urination, defecation, both, neither, or an unknown result.

> This is a development project, not a veterinary diagnostic device. Predictions must allow uncertainty and manual correction. Never block the robot's safety sensors, entrance, moving globe, or cabling.

## Agreed development approach

- Use VS Code for local development on Windows.
- Use uv to manage Python dependencies and virtual environments; setup is pending.
- Give equal learning attention to Python/computer vision and C#/.NET backend engineering.
- Keep Docker as an option for later deployment; it is not required for initial development.
- Develop through pair programming, discussing major technical decisions before adopting them.

## Starting point

1. Fill in [`docs/01-discovery-questionnaire.md`](docs/01-discovery-questionnaire.md); especially model of Litter-Robot, hardware already owned, room layout, and priority of pee/poop accuracy.
2. Review [`docs/02-architecture.md`](docs/02-architecture.md) and open architecture decisions.
3. Confirm available budget via [`docs/03-hardware-costs.md`](docs/03-hardware-costs.md).
4. Collect consented sample videos from a safe external camera location **before** buying dedicated GPU hardware.
5. Build phase 1: enter/exit event tracking + manual labels. Delay waste-type machine learning until the data proves it can be distinguished.

## Proposed MVP boundaries

- One Litter-Robot, two enrolled cats (confirm).
- One externally mounted, fixed-angle IP camera; optional second camera after testing.
- Run inference on existing Windows PC at first; optional Linux edge worker later.
- Python/OpenCV for capture and ML; ASP.NET Core for visit API and domain logic; SQLite first or PostgreSQL when needed; optional React/Blazor UI.
- Event data stays local by default; optional cloud sync is a later decision.
- Session-based identity and event labels, with an **Unknown** option rather than guessed outcomes.

## Documentation index

| File | Purpose |
|---|---|
| `docs/00-project-charter.md` | Why, scope, success criteria, constraints |
| `docs/01-discovery-questionnaire.md` | Questions and pending answers |
| `docs/02-architecture.md` | Components, paths, failure handling, privacy |
| `docs/03-hardware-costs.md` | BOM, alternatives, sources, purchase gates |
| `docs/04-data-and-api.md` | Domain entities, API, sample payload |
| `docs/05-ml-approach.md` | Models, datasets, evaluation, risks |
| `docs/06-roadmap.md` | Iterative implementation milestones |
| `docs/07-decision-log.md` | Decisions to finalize together |
| `docs/adr/0001-local-first.md` | Architecture decision record |
| `diagrams/system-context.mmd` | Mermaid system diagram |
| `samples/visit-event.json` | Example API/event schema |

## Working assumptions (UNCONFIRMED)

We assumed you already own a Litter-Robot, want to use your C#/.NET expertise, are building a personal/portfolio project rather than a commercial product, and may have an existing computer that can remain on for development. We have **not** assumed the model/version, the exact room dimensions, whether your cats have distinct body appearance, or any guaranteed official robot API.

## Repo layout (implementation placeholders)

- `src/api/` ASP.NET Core Web API and persistence
- `src/edge/` Python RTSP, event segmentation, inference
- `src/web/` web dashboard and human labeling
- `ml/` training, evaluation, export scripts
- `infra/` local Compose and optional IaC
- `data/labels/` no committed video or personal data

The starter project intentionally contains **documentation, not untested executable application code**.
