using UnityEngine;
using DG.Tweening;

public class TweenScale : CustomTweenTemplate<Transform, Vector3>
{
    protected override Transform Tweener { get; set; }
    protected override Vector3 StartState { get; set; }

    [Header("Scale Settings")]
    [SerializeField] private Vector3 targetScale;

    // Toggle to choose between local and pseudo-world scale
    [SerializeField] private bool isLocal = true;

    protected override void Start()
    { 
        Tweener = transform;
        StartState = isLocal ? transform.localScale : CalculateWorldScale(transform);
        base.Start();
    }

    public override void Play()
    {
        if (isLocal)
            Tweener.DOScale(targetScale, duration).SetLoops(looping ? -1 : 1, loopType).SetEase(animationCurve);
        else
            Debug.LogWarning("TweenScale: Tweening of pseudo-world scale is not supported by DOTween.");
    }

    public override void Reverse()
    {
        if (isLocal)
            Tweener.DOScale(StartState, duration).SetLoops(looping ? -1 : 1, loopType).SetEase(animationCurve);
        else
            Debug.LogWarning("TweenScale: Tweening of pseudo-world scale is not supported by DOTween.");
    }

    public override void Stop()
    {
        Tweener.DOKill();
    }

    public override void SetOrigin()
    {
        if (Tweener != null)
        {
            StartState = isLocal ? Tweener.localScale : CalculateWorldScale(Tweener);
        }
    }

    public override void ResetToOrigin()
    {
        if (Tweener != null)
        {
            Tweener.localScale = StartState;
        }
    }

    // Calculate the pseudo-world scale of a Transform by multiplying the local scales of all parents
    private Vector3 CalculateWorldScale(Transform t)
    {
        Vector3 worldScale = t.localScale;
        Transform parent = t.parent;

        while (parent != null)
        {
            worldScale = Vector3.Scale(worldScale, parent.localScale);
            parent = parent.parent;
        }

        return worldScale;
    }
}
