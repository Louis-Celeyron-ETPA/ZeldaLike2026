using UnityEngine;

public class Persitence : MonoBehaviour
{
    public void Awake()
    {
        DontDestroyOnLoad(gameObject);    
    }
}
