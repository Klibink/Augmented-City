using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Droid : MonoBehaviour
{
    [SerializeField] private float spawnRate = 0.10f;
    [SerializeField] private float catchRate = 0.10f;
    [SerializeField] private int attack = 0;
    [SerializeField] private int defense = 0;
    [SerializeField] private int hp = 0;

    public float SpawnRate { get => spawnRate; }
    public float CatchRate { get => catchRate;  }
    public int Attack { get => attack;  }
    public int Defense { get => defense;  }
    public int Hp { get => hp;  }

    private void Start()
    {
        DontDestroyOnLoad(this);
    }

    private void OnMouseDown()
    {
        PocketDroidsSceneManager[] managers = FindObjectsOfType<PocketDroidsSceneManager>();
        foreach(PocketDroidsSceneManager pocketDroidsSceneManager in managers)
        {
            if (pocketDroidsSceneManager.gameObject.activeSelf)
            {
                pocketDroidsSceneManager.droidTapped(this.gameObject);
            }
        }
    }
}
