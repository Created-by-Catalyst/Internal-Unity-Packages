using System.Collections;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

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

    protected override void OnEnable()
    {
        Tweener = imageToFade;
        StartState = Tweener.color;
        base.OnEnable();
    }

    public override void Play()
    {
        // Stop any previous tween and start a new one to fade the Image's color.
        Stop();
        Tweener.DOColor(new Color(StartState.r, StartState.g, StartState.b, fadeTo), duration);
    }

    public override void Reverse()
    {
        // Stop any previous tween and start a new one to reverse the Image's color fade.
        Stop();
        Tweener.DOColor(StartState, duration);
    }

    public override void Stop()
    {
        // Stop the current tween.
        Tweener.DOKill();
    }

    public override void Restart()
    {
        base.Restart();
    }

    // Define the methods for setting and resetting the origin.
    public override void SetOrigin()
    {
        // Set the starting color.
        Tweener = imageToFade;
        StartState = Tweener.color;
    }

    public override void ResetToOrigin()
    {
        // Reset to the starting color.
        Tweener.color = StartState;
    }
}
