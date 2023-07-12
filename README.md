# Unity Events Extension Package

---
- [Home](https://github.com/Created-by-Catalyst/Internal-Unity-Packages/tree/development)

## Requirements

### Unity
This package requires Unity version 2021.2.15 or later.

> [!note] Compatibility with other versions of Unity is not guaranteed.


---
## Core

### Event Extensions
The Event Extensions are scripts that add various parameters to Unity events, such as `BoolEvent.cs`, which is a Unity event that passes a boolean value.

### Sequences
`Sequences` include `DelayEvent.cs` and `EventSequence.cs`. `DelayEvent.cs` holds a Unity event and a delay value. `EventSequence.cs` contains `DelayEvent` objects and iterates through each event upon call, invoking the event after the specified delay.

---
## Library

#### MonoBehaviour Events

#### CollisionEvents
The `CollisionEvents.cs` script triggers Unity events upon collision events.

#### ToggleEvents
`ToggleEvents.cs` is a MonoBehaviour that triggers Unity events depending on the GameObject's toggle state.
