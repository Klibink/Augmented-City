using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapSceneManager : KommissarGOSceneManager
{
    private GameObject arObject;
    private AsyncOperation loadScene;

    public override void objectTapped(GameObject arObject)
    {
        //SceneManager.LoadScene(PocketDroidsConstants.SCENE_CAPTURE, LoadSceneMode.Additive);
        List<GameObject> list = new List<GameObject>();
        list.Add(arObject);
        ARSceneTransitionManager.Instance.GoToScene(KommissarGOConstants.SCENE_AR, list);
    }

    public override void playerTapped(GameObject player)
    {

    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


}
