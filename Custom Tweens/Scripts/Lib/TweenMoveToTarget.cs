using UnityEngine;
using DG.Tweening;

// This script creates a tween that moves a Transform to a target position over time.
public class TweenMoveToTarget : CustomTweenTemplate<Transform, Vector3>
{
    // Overrides from the base class.
    protected override Transform Tweener { get; set; }
    protected override Vector3 StartState { get; set; }

    [Header("Set the target transform.")]
    [SerializeField] Transform targetTransform;

    // Original position of the transform
    private Vector3 startPosition = new Vector3();

    protected override void Start()
    {
        // Set the tweener and start state at the start of the script.
        Tweener = transform;
        startPosition = transform.position;
        StartState = transform.position;
        base.Start();
    }

    public override void Play()
    {
        // Stop any previous tween and start a new one to move the Transform to the target position.
        Stop();
        Tweener.DOMove(targetTransform.position, duration);
    }

    public override void Reverse()
    {
        // Stop any previous tween and start a new one to move the Transform back to its original position.
        Stop();
        Tweener.DOMove(StartState, duration);
    }

    public override void Stop()
    {
        // Stop the current tween.
        Tweener.DOKill();
    }

    public override void Restart()
    {
        // Stop the current tween and reset the Transform's position.
        base.Restart();
    }

    // Define the methods for setting and resetting the origin.
    public override void SetOrigin()
    {
        // Set the starting position.
        if (Tweener != null)
            StartState = Tweener.position;
    }

    public override void ResetToOrigin()
    {
        // Reset to the starting position.
        if (Tweener != null)
            Tweener.position = StartState;
    }
}
