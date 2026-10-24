"""LitterLens worker startup check; camera processing comes next."""

import json
import platform


def main() -> None:
    print(json.dumps({
        "service": "litterlens-edge",
        "status": "ready",
        "python": platform.python_version(),
        "capture_enabled": False,
    }))
