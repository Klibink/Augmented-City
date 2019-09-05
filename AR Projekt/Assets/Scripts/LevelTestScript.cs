using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelTestScript : MonoBehaviour
{
    public Text text;
    private PlayerAR player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Loader").GetComponent<PlayerAR>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = player.lvl.ToString();
    }
}
