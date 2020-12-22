using System;

/// <summary> Represents a class Obj</summary>
class Obj
{
    /// <summary> Method that verifies if object obj is an int</summary>
    public static bool IsOfTypeInt(object obj)
    {
        if (obj is int)
            return true;
        return false;
    }
}