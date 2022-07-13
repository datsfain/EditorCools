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
    [MinMaxSlider(5.1f,9.1f)]
    public Vector2 minMaxVector;

    [EasyButtons.Button]
    private static void GetStrings()
    {
        Debug.Log("A");
    }
}
