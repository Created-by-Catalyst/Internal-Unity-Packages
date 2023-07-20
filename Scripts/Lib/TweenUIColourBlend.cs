using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(Image))]
public class TweenUIColourBlend : CustomTweenTemplate<Image, Color>
{
    // Overrides from the base class.
    protected override Image Tweener { get; set; }
    protected override Color StartState { get; set; }

    // Define the properties specific to this tween.
    [Header("Set the target colour")]
    [SerializeField] Color targetColor = Color.white;


    protected override void Start()
    {
        Tweener = GetComponent<Image>();
        StartState = Tweener.color;
        base.Start();
    }

    public override void Play()
    {
        Stop();
        Tweener.DOBlendableColor(targetColor, duration).SetLoops(looping ? -1 : 1, loopType).SetEase(animationCurve);
    }

    public override void Reverse()
    {
        Stop();
        Tweener.DOBlendableColor(StartState, duration).SetLoops(looping ? -1 : 1, loopType).SetEase(animationCurve);
    }

    public override void Stop()
    {
        Tweener.DOKill();
    }


    public override void SetOrigin()
    {
        if (Tweener != null)
            StartState = Tweener.color;
    }

    public override void ResetToOrigin()
    {
        if (Tweener != null)
            Tweener.color = StartState;
    }
}
