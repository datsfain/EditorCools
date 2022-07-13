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

    private static string[] GetStrings()
    {
        return new string[] { "A", "B", "C", "D", };
    }
}
