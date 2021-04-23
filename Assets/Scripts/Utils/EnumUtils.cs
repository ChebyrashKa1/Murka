using System;
using System.Collections.Generic;

public static class EnumUtils
{
    public static List<T> GetValues<T>()
    {
        var vals = Enum.GetValues(typeof(T));
        List<T> returnVals = new List<T>();

        foreach (T val in vals)
        {
            returnVals.Add(val);
        }

        return returnVals;
    }
}