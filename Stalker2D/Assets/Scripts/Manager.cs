using UnityEngine;

public class Manager<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _Instance;

    public static T Instance
    {
        get
        {
            if (_Instance == null)
            {
                _Instance = (T)FindObjectOfType(typeof(T));
            }

            return _Instance;
        }
    }
}