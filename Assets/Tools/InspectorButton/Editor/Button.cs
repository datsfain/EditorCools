namespace EditorCools.Editor
{
    using System.Reflection;
    using System.Collections.Generic;
    using UnityEditor;
    using UnityEngine;

    public class Button
    {
        public readonly string DisplayName;
        public readonly MethodInfo Method;
        public readonly ButtonAttribute ButtonAttribute;

        public Button(MethodInfo method, ButtonAttribute buttonAttribute)
        {
            ButtonAttribute = buttonAttribute;
            DisplayName = string.IsNullOrEmpty(buttonAttribute.Name)
                ? ObjectNames.NicifyVariableName(method.Name)
                : buttonAttribute.Name;

            Method = method;
        }

        internal void Draw(IEnumerable<object> targets)
        {
            if (!GUILayout.Button(DisplayName)) return;

            foreach (object target in targets)
            {
                Method.Invoke(target, null);
            }
        }
    }
}