using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(RectTransform))]
public class TweenUIMoveToPoint : CustomTweenTemplate<RectTransform, Vector3>
{
    // Overrides from the base class.
    protected override RectTransform Tweener { get; set; }
    protected override Vector3 StartState { get; set; }

    [Header("Set the target Position.")]
    [SerializeField] Vector3 targetPosition;


    protected override void Start()
    {
        Tweener = GetComponent<RectTransform>();
        StartState = GetComponent<RectTransform>().anchoredPosition;
        base.Start();
    }

    public override void Play()
    {
        Stop();
        Tweener.DOAnchorPos(targetPosition, duration).SetLoops(looping ? -1 : 1, loopType).SetEase(animationCurve);
    }

    public override void Reverse()
    {
        Stop();
        Tweener.DOAnchorPos(StartState, duration).SetLoops(looping ? -1 : 1, loopType).SetEase(animationCurve);
    }

    public override void Stop()
    {
        Tweener.DOKill();
    }

    public override void SetOrigin()
    {
        if (Tweener != null)
            StartState = Tweener.anchoredPosition;
    }

    public override void ResetToOrigin()
    {
        if (Tweener != null)
            Tweener.anchoredPosition = StartState;
    }
}
