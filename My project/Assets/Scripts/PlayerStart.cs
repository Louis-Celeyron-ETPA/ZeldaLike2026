using UnityEngine;

public class PlayerStart : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var player = FindFirstObjectByType<PlayerMovementTopDown>();       
        player.transform.position = transform.position;
    }
}
