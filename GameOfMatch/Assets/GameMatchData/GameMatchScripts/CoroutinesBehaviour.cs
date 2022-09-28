using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoroutinesBehaviour : MonoBehaviour
{
    private WaitForSeconds wfsObj;
    public float secs = 3.0f;
    private WaitForFixedUpdate wffuObj;
    public IntData counterNum;
    public UnityEvent startEvent, startCountEvent, repeatCountEvent, endCountEvent, repeatUnitlFalseEvent;
    public bool canRun;

    public bool CanRun
    {
        get => canRun;
        set => canRun = value;
    }

    private void Start()
    {
        wfsObj = new WaitForSeconds(secs);
        wffuObj = new WaitForFixedUpdate();
        startEvent.Invoke();
    }

    public void StartCounting()
    {
        StartCoroutine(Counting());
    }
    
    private IEnumerator Counting()
    {
        startCountEvent.Invoke();
        yield return wfsObj;
        while (counterNum.value > 0)
        {
            repeatCountEvent.Invoke();
            counterNum.value--;
            yield return wfsObj;
        }
        endCountEvent.Invoke();
    }

    public void StartRepeatingUntilFalse()
    {
        CanRun = true;
        StartCoroutine(RepeatUntilFalse());
    }

    private IEnumerator RepeatUntilFalse()
    {
        while (CanRun)
        {
            yield return wfsObj;
            repeatUnitlFalseEvent.Invoke();
        }
    }
}

