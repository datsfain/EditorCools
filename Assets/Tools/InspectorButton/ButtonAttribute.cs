namespace EditorCools
{
    using System;

    [AttributeUsage(AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
    public sealed class ButtonAttribute : Attribute
    {
        public readonly string Name;
        public readonly string Row;
        public readonly float Space;
        public readonly bool HasRow;
        public ButtonAttribute() { }
        public ButtonAttribute(string name, float space = 0) : this(name, default, space) { }
        public ButtonAttribute(string name, string rowName) : this(name, rowName, default) { }
        public ButtonAttribute(string name, string rowName, float space)
        {
            Row = rowName;
            HasRow = !string.IsNullOrEmpty(Row);
            Name = name;
            Space = space;
        }
    }
}

