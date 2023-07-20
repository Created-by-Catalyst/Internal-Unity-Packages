using DG.Tweening;
using UnityEngine;

public class TweenMoveToPoint : CustomTweenTemplate<Transform, Vector3>
{
    // Overrides from the base class.
    protected override Transform Tweener { get; set; }
    protected override Vector3 StartState { get; set; }

    [Header("Set the target Position.")]
    [SerializeField] Vector3 targetPosition;


    protected override void Start()
    {
        Tweener = transform;
        StartState = transform.position;
        base.Start();
    }

    public override void Play()
    {
        Stop();
        Tweener.DOMove(targetPosition, duration).SetLoops(looping ? -1 : 1, loopType).SetEase(animationCurve);
    }

    public override void Reverse()
    {
        Stop();
        Tweener.DOMove(StartState, duration).SetLoops(looping ? -1 : 1, loopType).SetEase(animationCurve);
    }

    public override void Stop()
    {
        Tweener.DOKill();
    }

    public override void SetOrigin()
    {
        if (Tweener != null)
            StartState = Tweener.position;
    }

    public override void ResetToOrigin()
    {
        if (Tweener != null)
            Tweener.position = StartState;
    }
}
