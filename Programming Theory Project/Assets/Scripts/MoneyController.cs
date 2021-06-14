using UnityEngine;
// INHERITANCE
public class MoneyController : ItemController
{
    protected override void UpdatePlayerProperties(PlayerProperties playerProperties)
    {
        Debug.Log("Money collision");
        playerProperties.AddMoney(10);
    }
    protected override float GetRefreshTime()
    {
        return Random.Range(1.0f, 2.0f);
    }
}
