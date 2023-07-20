using DG.Tweening;
using UnityEngine;

public class TweenPunchPosition : CustomTweenTemplate<Transform, Vector3>
{
    // Overrides from the base class.
    protected override Transform Tweener { get; set; }
    protected override Vector3 StartState { get; set; }

    [Header("Set the target direction.")]
    [SerializeField] Vector3 targetDirection;

    [Header("Set the vibrato.")]
    [SerializeField] int vibrato = 4;

    [Header("Set the elasticity 0-1.")]
    [Range(0, 1)]
    [SerializeField] float elasticity = 0.25f;


    protected override void Start()
    {
        Tweener = transform;
        StartState = transform.position;
        base.Start();
    }

    public override void Play()
    {
        Stop();
        Tweener.DOPunchPosition(targetDirection, duration, vibrato, elasticity).SetLoops(looping ? -1 : 1, loopType).SetEase(animationCurve);

    }

    public override void Reverse()
    {
        Stop();
        Tweener.DOPunchPosition(targetDirection, duration, vibrato, elasticity).SetInverted().SetLoops(looping ? -1 : 1, loopType).SetEase(animationCurve);
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
