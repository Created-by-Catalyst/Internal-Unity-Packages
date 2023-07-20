using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class TweenPunchRotation : CustomTweenTemplate<Transform, Quaternion>
{
    protected override Transform Tweener { get; set; }
    protected override Quaternion StartState { get; set; }

    [Header("Punch Rotation Settings")]
    [SerializeField] private Vector3 strength = new Vector3(1, 1, 1);

    [Header("Set the vibrato.")]
    [SerializeField] int vibrato = 4;

    [Header("Set the elasticity 0-1.")]
    [Range(0, 1)]
    [SerializeField] float elasticity = 0.25f;

    private void Awake()
    {
        Tweener = GetComponent<Transform>();
        StartState = Tweener.rotation;
    }

    public override void Play()
    {
        Tweener.DOPunchRotation(strength, duration, vibrato, elasticity)
        .SetLoops(looping ? -1 : 1, loopType)
        .SetEase(animationCurve);

    }

    public override void Reverse()
    {
        Tweener.DOPunchRotation(strength, duration, vibrato, elasticity)
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
            StartState = Tweener.rotation;
    }

    public override void ResetToOrigin()
    {
        if (Tweener != null)
            Tweener.rotation = StartState;
    }
}
