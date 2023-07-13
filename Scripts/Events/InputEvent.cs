using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

[Serializable]
public class InputEvent
{
    // Reference to the InputAction associated with this event
    private InputAction _inputAction;
    public InputAction inputAction { get { return _inputAction; } set { _inputAction = value; } }

    // Name of the input action
    [SerializeField] string _inputName;
    public string inputName { get { return _inputName; } }

    // Events to invoke when entering and exiting the input state
    [SerializeField] UnityEvent _inputEnterEvents;
    public UnityEvent inputEnterEvents { get { return _inputEnterEvents; } }
    [SerializeField] UnityEvent _inputExitEvents;
    public UnityEvent inputExitEvents { get { return _inputExitEvents; } }

    // Event to invoke when the input value changes
    [SerializeField] FloatEvent _valueEvents;
    public FloatEvent valueEvents { get { return _valueEvents; } }

    // Event to invoke when the input value is updated
    [SerializeField] FloatEvent _updateEvents;
    public FloatEvent updateEvents { get { return _updateEvents; } }

    // Callback method to handle the performed action event
    public void OnActionPerformed(InputAction.CallbackContext context)
    {
        // Read the input value
        float value = context.ReadValue<float>();

        // Invoke the enter events
        inputEnterEvents.Invoke();

        // Use the value as needed
        valueEvents.Invoke(value);
    }

    // Callback method to handle the cancelled action event
    public void OnActionCancelled(InputAction.CallbackContext context)
    {
        // Read the input value
        float value = context.ReadValue<float>();

        // Invoke the exit events
        inputExitEvents.Invoke();
    }
}
