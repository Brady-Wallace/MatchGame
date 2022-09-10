using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class myTrigger : MonoBehaviour

{
    [SerializeField] private UnityEvent trig;

    private void OnEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myTrigger.Invoke();
        }
    }
}
