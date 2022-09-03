using UnityEngine;

public static class Getter
{
    public static class Inner
    {
        public static string[] GetOptions()
        {
            return new string[] { "one", "two", "three", "four" };
        }
    }
}

public class Test : MonoBehaviour
{
    [Header("Dropdown Menu")]
    [Dropdown(typeof(Getter.Inner), nameof(GetOptions))]
    public string options;
    [Header("Min Max Slider")]
    [MinMaxSlider(0f, 100f)]
    public Vector2 minMaxVector;



    [EditorCools.Button("1", "row1")] private void GetStrings1() => Debug.Log("1");
    [EditorCools.Button("2", "row1")] private void GetStrings2() => Debug.Log("2");

    [EditorCools.Button("0")] private void GetStrings0() => Debug.Log("0");
    [EditorCools.Button("00")] private void GetStrings00() => Debug.Log("00");
    [EditorCools.Button("000")] private void GetStrings000() => Debug.Log("000");

    [EditorCools.Button("3", "row2")] private void GetStrings3() => Debug.Log("3");
    [EditorCools.Button("4", "row2")] private void GetStrings4() => Debug.Log("4");
    [EditorCools.Button("5", "row2")] private void GetStrings5() => Debug.Log("5");

    [EditorCools.Button("6", "row3")] private void GetStrings6() => Debug.Log("6");
    [EditorCools.Button("7", "row3")] private void GetStrings7() => Debug.Log("7");
    [EditorCools.Button("8", "row3")] private void GetStrings8() => Debug.Log("8");
    [EditorCools.Button("9", "row3")] private void GetStrings9() => Debug.Log("9");

    private string[] GetOptions()
    {
        return new string[] { "one", "two", "three", "four" };
    }
}
