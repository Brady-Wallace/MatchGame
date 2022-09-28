using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameActionHanlder : MonoBehaviour
{
    public GameAction gameActionObj;
    public UnityEvent onRaiseEvent;
    private void Start()
    {
        gameActionObj.raise += Raise;
    }


    private void Raise()
    {
        onRaiseEvent.Invoke();
    }
}
