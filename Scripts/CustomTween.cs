using UnityEngine;

public abstract class CustomTween : MonoBehaviour
{
    protected virtual void Start() { }
    protected virtual void OnEnable() { }
    protected virtual void OnDisable() { }
    public virtual void Play() { }
    public virtual void Reverse() { }
    public virtual void Stop() { }
    public virtual void Restart() { }
    public virtual void PlayFromStart() { }
    public virtual void SetOrigin() { }
    public virtual void ResetToOrigin() { }
}
