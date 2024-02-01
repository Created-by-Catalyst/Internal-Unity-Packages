using DG.Tweening;
using UnityEngine;

// This is an abstract base class for creating a custom tween effect.
// It uses generics to allow for different types of tweens (e.g., float, Vector3, etc).
public abstract class CustomTweenTemplate<T1, T2> : CustomTween
{
    // The object that performs the tweening.
    protected abstract T1 Tweener { get; set; }

    // The initial state of the object before the tween begins.
    protected abstract T2 StartState { get; set; }

    [Header("Set tween duration.")]
    // The length of time the tween effect should take to complete.
    [SerializeField] public float duration = 1f;

    [SerializeField] protected bool looping;

    [SerializeField] protected LoopType loopType;

    [SerializeField] protected AnimationCurve animationCurve = new AnimationCurve(new Keyframe(0, 0), new Keyframe(1,1));

    // Called when the script instance is being loaded.
    protected override void Start()
    {
        // Set the initial state.
    }

    // Called when the script is enabled.
    protected override void OnEnable()
    {
        // Set the initial state.
    }

    // Called when the script is disabled.
    protected override void OnDisable()
    {
        // Reset the object to its initial state.
        ResetToOrigin();
    }

    // These are abstract methods that must be implemented in a derived class.
    public override void Play() { } // Start or resume the tween.
    public override void Reverse() { } // Reverse the direction of the tween.
    public override void Stop() { } // Stop the tween.
    public override void Restart() // Restart the tween from the beginning.
    {
        Stop(); // First, stop the current tween.
        ResetToOrigin(); // Then, reset to the initial state.
    }
    public override void PlayFromStart() // Restart and play the tween from the beginning.
    {
        Stop(); // First, stop the current tween.
        Restart(); // Restart the tween from the initial state.
        Play(); // Then, start playing the tween.
    }
    public override void SetOrigin() { } // Set the initial state of the tween.
    public override void ResetToOrigin() { } // Reset the object to its initial state.

}
