using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEditor;

public class InputReader : MonoBehaviour
{
    private InputActionMap actionMap;
    [SerializeField] InputData inputData;

    private void Update()
    {
        foreach (InputEvent inputEvent in inputData.inputEvents)
        {
            if (inputEvent.updateEvents != null)
            {
                inputEvent.updateEvents?.Invoke(inputEvent.inputAction.ReadValue<float>());
            }

        }
    }

    private void OnEnable()
    {
        foreach (InputEvent inputEvent in inputData.inputEvents)
        {
            inputEvent.inputAction?.Enable();
        }
    }

    private void OnDisable()
    {
        foreach (InputEvent inputEvent in inputData.inputEvents)
        {
            inputEvent.inputAction?.Disable();
        }
    }

    private void Awake()
    {
        InputActionAsset inputActionAsset = inputData.InputActionAsset;

        if (inputActionAsset == null) { Debug.LogError("Input Action Asset Required!"); return; }

        //  Print all input maps on this action asset.
        foreach (InputActionMap map in inputActionAsset.actionMaps)
        {
            Debug.Log(map);
        }
        // Get a reference to the Input Action Map and the desired action
        actionMap = inputActionAsset.FindActionMap(inputData.actionMapName);
        // Check if the action is valid
        if (actionMap != null)
        {
            Debug.Log($"The {inputData.actionMapName} action was found in the Input Action Asset.");
        }
        else
        {
            Debug.LogError($"The {inputData.actionMapName}  action was not found in the Input Action Asset.");
        }

        foreach (InputEvent inputEvent in inputData.inputEvents)
        {
            if (inputData.actionMapName == null)
            {
                Debug.LogError("InputActionMap not found");

                continue;
            }
            ActionSetup(inputEvent, actionMap);
        }
    }

    private void ActionSetup(InputEvent inputEvent, InputActionMap actionMap)
    {

        InputAction inputAction;
        InputActionMap inputActionMap = actionMap.Clone();

        inputAction = inputActionMap.FindAction(inputEvent.inputName).Clone();

        // Check if the action is valid
        if (inputAction != null)
        {
            Debug.Log($"The {inputEvent.inputName} action was found in the Input Action Map.");
            // Subscribe to the action's callback
            inputAction.performed += inputEvent.OnActionPerformed;
            inputAction.canceled += inputEvent.OnActionCancelled;
            inputAction.Enable();
            inputEvent.inputAction = inputAction;
        }
        else
        {
            Debug.LogError($"The {inputEvent.inputName} action was not found in the Input Action Map.");
        }
    }
}