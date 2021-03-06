﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class TatortFactory : Singleton<TatortFactory>
{
    private PlayerAR player;
    public GameObject[] tatortFunde;
    private bool b1gefunden = false, b2gefunden = false, b3gefunden = false;
    //private GameObject player;
    private int itemNummer=0;

    // Start is called before the first frame update
    void Start()
    {
        player = GameManagerAR.Instance.CurrentPlayer;
        Assert.IsNotNull(player);
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
                    player.GetComponent<PlayerAR>().AddToInventory(tatortFunde[0]);
                    itemNummer++;

                }
                break;
            case 3:
                if (!b2gefunden)
                {
                    b2gefunden = true;
                    player.GetComponent<PlayerAR>().AddToInventory(tatortFunde[1]);
                    itemNummer++;
                }
                break;
            case 4:
                if (!b3gefunden)
                {
                    b3gefunden = true;
                    player.GetComponent<PlayerAR>().AddToInventory(tatortFunde[2]);
                    itemNummer++;
                }
                break;
            default:

                break;
        }
    }
}
