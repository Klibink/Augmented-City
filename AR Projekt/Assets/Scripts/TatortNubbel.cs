using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TatortNubbel : MonoBehaviour
{
    //public static Scene currentScene = SceneManager.GetActiveScene();
    //private string sceneName = currentScene.name;
    private string sceneName;

    public int tatortNummer;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        //player = FindObjectOfType<PlayerAR>();
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;


    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        player = GameObject.Find("Loader");
        player.GetComponent<PlayerAR>().currentTatort = 3;

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
