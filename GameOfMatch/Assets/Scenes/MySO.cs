using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySO : ScriptableObject
{
    public GameObject enemy;
    public int spawnAmount = 5;
    public float spawnDelay = 0.5f;

    [SerializeField] string saySomething = "hey";

    public void SaySomething(){
        debug.LogError(saySomething);
    }
}
