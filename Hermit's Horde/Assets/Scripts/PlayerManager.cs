using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private ItemContainer inventory = null;

    public void AddItemToInventory(ItemSO item, int amount, ItemContainer otherContainer = null)
    {
        inventory.AddToContainer(item, amount);

        if (otherContainer != null)
            otherContainer.RemoveFromContainer(item, amount);
    }

    public void RemoveItemFromInventory(ItemSO item, int amount, ItemContainer otherContainer = null)
    {
        if (otherContainer != null)
            otherContainer.RemoveFromContainer(item, amount);

        inventory.RemoveFromContainer(item, amount);
    }
}
