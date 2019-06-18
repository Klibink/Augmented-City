using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tatort : MonoBehaviour
{
    public int tatortNummer;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        //player = FindObjectOfType<PlayerAR>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        player = GameObject.Find("Loader");
        player.GetComponent<PlayerAR>().currentTatort = tatortNummer;

        MapSceneManager[] managers = FindObjectsOfType<MapSceneManager>();
        foreach (MapSceneManager mapSceneManager in managers)
        {
            if (mapSceneManager.gameObject.activeSelf)
            {
                mapSceneManager.objectTapped(this.gameObject);
            }
        }
    }
}
