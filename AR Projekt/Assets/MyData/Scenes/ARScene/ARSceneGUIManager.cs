using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ARSceneGUIManager : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    [TextArea(2,10)]
    public string[] sentencesTatort01, sentencesTatort02, sentencesTatort03, sentencesTatort04;
    private string[] currentSentences;
    private int index=0;
    public float typingSpeed;
    public GameObject continueButton;
    public GameObject displayBox;
    public GameObject arCoreHelperUI;
    private PlayerAR player;

    private void Awake()
    {
        player = GameObject.Find("Loader").GetComponent<PlayerAR>();
        switch (player.lvl)
        {
            case 0:
                currentSentences = new string[sentencesTatort01.Length];
                sentencesTatort01.CopyTo(currentSentences, 0);
                break;
            case 1:
                currentSentences = new string[sentencesTatort02.Length];
                sentencesTatort02.CopyTo(currentSentences, 0);
                break;
            case 2:
                currentSentences = new string[sentencesTatort03.Length];
                sentencesTatort03.CopyTo(currentSentences, 0);
                break;
            case 3:
                currentSentences = new string[sentencesTatort04.Length];
                sentencesTatort04.CopyTo(currentSentences, 0);
                break;
            case 4:
                currentSentences = new string[sentencesTatort04.Length];
                sentencesTatort04.CopyTo(currentSentences, 0);
                break;
            default:
                currentSentences = new string[sentencesTatort04.Length];
                sentencesTatort04.CopyTo(currentSentences, 0);
                break;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Type());
    }

    // Update is called once per frame
    void Update()
    {
        if(textDisplay.text == currentSentences[index])
        {
            continueButton.SetActive(true);
        }
    }

    IEnumerator Type()
    {
        foreach (char letter in currentSentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextSentence()
    {
        continueButton.SetActive(false);

        if(index<currentSentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            textDisplay.text = "";
            continueButton.SetActive(false);
            displayBox.SetActive(false);
            arCoreHelperUI.SetActive(true);
        }
    }
}
