using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARSceneManager : KommissarGOSceneManager
{
    public override void objectTapped(GameObject arObject)
    {
        Debug.Log("Tapped erreicht");
        Invoke("MoveToWorldScene", 1.0f);
    }

    public override void playerTapped(GameObject player)
    {
        
    }

    private void MoveToWorldScene()
    {
        ARSceneTransitionManager.Instance.GoToScene(KommissarGOConstants.SCENE_WORLD, /*new List<GameObject>()*/GameObject.Find("Loader").GetComponent<PlayerAR>().inventoryObjects);
    }
}
