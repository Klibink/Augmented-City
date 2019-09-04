using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spiegel : MonoBehaviour
{
    public Image slot;
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (slot.enabled)
        {
            button.enabled = true;
        }
        else
        {
            button.enabled = false;
        }
    }

    public void GotoPuzzleScene()
    {
        List<GameObject> list = new List<GameObject>();
        ARSceneTransitionManager.Instance.GoToScene(KommissarGOConstants.SCENE_PUZZLE, list);
    }
}
