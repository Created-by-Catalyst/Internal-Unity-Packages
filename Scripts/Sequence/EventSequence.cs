using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSequence : MonoBehaviour
{
    [SerializeField] bool playOnEnable;
    [SerializeField] List<DelayEvent> eventSequence;

    private void OnEnable()
    {
        if (playOnEnable)
        {
            StartSequence();
        }
    }

    public void StartSequence()
    {
        Debug.Log("Sequence begun");
        int i = 0;
        StartCoroutine(IDelayThenEvent(i));
    }

    IEnumerator IDelayThenEvent(int eventIndex)
    {
        yield return new WaitForSecondsRealtime(eventSequence[eventIndex].delay);
        eventSequence[eventIndex].events?.Invoke();

        if (eventIndex + 1 < eventSequence.Count)
        {
            StartCoroutine(IDelayThenEvent(eventIndex + 1));
        }
    }
}
