using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleSceneManager : KommissarGOSceneManager
{
    public override void objectTapped(GameObject arObject)
    {
        List<GameObject> list = new List<GameObject>();
        ARSceneTransitionManager.Instance.GoToScene(KommissarGOConstants.SCENE_WORLD, list);
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
