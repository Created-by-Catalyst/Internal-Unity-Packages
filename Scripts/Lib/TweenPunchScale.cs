using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenPunchScale : CustomTweenTemplate<Transform, Vector3>
{
    // Overrides from the base class.
    protected override Transform Tweener { get; set; }
    protected override Vector3 StartState { get; set; }

    [Header("Set the target scale.")]
    [SerializeField] Vector3 targetScale;

    [Header("Set the vibrato.")]
    [SerializeField] int vibrato = 4;

    [Header("Set the elasticity 0-1.")]
    [Range(0, 1)]
    [SerializeField] float elasticity = 0.25f;


    protected override void Start()
    {
        Tweener = transform;
        StartState = transform.localScale;
        base.Start();
    }

    public override void Play()
    {
        Stop();
        Tweener.DOPunchScale(targetScale, duration, vibrato, elasticity).SetLoops(looping ? -1 : 1, loopType).SetEase(animationCurve);
    }

    public override void Stop()
    {
        Tweener.DOKill();
    }

    public override void Reverse()
    {
        Stop();
        Tweener.DOPunchScale(targetScale, duration, vibrato, elasticity).SetInverted().SetLoops(looping ? -1 : 1, loopType).SetEase(animationCurve);
    }

    public override void SetOrigin()
    {
        if (Tweener != null)
            StartState = Tweener.localScale;
    }

    public override void ResetToOrigin()
    {
        if (Tweener != null)
            Tweener.localScale = StartState;
    }
}
