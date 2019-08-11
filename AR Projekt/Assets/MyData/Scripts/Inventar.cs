using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventar : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject[] itemSlots;
    public Transform itemParent;
    public Sprite[] possibleSprites;
    


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Loader");
        itemSlots = GameObject.FindGameObjectsWithTag("IconSlot");

        for(int i = 0; i < player.GetComponent<PlayerAR>().inventory.Count; i++)
        {
            itemSlots[i].GetComponent<Image>().enabled = true;
            itemSlots[i].GetComponent<Image>().sprite = possibleSprites[ItemHelper.GetSpriteIndex(player.GetComponent<PlayerAR>().inventory[i])];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
