using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSceneGUIManager : MonoBehaviour
{
    [SerializeField] private MapSceneManager manager;
    [SerializeField] private GameObject menuCanvas;
    [SerializeField] private GameObject inventarCanvas;
    [SerializeField] private GameObject notizenCanvas;
    [SerializeField] private GameObject[] hinweisCanvas;

    private bool firstOpened = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (manager.Status)
        {
            case MapSceneStatus.OnMap:
                menuCanvas.SetActive(false);
                inventarCanvas.SetActive(false);
                notizenCanvas.SetActive(false);
                if (!GameObject.Find("Loader").GetComponent<PlayerAR>().Hinweis1Gesehen)
                {
                    hinweisCanvas[0].SetActive(true);
                    GameObject.Find("Loader").GetComponent<PlayerAR>().Hinweis1Gesehen = true;
                }
                break;

            case MapSceneStatus.InMenu:
                menuCanvas.SetActive(true);
                inventarCanvas.SetActive(false);
                notizenCanvas.SetActive(false);
                if (!GameObject.Find("Loader").GetComponent<PlayerAR>().Hinweis2Gesehen)
                {
                    hinweisCanvas[1].SetActive(true);
                    GameObject.Find("Loader").GetComponent<PlayerAR>().Hinweis2Gesehen = true;
                }
                break;

            case MapSceneStatus.InInventory:
                menuCanvas.SetActive(false);
                inventarCanvas.SetActive(true);
                notizenCanvas.SetActive(false);
                break;

            case MapSceneStatus.InNotizen:
                menuCanvas.SetActive(false);
                inventarCanvas.SetActive(false);
                notizenCanvas.SetActive(true);
                break;

            default:

                break;
        }
    }

    public void ToggleMenu()
    {
        menuCanvas.SetActive(!menuCanvas.activeSelf);
    }

    public void ToggleInventar()
    {
        inventarCanvas.SetActive(!inventarCanvas.activeSelf);
    }

    public void ToggleNotizen()
    {
        notizenCanvas.SetActive(!notizenCanvas.activeSelf);
    }

    public void ToggleHinweise()
    {
        for(int i = 0; i < hinweisCanvas.Length; i++)
        {
            if (hinweisCanvas[i].activeSelf)
            {
                hinweisCanvas[i].SetActive(!hinweisCanvas[i].activeSelf);
            }
        }

        
    }
}
