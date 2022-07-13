using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Getter
{
    public static class Inner
    {
        public static string GetStrings()
        {
            return "a";
        }
    }
}

public class Test : MonoBehaviour
{
    [Dropdown("GetStrings")]
    public string Name;

    [MinMaxSlider(5.1f,9.1f)]
    public Vector2 minMaxVector;

    private static string[] GetStrings()
    {
        return new string[] { "A", "B", "C", "D", };
    }
}
