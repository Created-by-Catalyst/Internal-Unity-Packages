using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

[RequireComponent(typeof(RectTransform))]
public class TweenUIPunchScale : CustomTweenTemplate<RectTransform, Vector3>
{
    protected override RectTransform Tweener { get; set; }
    protected override Vector3 StartState { get; set; }

    [Header("Punch Scale Settings")]
    [SerializeField] private Vector3 punch = new Vector3(0.1f, 0.1f, 0.1f);

    [Header("Set the vibrato.")]
    [SerializeField] int vibrato = 10;

    [Header("Set the elasticity 0-1.")]
    [Range(0, 1)]
    [SerializeField] float elasticity;

    private void Awake()
    {
        Tweener = GetComponent<RectTransform>();
        StartState = Tweener.localScale;
    }

    public override void Play()
    {
        Tweener.DOPunchScale(punch, duration, vibrato, elasticity)
        .SetLoops(looping ? -1 : 1, loopType)
        .SetEase(animationCurve);
    }

    public override void Reverse()
    {
        Tweener.DOPunchScale(punch, duration, vibrato, elasticity)
        .SetInverted()
        .SetLoops(looping ? -1 : 1, loopType)
        .SetEase(animationCurve);
    }

    public override void Stop()
    {
        Tweener.DOKill();
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
