# LitterLens Python worker

Run from the repository root:

```powershell
uv sync --project src/edge --locked
uv run --project src/edge --locked litterlens-edge
```

Currently prints a startup status and exits. Capture, detection, visit segmentation,
and buffered delivery remain planned.
