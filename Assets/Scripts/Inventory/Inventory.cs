using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    // Liste vom Typ Item erstellen
    private List<Item> itemList;

    public Inventory()
    {
        itemList = new List<Item>();

        AddItem(new Item { itemType = Item.ItemType.Wood, amount = 1});
        Debug.Log("Inventory");
        Debug.Log(itemList.Count);
    }

    public void AddItem(Item item)
    {
        itemList.Add(item);
    }

}
