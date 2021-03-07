using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Extensions
{
    public static void DoForAll<T>(this IList<T> list, System.Action<T, int> action)
    {
        int count = list.Count;

        for (int i = 0; i < count; i++)
        {
            T item = list[i];
            action(item, i);
        }
    }

    public static void DoForAll<T>(this IList<T> list, System.Action<T> action)
    {
        int count = list.Count;

        for (int i = 0; i < count; i++)
        {
            T item = list[i];
            action(item);
        }
    }
}
