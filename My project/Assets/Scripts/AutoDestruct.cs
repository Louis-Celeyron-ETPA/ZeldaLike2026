using UnityEngine;

public class AutoDestruct : Interactable
{
    public override void OnTrigger(GameObject objectTriggered)
    {
        var playerHp = objectTriggered.GetComponent<HealthManager>();
        if (playerHp != null)
        {
            playerHp.Dammage(999, DammageType.Spike);
        }
    }

}
