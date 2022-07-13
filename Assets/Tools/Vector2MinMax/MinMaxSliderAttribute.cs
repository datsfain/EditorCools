using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinMaxSliderAttribute : PropertyAttribute
{
    public float Min;
    public float Max;

    public MinMaxSliderAttribute(float min, float max)
    {
        Min = min;
        Max = max;
    }
}
