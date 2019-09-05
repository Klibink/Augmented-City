using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// Notizen im Notizbuch werden je nach Level des Spielers auf sichtbar, oder nicht sichtbar gesetzt

public class Notizen : MonoBehaviour
{
    private PlayerAR player;
    public GameObject notiz01, notiz02, notiz03, notiz04, notiz05, displayBox;
    public TextMeshProUGUI textDisplay;
    public string[] sentences;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Loader").GetComponent<PlayerAR>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (player.lvl)
        {
            case 0:
                notiz01.SetActive(true);
                notiz02.SetActive(false);
                notiz03.SetActive(false);
                notiz04.SetActive(false);
                notiz05.SetActive(false);
                break;
            case 1:
                notiz01.SetActive(true);
                notiz02.SetActive(true);
                notiz03.SetActive(false);
                notiz04.SetActive(false);
                notiz05.SetActive(false);
                break;
            case 2:
                notiz01.SetActive(true);
                notiz02.SetActive(true);
                notiz03.SetActive(true);
                notiz04.SetActive(false);
                notiz05.SetActive(false);
                break;
            case 3:
                notiz01.SetActive(true);
                notiz02.SetActive(true);
                notiz03.SetActive(true);
                notiz04.SetActive(true);
                notiz05.SetActive(false);
                break;
            case 4:
                notiz01.SetActive(true);
                notiz02.SetActive(true);
                notiz03.SetActive(true);
                notiz04.SetActive(true);
                notiz05.SetActive(true);
                break;
            default:
                notiz01.SetActive(true);
                notiz02.SetActive(true);
                notiz03.SetActive(true);
                notiz04.SetActive(true);
                notiz05.SetActive(true);
                break;

        }
    }

    public void ShowNotiz(int wantedSentence)
    {
        textDisplay.text = "";
        displayBox.SetActive(true);
        textDisplay.text = sentences[wantedSentence];
    }
}
