using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

[RequireComponent(typeof(RectTransform))]
public class TweenUIPunchPosition : CustomTweenTemplate<RectTransform, Vector2>
{
    protected override RectTransform Tweener { get; set; }
    protected override Vector2 StartState { get; set; }

    [Header("Punch Position Settings")]
    [SerializeField] private Vector2 strength = new Vector2(1, 1);

    [Header("Set the vibrato.")]
    [SerializeField] int vibrato = 10;

    [Header("Set the elasticity 0-1.")]
    [Range(0, 1)]
    [SerializeField] float elasticity;

    protected override void Start()
    {
        Tweener = GetComponent<RectTransform>();
        StartState = Tweener.anchoredPosition;
        base.Start();
    }

    public override void Play()
    {
        Tweener.DOPunchAnchorPos(strength, duration, vibrato, elasticity)
        .SetLoops(looping ? -1 : 1, loopType)
        .SetEase(animationCurve);
    }

    public override void Reverse()
    {
        Tweener.DOPunchAnchorPos(strength, duration, vibrato, elasticity)
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
            StartState = Tweener.anchoredPosition;
    }

    public override void ResetToOrigin()
    {
        if (Tweener != null)
            Tweener.anchoredPosition = StartState;
    }
}
