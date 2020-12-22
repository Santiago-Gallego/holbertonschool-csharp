using System;
using System.Reflection;
using System.Collections.Generic;
using System.Text;

/// <summary> Represents a class Obj</summary>
class Obj
{
    /// <summary> Method that verifies if object obj is a subclass</summary>
    public static void Print(object myObj)
    {
        TypeInfo t = myObj.GetType().GetTypeInfo();
        IEnumerable<PropertyInfo> propertiesList = t.GetProperties();
        IEnumerable<MethodInfo> methodsList = t.GetMethods();
        //StringBuilder stringToPrint = new StringBuilder();

        //stringToPrint.Append(GetType(myObj) + ' ' + "Properties:");
        Console.WriteLine(t.Name + ' ' + "Properties:");
        foreach (PropertyInfo p in propertiesList)
        {
            Console.WriteLine(p.Name);
        }
        Console.WriteLine(t.Name + ' ' + "Methods:");
        foreach (MethodInfo m in methodsList)
        {
            Console.WriteLine(m.Name);
        }
    }
}