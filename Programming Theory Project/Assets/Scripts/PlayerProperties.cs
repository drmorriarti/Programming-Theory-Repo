using UnityEngine;

public class PlayerProperties : MonoBehaviour
{
    [SerializeField]
    // ENCAPSULATION
    private int _health = 100;
    [SerializeField]
    private int _money = 0;
    public int Health
    {
        get { return _health; }
    }

    // ENCAPSULATION
    //supply negative to substract health
    public void AddHealth(int health)
    {
        _health += health;
        if (_health < 0)
        {
            _health = 0;
        }
        if (_health > 100)
        {
            _health = 100;
        }
    }

    public int Money
    {
        get { return _money; }
    }

    // ENCAPSULATION
    public void AddMoney(int money)
    {
        if (money > 0)
        {
            _money += money;
        }
    }

}
