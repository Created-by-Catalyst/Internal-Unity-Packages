## Summary

This package extends Unity's event handling, introducing additional parameters to Unity events, sequenced events, and more.

## Components

- **Extensions:** Scripts extending Unity events with parameters (e.g., `BoolEvent.cs` passes a boolean).

- **Sequences:** Two scripts:
  - `DelayEvent.cs`: Holds a Unity event and a delay float.
  - `EventSequence.cs`: Contains `DelayEvent` objects and invokes each event after its delay.

- **CollisionEvents.cs:** A MonoBehaviour invoking Unity events on collision.

- **ToggleEvents.cs:** A MonoBehaviour invoking events based on its toggle state.

## Usage

**Extensions:**
- Attach an extension script to a GameObject.
- Add Unity events in the Inspector.
- Additional options for passing parameters appear.

**Sequences:**
- Attach `EventSequence.cs` to a GameObject.
- Add `DelayEvent` objects in the Inspector.
- `EventSequence` cycles through each event, invoking after each delay.

**CollisionEvents.cs:**
- Attach `CollisionEvents.cs` to a GameObject.
- Add Unity events in the Inspector.
- Events are invoked on collision.

**ToggleEvents.cs:**
- Attach `ToggleEvents.cs` to a GameObject.
- Add Unity events for each toggle state in the Inspector.
- Events are invoked based on the toggle state.

## Requirements

Developed and tested with Unity 2021.2.15. Compatibility with other versions not guaranteed.
