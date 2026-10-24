# Hardware Budget and Bill of Materials

Checked: **2026-10-17**, US pricing. Before tax/shipping. Retail prices, sales, and stock vary. These are **planning allowances**, not checked shopping carts.

## Configurations

| Item | Existing PC (MVP) | Raspberry Pi (low power) | Jetson (accelerated edge) |
|---|---:|---:|---:|
| Edge computer | $0 existing | $190–270 4–8GB kit | $399 listed MSRP, ~$550+ at sampled retail |
| Night-vision RTSP IP cam (one) | $55–90 | $55–90 | $55–90 |
| Storage upgrades | $0–30 | $0–60 (kit often has boot storage) | $35–100 (check kit contents) |
| Mount/cable/misc. | $15–30 | $15–30 | $15–40 |
| **Scenario subtotal** | **$70–150** | **$260–450** | **$504–820+** |

The chat overview rounds these to ~$75–150 / $260–400 / $500–800+. Actual storage and seller choice can exceed the bands.

## Concrete prices / factual checks

- **Reolink E1 Pro camera:** official Reolink E1-series store displayed **$55.29 promotional / $69.99 list**; Newegg surfaced ~$69.99. Manufacturer reports RTSP and ONVIF, night vision, and Wi-Fi. Note: confirm hardware revision and RTSP settings on the exact SKU before checkout.
- **CanaKit Raspberry Pi 5 4GB Essentials kit:** a Best Buy result displayed **$189.95** with case, 32GB microSD and PSU.
- **CanaKit Raspberry Pi 5 8GB starter kit:** a Best Buy result displayed **$269.95** with power and storage accessories.
- **Jetson Orin Nano Super Developer Kit:** NVIDIA marketplace lists **$399** but was **out of stock** when checked; a Best Buy product result displayed **$579.99**. Older NVIDIA announcements advertised $249 at launch, but do *not* treat that older number as currently obtainable.
- **Logitech C920 USB webcam:** a Newegg result displayed **$61.33**, but it lacks integrated IR night-vision and requires USB to an always-on computer; a plug-in RTSP camera is better for this use case.

## Buy / no-buy gates

1. Do not buy a Jetson until one camera angle provides identifiable visuals, model feasibility is tested, and your existing PC's inference speed becomes an actual bottleneck.
2. If you already have an NVIDIA GPU PC, use it for learning, data collection and training first.
3. Prefer a **powered RTSP camera** with night vision, fixed view and local access; battery/cloud-only cameras often make 24/7 integration harder.
4. If camera sees only the entrance, plan for *identity and visit detection only* in phase 1. It may be fundamentally insufficient to classify waste type.
5. If using the newer Litter-Robot 5 or 5 Pro, consider whether proprietary WasteID/visual identification already solves the use case before building your own vision models.
6. Budget optionally for **second camera** (another ~$55–90) once coverage has been tested, not before.

## Operating costs

- Local: electricity, potential drive wear and camera hardware; software used here can be open-source subject to licenses. Power draw and local kWh rates determine electricity costs.
- Cloud: avoid at first; recurring costs for inference/storage/ML training vary by region, usage, and retention.

## Sources

1. Reolink store — https://store.reolink.com/us/e1-series-cameras/
2. Reolink camera RTSP support — https://support.reolink.com/articles/900000617826-Which-Reolink-Products-Support-CGI-RTSP-ONVIF/
3. Reolink E1 Pro details — https://business.reolink.com/us/product/e1-pro/
4. NVIDIA Jetson marketplace — https://marketplace.nvidia.com/en-us/enterprise/robotics-edge/jetson-orin-nano-super-developer-kit/
5. Best Buy Pi 5 4GB kit — https://www.bestbuy.com/product/canakit-raspberry-pi-5-essentials-kit-turbine-4gb-clear/JXS4YQCX43/sku/6633698
6. Best Buy Pi 5 8GB kit — https://www.bestbuy.com/product/canakit-raspberry-pi-5-starter-kit-turbine-8gb-black/JXS4YQCXZF/sku/6633697
7. Best Buy Jetson listing — https://www.bestbuy.com/product/nvidia-945-13766-0000-000-jetson-orin-nano-super-developer-kit/J3L2TZ9QPS/sku/13168061
8. Litter-Robot 4 SmartScale identification limits — https://www.litter-robot.com/ca/smartscale
9. Litter-Robot 5 features / WasteID — https://www.litter-robot.com/litter-robot-5.html
10. Litter-Robot 5 Pro integrated cameras — https://www.litter-robot.com/litter-robot-5-pro.html

Important: Price bands will be updated after answering the discovery questionnaire.
