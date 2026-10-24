# ML Design and Evaluation

## Decompose the problem

1. **Object detection:** cat in entrance/ROI. Off-the-shelf object detector may work initially; evaluate lighting and occlusion.
2. **Visit segmentation:** rule/state-machine grouping per approach -> entry -> exit -> timeout; keep it deterministic first.
3. **Identity classification:** two enrolled cats vs unknown. Train a simple image classifier or embedding model using labeled multi-angle crops. Aggregate evidence over several frames and reject low confidence.
4. **Waste classification:** posture/behavior temporal features **if visible**. Distinguishing actual elimination is not guaranteed from a single exterior camera. Start with `unknown`, manually labeled ground truth, and a low-complexity baseline before any video transformer.
5. **Sensor fusion:** only if Litter-Robot model and accessible event/weight telemetry permit; verify actual API compatibility.

## Dataset collection

- Save short clips around visits for first 2–4 weeks (timing TBD), respecting retention preference.
- Build labels for cat identity, entry/exit timestamps, no elimination, urine, feces, both, and unknown.
- Clearly identify truth provenance: observed clip, independent observation, litter inspection, robot WasteID, inference, or unknown.
- Capture multiple times of day, IR/night mode, post-cleaning conditions and body poses.
- Hold out entire visits/days (not arbitrary adjacent frames) to avoid leakage.
- Human correction UI supplies revised labels, not automatically assumed training truth.

## Baseline metrics

| Task | Suggested metrics |
|---|---|
| Visit detection | precision, recall, false sessions/day, split/merge rate |
| Cat identity | per-cat precision/recall, macro F1, unknown rejection / calibration |
| Waste type | class F1, confusion matrix, selective accuracy vs coverage, abstention rate |
| Operations | edge uptime, missed events during Wi-Fi loss, p95 event completion latency |

Set numerical acceptance thresholds only after data collection and observing the class balance.

## Bias and failure analysis

Cat color/pattern, lighting, camera perspective, grooming, robot movement, occlusion, low frame rate, mirrored IR illumination, and sharing the box can alter classifier quality. Do not confuse high confidence with validated accuracy. No clinical conclusions should be drawn from isolated predictions.

## Model runtime

Use Python/OpenCV + a trained model to begin. Later export ONNX and use ONNX Runtime (Python or C#) or Jetson-optimized TensorRT where validated. Make model updating explicit and reversible; record every model version per visit.
