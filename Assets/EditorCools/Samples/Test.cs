using UnityEngine;

public static class Outter
{
    public static class Inner
    {
        public static string[] GetOptions()
        {
            return new string[]
            {
                "other class 1",
                "other class 2",
                "other class 3",
                "other class 4"
            };
        }
    }
}

public class Test : MonoBehaviour
{
    [Space(10f)]
    // You can specify class name and method name that returns string[]
    [Dropdown(typeof(Outter.Inner), nameof(GetOptions))]
    public string options1;


    [Space(10f)]
    // You can specify just method name in this class that returns string[]
    [Dropdown(nameof(GetOptions))]
    public string options2;


    [Space(10f)]
    // left value will be stored in x, right one in y
    [MinMaxSlider(0f, 100f)]
    public Vector2 minMaxVector;

    private string[] GetOptions()
    {
        return new string[]
        {
            "this class 1",
            "this class 2",
            "this class 3",
            "this class 4"
        };
    }


    // If name is not specified it will use method name instead
    [EditorCools.Button]
    private void FirstButton() => Debug.Log("First Button Clicked!");


    // You can specify what name should button display
    [EditorCools.Button(name: "Second Button")]
    private void NameDoesnotMatter() => Debug.Log("Second Button Clicked!");


    // Space property has the same functionality as [Space] Attribute
    [EditorCools.Button(space: 10f)]
    private void SpacedButton() => Debug.Log("Spaced Button Clicked");



    // Buttons with the same row name will
    // be horizontally drawn in declaring order
    [EditorCools.Button(row: "row-1")]
    private void Row1Button1() => Debug.Log("Row 1 Button 1");

    [EditorCools.Button(row: "row-1")]
    private void Row1Button2() => Debug.Log("Row 1 Button 2");


    // If you want space before button row,
    // specify it as space property in first button
    [EditorCools.Button(row: "row-2", space: 20f)]
    private void Row2Button1() => Debug.Log("Row 2 Button 3");

    [EditorCools.Button(row: "row-2")]
    private void Row2Button2() => Debug.Log("Row 2 Button 3");

    [EditorCools.Button(row: "row-2")]
    private void Row2Button3() => Debug.Log("Row 3 Button 3");
}
