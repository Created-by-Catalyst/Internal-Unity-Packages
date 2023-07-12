using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollisionEvents : MonoBehaviour
{
    [SerializeField] UnityEvent triggerEnter;
    [SerializeField] UnityEvent triggerExit;
    [SerializeField] UnityEvent triggerStay;
    [SerializeField] UnityEvent collisionEnter;

    // Function is called when the Collider 'other' enters the trigger
    void OnTriggerEnter(Collider other)
    {
        triggerEnter?.Invoke();
    }

    // Function is called when the Collider 'other' exits the trigger
    void OnTriggerExit(Collider other)
    {
        triggerExit?.Invoke();
    }

    // Function is called when the Collider 'other' stays in the trigger
    void OnTriggerStay(Collider other)
    {
        triggerExit?.Invoke();
    }

    // Function is called when the GameObject collides with another GameObject
    void OnCollisionEnter(Collision collision)
    {
        collisionEnter?.Invoke();
    }
}
