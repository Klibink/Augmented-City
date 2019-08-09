using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAR : MonoBehaviour
{
    public int currentTatort;
    public int lvl=0;

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
        for(int i = 0; i < inventoryObjects.Count; i++)
        {
            Debug.Log(inventoryObjects[i] + " " + "i = " + i);
        }
        
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
