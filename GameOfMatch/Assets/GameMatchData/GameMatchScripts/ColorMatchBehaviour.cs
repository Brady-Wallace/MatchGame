using System.Collections.Generic;
using UnityEngine;

public class ColorMatchBehaviour : MatchBehaviour
{
    public ColorIDDataList colorIDDataListObj;

    private void Awake()
    {
        idobj = colorIDDataListObj.currentColor;
    }

    public void ChangeColor(SpriteRenderer renderer)
    {
        var newColor = idobj as ColorID;
        renderer.color = newColor.value;
    }
}
