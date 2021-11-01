using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataBase : MonoBehaviour
{
    private List<Item> _items = new List<Item>();
}

[System.Serializable]
public class Item
{
    private int _id;
    private string _name;
    private Sprite _image;

    public int Id => _id;


    public string Name => _name;
}
