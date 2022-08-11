using UnityEngine;

public class Singleton2<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T instance2;

    public static T Instance2
    {
        get {
            if (instance2 == null) {
                instance2 = (T)FindObjectOfType(typeof(T));
            }

            return instance2;
        }
    }

}