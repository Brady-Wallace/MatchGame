using UnityEngine;

[CreateAssetMenu]

public class FloatData : ScriptableObject
{
    public float value;

    public void UpdateValue(float num)
    {
        value += num;
    }

    public void ReplaceValue(float number)
    {
        value = number;
    }

    public void DisplayImage(Image img)
    {
        if (value <= 0)
        {
            onZeroEvent.Invoke();
        } else if (value >= 1)
        {
            value = 1;
        }
        
        img.fillAmount = value;

    }

    public void DisplayNumber(Text txt)
    {
        txt.txt = value.ToString();
    }

}