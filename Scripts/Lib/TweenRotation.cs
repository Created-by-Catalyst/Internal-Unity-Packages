using UnityEngine;
using DG.Tweening;

public class TweenRotation : CustomTweenTemplate<Transform, Quaternion>
{
    // Define the target of the tween (in this case, a Transform)
    protected override Transform Tweener { get; set; }
    // Define the initial state (here, the starting rotation)
    protected override Quaternion StartState { get; set; }

    [Header("Rotation Settings")]
    // Target rotation angles for the tween
    [SerializeField] private Vector3 rotationAngles;

    // Toggle to choose between local and world rotation
    [SerializeField] private bool isLocal = true;

    protected override void Start()
    {
        // At awake, set the tweener to this object's transform, and the start state to the current rotation
        Tweener = transform;
        StartState = isLocal ? transform.localRotation : transform.rotation;
        base.Start();
    }

    // Function to play the tween
    public override void Play()
    {
        // Depending on whether local or world rotation is selected, play the appropriate tween
        if (isLocal)
            Tweener.DOLocalRotate(rotationAngles, duration, RotateMode.FastBeyond360).SetLoops(looping ? -1 : 1, loopType).SetEase(animationCurve);
        else
            Tweener.DORotate(rotationAngles, duration, RotateMode.FastBeyond360).SetLoops(looping ? -1 : 1, loopType).SetEase(animationCurve);
    }

    // Function to reverse the tween
    public override void Reverse()
    {
        // Depending on whether local or world rotation is selected, reverse the appropriate tween
        if (isLocal)
            Tweener.DOLocalRotate(StartState.eulerAngles, duration, RotateMode.FastBeyond360).SetLoops(looping ? -1 : 1, loopType).SetEase(animationCurve);
        else
            Tweener.DORotate(StartState.eulerAngles, duration, RotateMode.FastBeyond360).SetLoops(looping ? -1 : 1, loopType).SetEase(animationCurve);
    }

    // Function to stop the tween
    public override void Stop()
    {
        // Kill the tween
        Tweener.DOKill();
    }

    // Set the starting state of the tween
    public override void SetOrigin()
    {
        if (Tweener != null)
        {
            StartState = isLocal ? Tweener.localRotation : Tweener.rotation;
        }
    }

    // Reset the object to the original state
    public override void ResetToOrigin()
    {
        if (Tweener != null)
        {
            if (isLocal)
            {
                Tweener.localRotation = StartState;
            }
            else
            {
                Tweener.rotation = StartState;
            }
        }
    }
}
