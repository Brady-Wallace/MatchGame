
using System;
using UnityEngine;

public class ColorIDBehaviour : IDContainerBehaviour
{
    public ColorIDDataList colorIDDataListObj;

    private void Awake()
    {
        idobj = colorIDDataListObj.currentColor;
    }
}
