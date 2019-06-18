using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class DroidData
{
    private float spawnRate;
    private float catchRate;
    private int attack;
    private int defense;
    private int hp;
    private string crySound;

    public float SpawnRate { get => spawnRate;}
    public float CatchRate { get => catchRate;}
    public int Attack { get => attack;}
    public int Defense { get => defense;}
    public int Hp { get => hp;}
    public string CrySound { get => crySound;}

    public DroidData(Droid droid)
    {
        spawnRate = droid.SpawnRate;
        catchRate = droid.CatchRate;
        attack = droid.Attack;
        defense = droid.Defense;
        hp = droid.Hp;
        crySound = droid.CrySound.name;
    }
}
