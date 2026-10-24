# Discovery Questionnaire — Please Answer

*Answer with short phrases; "unknown" is fine. Questions 1–5 are most architecture-changing.*

## Tier 1 — Design blockers

1. **Exact Litter-Robot model:** LR3, LR4, LR5, LR5 Pro, EVO, or other? Are robot weight/history readings visible in the Whisker app?
   - Answer: TBD
2. **Computers already owned:** Windows desktop/laptop, always-on mini PC, spare Raspberry Pi, GPU (model), NAS, or server? Can any remain on continuously?
   - Answer: TBD
3. **Budget:** hard cap for incremental hardware (e.g., <=$150, ~$300, ~$600, flexible)? Is there a recurring-cost cap?
   - Answer: TBD
4. **Camera position and visibility:** Can you safely put a plug-in camera 2–5 ft away from the entrance? Is there a nearby outlet and good Wi-Fi? Can a camera see into the globe, or only approaching/exiting cats? Can you provide a rough floor plan or photo later?
   - Answer: TBD
5. **Definition of success:** Is it enough to track the cat identity + visit count, or must the pee/poop result be reliable and automatically logged? Are `unknown` or manual-review outcomes acceptable?
   - Answer: TBD

## Tier 2 — Product behavior

6. Number of cats and how visually different they are; how similar their weights are? Any frequent simultaneous approaches?
   - Answer: TBD
7. Should the system be local-only, or accessible on your phone while away from home? Is cloud usage acceptable for model training or video?
   - Answer: TBD
8. Will video be stored: never, only uncertain visits, all visits for N days, or as long as needed for initial labeling?
   - Answer: TBD
9. Would you rather build a web UI (React/Blazor), a simple desktop UI, or start with an API and review page?
   - Answer: TBD
10. Which technical learning goals matter most: C#/.NET architecture, CV model training, Azure deployment/MLOps, embedded hardware, or portfolio polish?
   - Answer: TBD

## Tier 3 — Engineering constraints

11. Are you comfortable with a Python ML worker plus C# backend, or would you prefer C# end-to-end using ONNX Runtime when possible?
   - Answer: TBD
12. Is the robot in a private, low-light, dusty, or high-traffic room? Are automatic cleaning cycles or robot movement likely to obscure the view?
   - Answer: TBD
13. How many weeks/months would you allocate to data collection and training? Would you manually label ambiguous clips?
   - Answer: TBD
14. Do you want alerts only for unusual patterns, routine notifications for every visit, or simply a history dashboard?
   - Answer: TBD

## After answers arrive

Update assumptions in `README.md`, refine cost scenarios, lock camera placement and form factor, resolve ADRs, and specify an MVP acceptance test with measurable targets.
