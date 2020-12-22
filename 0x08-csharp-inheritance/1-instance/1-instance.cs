using System;

/// <summary> Represents a class Obj</summary>
class Obj
{
    /// <summary> Method that verifies if object obj is an instance of 
    /// a class that inhetited from Array</summary>
    public static bool IsInstanceOfArray(object obj)
    {
        if (typeof(Array).IsInstanceOfType(obj))
            return true;
        return false;
    }
}