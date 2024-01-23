using UnityEngine;

namespace DefaultNamespace
{
    public class ClearPrefs : MonoBehaviour
    {
        public void Clear()
        {
            PlayerPrefs.DeleteAll();
        }
    }
}