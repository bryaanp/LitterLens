# Data Model and API — Draft

## Entity sketch

**Cat**: `cat_id`, `display_name`, `profile_created_utc`, `reference_images[]`, optional weight baseline, status.

**Camera**: `camera_id`, `location_alias`, `stream_config_ref`, `hardware_version`, active status. **Never store RTSP passwords in ordinary DB text or Git.**

**Visit**: `visit_id` (unique), `camera_id`, `cat_id?`, `started_utc`, `ended_utc`, `duration_s`, `identity_confidence`, `waste_type`, `waste_confidence`, `review_status`, `edge_model_version`, `schema_version`, `clip_ref?`.

**Prediction**: `prediction_id`, `visit_id`, `prediction_type`, `model_name`, `model_version`, `label`, `confidence`, `features_ref?`, `created_utc`.

**Correction**: `correction_id`, `visit_id`, `corrected_cat_id?`, `corrected_waste_type`, `user_note?`, `truth_source`, `created_utc`.

**Job/Outbox**: `event_id` (unique), `visit_id`, payload hash, status, retry count, last error, next attempt.

## API draft (ASP.NET Core Web API)

- `POST /api/cats` add profile
- `GET /api/cats` list
- `POST /api/cats/{catId}/references` add training/reference image metadata (upload protocol TBD)
- `POST /api/visits` idempotent edge ingest (authorized service identity)
- `GET /api/visits?catId=&from=&to=&needsReview=` paginated history
- `GET /api/visits/{visitId}` event details/evidence metadata
- `POST /api/visits/{visitId}/corrections` audited user correction
- `GET /api/health` edge/app health
- `GET /api/system/edge-status` device online/last-seen, model version

## Event design

- Use explicit enums `urine | feces | both | none | unknown`.
- Separate **prediction** from **verified label**. Never mutate prediction history on user correction.
- `unknown` is a real result, not a failed request.
- Store UTC times and distinguish device clock from server received time.
- Use one event per observed visit; two cats in quick succession may require distinct sessions or an overlap flag.
- Dedup by `visit_id` and maintain raw audit of attempted submissions.

## Security

- AuthN/AuthZ on API and dashboard; local-only binding by default.
- No port-forwarding to camera; access it via LAN, protect RTSP credentials.
- Prefer short-lived pre-signed URLs for optional clip access.
- Do not treat camera content as privileged instructions to an LLM or app.
