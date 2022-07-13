namespace EasyButtons.Editor
{
    using System.Reflection;
    using System.Collections.Generic;
    using UnityEditor;
    using UnityEngine;

    public class Button
    {
        public readonly string DisplayName;

        public readonly MethodInfo Method;

        private readonly bool _disabled;

        protected Button(MethodInfo method, ButtonAttribute buttonAttribute)
        {
            DisplayName = string.IsNullOrEmpty(buttonAttribute.Name)
                ? ObjectNames.NicifyVariableName(method.Name)
                : buttonAttribute.Name;

            Method = method;

            bool inAppropriateMode = EditorApplication.isPlaying
                ? buttonAttribute.Mode == ButtonMode.EnabledInPlayMode
                : buttonAttribute.Mode == ButtonMode.DisabledInPlayMode;

            _disabled = !(buttonAttribute.Mode == ButtonMode.AlwaysEnabled || inAppropriateMode);
        }

        internal void Draw(IEnumerable<object> targets)
        {
            using (new EditorGUI.DisabledScope(_disabled))
            {
                if (!GUILayout.Button(DisplayName)) return;

                foreach (object target in targets)
                {
                    Method.Invoke(target, null);
                }
            }
        }

        internal static Button Create(MethodInfo method, ButtonAttribute buttonAttribute)
        {
            return new Button(method, buttonAttribute);
        }
    }
}