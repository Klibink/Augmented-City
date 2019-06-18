using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARSceneManager : KommissarGOSceneManager
{
    public override void objectTapped(GameObject arObject)
    {
        
    }

    public override void playerTapped(GameObject player)
    {
        
    }

    public void MoveToWorldScene()
    {
        SceneTransitionManager.Instance.GoToScene(KommissarGOConstants.SCENE_WORLD, new List<GameObject>());
    }
}
