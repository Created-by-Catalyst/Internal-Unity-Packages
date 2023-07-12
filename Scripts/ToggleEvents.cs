using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ToggleEvents : MonoBehaviour
{
    //[SerializeField] bool startToggleOn;
    //[SerializeField] bool emitOnEnable;
    [SerializeField] UnityEvent toggleOn;
    [SerializeField] UnityEvent toggleOff;

    private bool currentToggle;

    private void Start()
    {
        //EmitToggle(startToggleOn);
        //currentToggle = startToggleOn;
    }

    //private void OnEnable()
    //{
    //    if (emitOnEnable)
    //    {
    //        EmitToggle(startToggleOn);
    //    }
    //    currentToggle = startToggleOn;
    //}

    private void EmitToggle(bool toggle)
    {
        if (toggle)
        {
            toggleOn?.Invoke();
        }
        else
        {
            toggleOff?.Invoke();
        }
        currentToggle = toggle;
    }

    private void EmitToggleOn()
    {
        if (toggleOn == null) { return; }
        toggleOn?.Invoke();
    }

    private void EmitToggleOff()
    {
        if (toggleOff == null) { return; }
        toggleOff?.Invoke();
    }

    public void Toggle()
    {
        currentToggle = !currentToggle;
        EmitToggle(currentToggle);
        
    }

    public void SetToggleSilent(bool enable)
    {
        currentToggle = enable;
    }

    public void SetEnabled(bool enable)
    {
        currentToggle = enable;
        EmitToggle(currentToggle);
    }
}
