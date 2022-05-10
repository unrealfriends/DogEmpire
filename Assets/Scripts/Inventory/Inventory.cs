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
        AddItem(new Item { itemType = Item.ItemType.Crate, amount = 1 });
        AddItem(new Item { itemType = Item.ItemType.Crate, amount = 1 });
        AddItem(new Item { itemType = Item.ItemType.Crate, amount = 1 });
        AddItem(new Item { itemType = Item.ItemType.Crate, amount = 1 });
        AddItem(new Item { itemType = Item.ItemType.Crate, amount = 1 });
        Debug.Log(itemList.Count);
    }

    public void AddItem(Item item)
    {
        itemList.Add(item);
    }
    
    // methode um itemlist von auﬂen zug‰nglich zu machen
    public List<Item> GetItemList()
    {
        return itemList;
    }

}
