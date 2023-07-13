using System;
using UnityEngine;
using UnityEngine.InputSystem;

[Serializable]
public class InputData
{
    [SerializeField] InputActionAsset inputActionAsset;
    public InputActionAsset InputActionAsset { get { return inputActionAsset; } }
    [SerializeField] string _actionMapName = "Keyboard";
    public string actionMapName { get { return _actionMapName; } }
    [SerializeField] InputEvent[] _inputEvents;
    public InputEvent[] inputEvents { get { return _inputEvents; } }
}