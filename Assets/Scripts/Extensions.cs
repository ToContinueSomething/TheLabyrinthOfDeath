using UnityEngine;

namespace DefaultNamespace
{
    public static class Extensions
    {
        public static string ToSerialized(this object obj)
        {
            return JsonUtility.ToJson(obj);
        }

        public static T ToDeserialized<T>(this string json)
        {
            return JsonUtility.FromJson<T>(json);
        }
    }
}