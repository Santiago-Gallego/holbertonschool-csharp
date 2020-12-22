using System;

/// <summary> Represents a class Obj</summary>
class Obj
    {
    /// <summary> Method that verifies if object obj is a subclass</summary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if (derivedType.IsSubclassOf(baseType))
            return true;
        return false;
    }
}