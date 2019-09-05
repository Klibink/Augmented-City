using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script setzt InventarObjecte sobald diese in der AR-Szene gefunden wurden


public class Beweise : MonoBehaviour
{
    public GameObject[] tatortFunde;
    private bool b1gefunden = false, b2gefunden = false, b3gefunden = false;
    private GameObject player;
    private int itemNummer;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Loader");
    }

    // Update is called once per frame
    void Update()
    {
        switch (player.GetComponent<PlayerAR>().lvl)
        {
            case 2:
                if (!b1gefunden)
                {
                    b1gefunden = true;
                    player.GetComponent<PlayerAR>().AddToInventory(tatortFunde[itemNummer]);
                    itemNummer++;
                    
                }
                break;
            case 3:
                if (!b2gefunden)
                {
                    b2gefunden = true;
                    player.GetComponent<PlayerAR>().AddToInventory(tatortFunde[itemNummer]);
                    itemNummer++;
                }
                break;
            case 4:
                if (!b3gefunden)
                {
                    b3gefunden = true;
                    player.GetComponent<PlayerAR>().AddToInventory(tatortFunde[itemNummer]);
                    itemNummer++;
                }
                break;
            default:

                break;
        }
    }
}
