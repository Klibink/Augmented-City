using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapSceneManager : KommissarGOSceneManager
{
    private GameObject arObject;
    private AsyncOperation loadScene;
    private MapSceneStatus status = MapSceneStatus.OnMap;

    public MapSceneStatus Status
    {
        get => status;
    }

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

    public void SetDefaultStatus()
    {
        status = MapSceneStatus.OnMap;
    }

    public void SetMenuStatus()
    {
        if (status != MapSceneStatus.InMenu)
        {
            status = MapSceneStatus.InMenu;
        }
        else
        {
            status = MapSceneStatus.OnMap;
        }

    }

    public void SetInventarStatus()
    {
        status = MapSceneStatus.InInventory;
    }

    public void SetNotizenStatus()
    {
        status = MapSceneStatus.InNotizen;
    }


}
