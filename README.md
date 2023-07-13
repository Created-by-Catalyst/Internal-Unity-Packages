# Input Reader
- [Home](https://github.com/Created-by-Catalyst/Internal-Unity-Packages/tree/development)

## Requirements

### Unity Input System
InputReader is built on top of the Unity Input System package, which must be installed in your Unity project.

### Unity Events Extension
[UnityEventsExtension](https://github.com/Created-by-Catalyst/Internal-Unity-Packages/tree/UnityEventsExtension) is built on top of the Unity events system, which must be installed in your Unity project.


> [!note]
> Make sure you have the Unity Input System package and Unity Events Extension package installed and configured in your project.

## Core

### InputReader
The `InputReader` script is responsible for handling input events based on the specified input action asset and action map name. It provides methods for enabling and disabling input actions, as well as invoking events for input updates.

### InputEvent
The `InputEvent` class represents an individual input event associated with an `InputAction`. It defines the callbacks for when the action is performed or canceled and provides events for input enter and exit, as well as value updates.

## Usage

1. Create an `InputActionAsset` in the Unity Input System and define your desired input actions.
2. Attach the `InputReader` script to a GameObject in your scene.
3. Assign the appropriate `InputActionAsset` and specify the action map name in the `InputData` component of the `InputReader` script.
4. Configure the input events by adding `InputEvent` objects to handle specific actions and define the desired behavior using Unity events.

Feel free to adjust and customize the readme as needed to provide more specific information about your InputReaders package.