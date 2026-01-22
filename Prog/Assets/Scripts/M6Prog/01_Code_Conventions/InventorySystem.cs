
using UnityEngine;
using System.Collections.Generic;

public class InventorySystem : MonoBehaviour
{
    [SerializeField] private List<InventoryItem> _inventoryItems = new List<InventoryItem>();

    private InventoryItem _inventoryItem = new InventoryItem();

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
            _inventoryItems[0] = _inventoryItems[0].AddAmount(1);

        if (Input.GetKeyDown(KeyCode.W))
            _inventoryItems[1] = _inventoryItems[1].AddAmount(1);

        if (Input.GetKeyDown(KeyCode.E))
            _inventoryItems[2] = _inventoryItems[2].AddAmount(1);

        if (Input.GetKeyDown(KeyCode.A))
            _inventoryItems[0] = _inventoryItems[0].AddAmount(-1);

        if (Input.GetKeyDown(KeyCode.S))
            _inventoryItems[1] = _inventoryItems[1].AddAmount(-1);

        if (Input.GetKeyDown(KeyCode.D))
            _inventoryItems[2] = _inventoryItems[2].AddAmount(-1);
    }
    private void Start()
    {
        _inventoryItems.Add(_inventoryItem.InitializeItem("Gun", 0));
        _inventoryItems.Add(_inventoryItem.InitializeItem("Medipack", 0));
        _inventoryItems.Add(_inventoryItem.InitializeItem("Keycard", 0));
    }
}
