using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewItem", menuName = "Inventory/Item")]
public class ItemSO : ScriptableObject
{
    public string itemName;
    public GameObject prefab;
    public Sprite icon;
}

[System.Serializable]
public class ItemStack
{
    public ItemSO item;
    public int amount;
}

[System.Serializable]
public class ItemContainer
{
    public List<ItemStack> container = new();

    public void AddToContainer(ItemSO item, int amount)
    {
        foreach (ItemStack stack in container)
        {
            if (stack.item == item)
            {
                stack.amount += amount;
                return;
            }
        }

        ItemStack newStack = new ItemStack();
        newStack.item = item;
        newStack.amount = amount;
        container.Add(newStack);
    }

    public void RemoveFromContainer(ItemSO item, int amount)
    {
        foreach (ItemStack stack in container)
        {
            if (stack.item == item)
            {
                stack.amount -= amount;
                
                if(stack.amount <= 0)
                {
                    container.Remove(stack);
                    container.RemoveAll(x => x == null);
                }
            }
        }
    }
}
