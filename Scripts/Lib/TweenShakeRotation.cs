using UnityEngine;
using DG.Tweening;

public class TweenShakeRotation : CustomTweenTemplate<Transform, Quaternion>
{
    protected override Transform Tweener { get; set; }
    protected override Quaternion StartState { get; set; }

    [Header("Shake Rotation Settings")]
    [SerializeField] private Vector3 strength = new Vector3(1, 1, 1);

    [Header("Set the vibrato.")]
    [SerializeField] int vibrato = 10;

    [Header("Set the randomness, 0-90.")]
    [SerializeField] float randomness = 90;

    protected override void Start()
    {
        Tweener = transform;
        StartState = Tweener.rotation;
        base.Start();
    }

    public override void Play()
    {
        Tweener.DOShakeRotation(duration, strength, vibrato, randomness).SetLoops(looping ? -1 : 1, loopType).SetEase(animationCurve);
    }

    public override void Reverse()
    {
        Tweener.DOShakeRotation(duration, strength, vibrato, randomness).SetInverted().SetLoops(looping ? -1 : 1, loopType).SetEase(animationCurve);
    }

    public override void Stop()
    {
        Tweener.DOKill();
    }

    public override void SetOrigin()
    {
        if (Tweener != null)
            StartState = Tweener.rotation;
    }

    public override void ResetToOrigin()
    {
        if (Tweener != null)
            Tweener.rotation = StartState;
    }
}
