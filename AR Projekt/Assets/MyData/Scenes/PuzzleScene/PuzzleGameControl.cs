using System.Collections;
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
    public Text textfield;
    private int timer = 50;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        textSmall.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        timer --;
        if(timer<=0)
        {
            pieces.SetActive(true);
            Quader.SetActive(true);
            /*for (int i= 0; i<=places.transform.childCount;i++)
            {
               places.gameObject.transform.GetChild(i).gameObject.SetActive(true);
            }*/
            places.SetActive(true);
        }
        if (puzzleScript.locked&&puzzle2Script.locked&&puzzle3Script.locked&&puzzle4Script.locked&&puzzle5Script.locked)
        {
            finished();
        }
    }

    void finished()
    {
        //Screen.autorotateToPortrait = true;
        //Screen.autorotateToPortraitUpsideDown = true;
        //Screen.orientation = ScreenOrientation.AutoRotation;
        textfield.text = "Interesting! Looks like those are coordinates. K, where do they lead to?";

        GameObject.Find("Loader").GetComponent<PlayerAR>().AddLvl();

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
