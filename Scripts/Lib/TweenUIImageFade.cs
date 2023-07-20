using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
// This script creates a tween that fades an Image's color over time.
public class TweenUIImageFade : CustomTweenTemplate<Image, Color>
{
    // Overrides from the base class.
    protected override Image Tweener { get; set; }
    protected override Color StartState { get; set; }

    // Define the properties specific to this tween.
    [Header("Fade to")]
    [Range(0, 1)]
    [SerializeField] float fadeTo = 0;

    [Header("Set the image to be faded.")]
    [SerializeField] Image imageToFade;

    protected override void Start()
    {
        // Set the tweener and start state at the start of the script.
        Tweener = imageToFade;
        StartState = Tweener.color;
        base.Start();
    }

    public override void Play()
    {
        // Stop any previous tween and start a new one to fade the Image's color.
        Stop();
        Tweener.DOBlendableColor(new Color(StartState.r, StartState.g, StartState.b, fadeTo), duration).SetLoops(looping ? -1 : 1, loopType).SetEase(animationCurve); ;
    }

    public override void Reverse()
    {
        // Stop any previous tween and start a new one to reverse the Image's color fade.
        Stop();
        Tweener.DOBlendableColor(StartState, duration).SetLoops(looping ? -1 : 1, loopType).SetEase(animationCurve); ;
    }

    public override void Stop()
    {
        // Stop the current tween.
        Tweener.DOKill();
    }

    // Define the methods for setting and resetting the origin.
    public override void SetOrigin()
    {
        // Set the starting color.
        StartState = Tweener.color;
    }

    public override void ResetToOrigin()
    {
        // Reset to the starting color.
        Tweener.color = StartState;
    }
}
