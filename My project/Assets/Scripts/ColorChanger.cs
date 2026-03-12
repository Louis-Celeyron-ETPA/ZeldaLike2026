using UnityEngine;

public class ColorChanger : Interactable
{
    public override void Interaction()
    {
        var sr = player.GetComponent<SpriteRenderer>();
        sr.color = new Color(Random.Range(0f,1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }
}
