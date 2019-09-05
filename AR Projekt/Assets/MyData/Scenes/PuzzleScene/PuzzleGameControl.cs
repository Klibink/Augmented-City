﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleGameControl : MonoBehaviour
{
    [SerializeField]
    public GameObject textSmall;
    public GameObject Quader;
    public GameObject pieces;
    public GameObject places;
    public Text speechfield;
    private int timer = 50;
    // Start is called before the first frame update
    void Start()
    {
        Screen.orientation = ScreenOrientation.Portrait;
        Screen.autorotateToLandscapeLeft = false;
        Screen.autorotateToLandscapeRight = false;
        Screen.orientation = ScreenOrientation.AutoRotation;
        Time.timeScale = 1;
        textSmall.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(GameObject.Find("Loader").GetComponent<PlayerAR>().lvl);
        timer --;
        if(timer<=0)
        {
            pieces.SetActive(true);
            Quader.SetActive(true);

            places.SetActive(true);
        }
        if (puzzleScript.locked&&puzzle2Script.locked&&puzzle3Script.locked&&puzzle4Script.locked&&puzzle5Script.locked)
        {
            speechfield.text = "Interesting! Looks like those are coordinates. '50°55'30.7N/6°55'33.1E', what do those lead us to?";
            GameObject.Find("Loader").GetComponent<PlayerAR>().AddLvl();
            Invoke( "finished",3);
        }
    }

    void finished()
    {
        

        PuzzleSceneManager[] managers = FindObjectsOfType<PuzzleSceneManager>();
        foreach (PuzzleSceneManager puzzleSceneManager in managers)
        {
            if (puzzleSceneManager.gameObject.activeSelf)
            {
                puzzleSceneManager.objectTapped(this.gameObject);
            }
        }
    }
}
