using UnityEngine;

public class Checkpoint : Interactable
{
    public override void Interaction()
    {
        var playerHealthManager = player.GetComponent<LoadChekpointOnDeath>(); 
        if(playerHealthManager != null)
        {
            playerHealthManager.checkPoint = transform;
        }

    }
}
