using DG.Tweening;
using DG.Tweening.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Profiling;

[RequireComponent(typeof(RectTransform))]
public class TweenUIScale : CustomTweenTemplate<RectTransform, Vector2>
{
    // Overrides from the base class.
    protected override RectTransform Tweener { get; set; }
    protected override Vector2 StartState { get; set; }

    [Header("Set the target size.")]
    [SerializeField] Vector2 targetSize = new Vector2(1,1);


    protected override void Start()
    {
        Tweener = GetComponent<RectTransform>();
        StartState = Tweener.sizeDelta; // Use sizeDelta instead
        base.Start();
    }


    public override void Play()
    {
        Stop();
        Tweener.DOSizeDelta(targetSize, duration).SetLoops(looping ? -1 : 1, loopType).SetEase(animationCurve);               
    }


    public override void Reverse()
    {
        Stop();
        Tweener.DOSizeDelta(StartState, duration).SetLoops(looping ? -1 : 1, loopType).SetEase(animationCurve);
    }


    public override void Stop()
    {
        Tweener.DOKill();
    }

    public override void SetOrigin()
    {
        if (Tweener != null)
            StartState = Tweener.sizeDelta;
    }

    public override void ResetToOrigin()
    {
        if (Tweener != null)
            Tweener.sizeDelta = StartState;
    }
}
