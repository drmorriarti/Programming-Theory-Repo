using UnityEngine;
// INHERITANCE
public class PotionController : ItemController
{
    protected override void UpdatePlayerProperties(PlayerProperties playerProperties)
    {
        Debug.Log("Potion collision");
        playerProperties.AddHealth(50);
    }
    protected override float GetRefreshTime()
    {
        return 5.0f;
    }
}
