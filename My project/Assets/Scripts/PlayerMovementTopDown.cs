using UnityEngine;

public class PlayerMovementTopDown : MonoBehaviour
{
    public Rigidbody2D rb; //Ne pas oublier de mettre le gravity scale du rigidbody à 0 et d'ajouter un collider
    public float speed = 1;

    public void Move(Vector2 direction)
    {
        rb.linearVelocity = direction.normalized *speed;

    }
}
