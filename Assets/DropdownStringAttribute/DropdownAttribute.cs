using System;
using UnityEngine;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class DropdownAttribute : PropertyAttribute
{
    public enum MethodLocation { PropertyClass, StaticClass }
    public MethodLocation Location { get; private set; }
    public string MethodName { get; private set; }
    public Type MethodOwnerType { get; private set; }

    public DropdownAttribute(string methodName)
    {
        Location = MethodLocation.PropertyClass;
        MethodName = methodName;
    }
    /// <summary>
    /// Use This Constructor Declaration For Methods That Does Not Belong To
    /// The Declaring Class Of Property That Attribute Is Put On
    /// </summary>
    /// <param name="methodOwner"></param>
    /// <param name="methodName"></param>
    public DropdownAttribute(Type methodOwner, string methodName)
    {
        Location = MethodLocation.StaticClass;
        MethodOwnerType = methodOwner;
        MethodName = methodName;
    }
}
