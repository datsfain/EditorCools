using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(MinMaxSliderAttribute))]
public class MinMaxAttributeDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        EditorGUI.BeginProperty(position, label, property);


        var vector2 = property.vector2Value;

        var attr = attribute as MinMaxSliderAttribute;

        using (var check = new EditorGUI.ChangeCheckScope())
        {
            var labelRect = EditorGUI.PrefixLabel(position, label);

            var remainingWidth = position.width - EditorGUIUtility.labelWidth - 6;

            var minMaxRect = new Rect(position.x + EditorGUIUtility.labelWidth + 2, position.y, remainingWidth / 2f - 2, position.height);
            EditorGUI.MinMaxSlider(minMaxRect, ref vector2.x, ref vector2.y, attr.Min, attr.Max);

            var multiFloatRect = new Rect(position.x + EditorGUIUtility.labelWidth + remainingWidth / 2 + 4 , position.y, remainingWidth / 2, position.height);
            float[] values = new float[2] { vector2.x, vector2.y };
            EditorGUI.MultiFloatField(multiFloatRect, new GUIContent[2] { new GUIContent(""), new GUIContent("") }, values);
            vector2.x = values[0];
            vector2.y = values[1];

            property.vector2Value = vector2;
        }

        EditorGUI.EndProperty();
    }
}
