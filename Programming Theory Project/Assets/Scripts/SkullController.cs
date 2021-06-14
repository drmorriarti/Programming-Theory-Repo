using UnityEngine;
// INHERITANCE
public class SkullController : ItemController
{

    protected override void UpdatePlayerProperties(PlayerProperties playerProperties)
    {
        Debug.Log("Skull collision");
        playerProperties.AddHealth(-50);
    }
    protected override float GetRefreshTime()
    {
        return 2.0f;
    }


}
