using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAR : MonoBehaviour
{
    public int currentTatort;
    //Default Level ist 0
    public int lvl=1;
    public List<Item> inventory = new List<Item>();

    public List<GameObject> inventoryObjects = new List<GameObject>();

    public List<GameObject> InventoryObjects
    {
        get => inventoryObjects;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddToInventory(Item item)
    {
        inventory.Add(item);
    }

    public void AddToInventory(GameObject objectToAdd)
    {
        inventoryObjects.Add(objectToAdd);
    }

    public void AddLvl()
    {
        lvl += 1;
    }
}
