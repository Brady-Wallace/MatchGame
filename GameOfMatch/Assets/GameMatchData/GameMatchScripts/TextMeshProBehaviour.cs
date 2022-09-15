using System.Globalization;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]

public class TextMeshProBehaviour : MonoBehaviour
{
    private Text label;
    public UnityEvent startEvent;
    
    public void Start()
    {
        label = GetComponent<Text>();
        startEvent.Invoke();

    }

    public void UpdateLabel(FloatData obj)
    {
        label.text = obj.value.ToString(CultureInfo.InvariantCulture);
    }
    
    public void UpdateLabel(IntData obj)
    {
        label.text = obj.value.ToString(CultureInfo.InvariantCulture);
    }
}