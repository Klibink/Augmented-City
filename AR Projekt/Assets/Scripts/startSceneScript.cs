using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class startSceneScript : MonoBehaviour
{

    private int timer = 100;
    public Text text;
    public GameObject btn;
    public GameObject canvas;
    public GameObject vPlayer;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;

    }

    // Update is called once per frame
    void Update()
    {   
        Debug.Log(timer);
        if (timer <= 50)
        {
            text.text = "Mörder To GO";
        }
        if(timer <= 0)
        {
            btn.SetActive(true);
        }
        else
        {
            timer--;
        }
    }

    public void playVid()
    {
        vPlayer.SetActive(true);
        btn.SetActive(false);
        canvas.SetActive(false);
        
    }

}
