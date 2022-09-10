using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeyText : MonoBehaviour
{
    int keyCount;

    public void IncrementKeyCount(){
        keyCount++;
        GetComponet<TextMeshProUGUI>().text = $"Keys: {keyCount}";
    }
}
