using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class TweenColourBlend : CustomTweenTemplate<Material, Color>
{
    // Overrides from the base class.
    protected override Material Tweener { get; set; }
    protected override Color StartState { get; set; }

    // Define the properties specific to this tween.
    [Header("Set the target colour")]
    [SerializeField] Color targetColor = Color.white;

    protected override void Start()
    {
        Tweener = GetComponent<Renderer>().material;
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
