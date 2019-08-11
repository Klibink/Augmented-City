﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class PlayerData
{
    private int xp;
    private int requiredXp;
    private int levelBase;
    private int lvl;
    private List<DroidData> droids = new List<DroidData>();

    public int Xp { get => xp;  }
    public int RequiredXp { get => requiredXp; }
    public int LevelBase { get => levelBase; }
    public int Lvl { get => lvl; }
    public List<DroidData> Droids { get => droids; }

    public PlayerData(Player player)
    {
        xp = player.Xp;
        requiredXp = player.RequiredXp;
        levelBase = player.LevelBase;
        lvl = player.Lvl;

        foreach(GameObject droidObject in player.Droids)
        {
            Droid droid = droidObject.GetComponent<Droid>();
            if (droid != null)
            {
                DroidData data = new DroidData(droid);
                droids.Add(data);
            }
        }
    }
}
