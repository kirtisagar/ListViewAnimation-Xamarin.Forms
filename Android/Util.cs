using System;
using Android.Views;
using Android.App;
using System.Collections.Generic;

namespace FormsApp1.Android
{
    public static class Util
    {
        public static List<T> FindView<T>(ViewGroup viewGroup) where T : View
        {
            var result = new List<T>();

            var count = viewGroup.ChildCount;
            for (int i = 0; i < count; i++)
            {
                var child = viewGroup.GetChildAt(i);
                if (child is T)
                {
                    result.Add((T)child);
                }
                else if (child is ViewGroup)
                {
                    var innerResult = FindView<T>(child as ViewGroup);
                    if (innerResult != null)
                    {
                        result.AddRange(innerResult);
                    }
                }
            }
            return result;
        }
    }
}

