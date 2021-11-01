using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Inventory : MonoBehaviour
{
    private List<ItemInventory> _items = new List<ItemInventory>();   
}

[System.Serializable]
public class ItemInventory
{
    private int _id;
    private GameObject _itemObject;

    public int Id => _id;

    public GameObject ItemObject => _itemObject;

}