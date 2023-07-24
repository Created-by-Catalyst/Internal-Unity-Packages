using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(CanvasGroup))]
public class TweenUICanvasGroupFade : CustomTweenTemplate<CanvasGroup, float>
{
    // Overrides from the base class.
    protected override CanvasGroup Tweener { get; set; }
    protected override float StartState { get; set; }
    [Header("Fade to")]
    [Range(0, 1)]
    [SerializeField] float fadeTo = 0;
    [Header("Set the canvas group to be faded.")]
    [SerializeField] CanvasGroup canvasGroupToFade;
    protected override void Start()
    {
        Tweener = canvasGroupToFade;
        StartState = Tweener.alpha;
        base.Start();
    }
    public override void Play()
    {
        Stop();
        Tweener.DOFade(fadeTo, duration).SetLoops(looping ? -1 : 1, loopType).SetEase(animationCurve); ;
    }
    public override void Reverse()
    {
        Stop();
        Tweener.DOFade(StartState, duration).SetLoops(looping ? -1 : 1, loopType).SetEase(animationCurve); ;
    }
    public override void Stop()
    {
        // Stop the current tween.
        Tweener.DOKill();
    }
    public override void SetOrigin()
    {
        if (Tweener != null)
            StartState = Tweener.alpha;
    }
    public override void ResetToOrigin()
    {
        // Reset to the starting color.
        if (Tweener != null)
            Tweener.alpha = StartState;
    }
}