﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


public class Player : MonoBehaviour
{
    [SerializeField] private int xp = 0;
    [SerializeField] private int requiredXp = 0;
    [SerializeField] private int levelBase = 100;
    [SerializeField] private List<GameObject> droids = new List<GameObject>();
    private int lvl = 1;
    private string path;

    public int Xp {
        get => xp;
    }
    public int RequiredXp {
        get => requiredXp;
    }
    public int LevelBase {
        get => levelBase;
    }
    public List<GameObject> Droids {
        get => droids;
    }
    public int Lvl
    {
        get => lvl;
    }


    // Start is called before the first frame update
    void Start()
    {
        path = Application.persistentDataPath + "/player.dat";
        Load();
    }

    public void AddXp(int xp)
    {
        this.xp += Mathf.Max(0, xp);
        InitLevelData();
        Save();
    }

    public void AddDroid(GameObject droid)
    {
        droids.Add(droid);
        Save();
    }

    private void InitLevelData()
    {
        lvl = (xp / levelBase) + 1;
        requiredXp = levelBase * lvl;
    }
   
    private void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(path);
        PlayerData data = new PlayerData(this);
        bf.Serialize(file, data);
        file.Close();
    }

    private void Load()
    {
        if (File.Exists(path))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(path, FileMode.Open);
            if (file.Length > 0)
            {
                PlayerData data = (PlayerData)bf.Deserialize(file);
                xp = data.Xp;
                requiredXp = data.RequiredXp;
                levelBase = data.LevelBase;
                lvl = data.Lvl;
            }
            file.Close();


            //Import player droids
        }
        else
        {
            InitLevelData();
        }
    }
}
