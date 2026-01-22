
using UnityEngine;

[System.Serializable]
public struct InventoryItem
{
    [SerializeField] private string _name;
    [SerializeField] private int _amount;

    public InventoryItem AddAmount(int amount)
    {
        _amount += amount;

        if (_amount <= 0)
            _amount = 0;

        return this;
    }

    public InventoryItem InitializeItem(string name, int amount)
    {
        _name = name;
        _amount = amount;

        return this;
    }
}
