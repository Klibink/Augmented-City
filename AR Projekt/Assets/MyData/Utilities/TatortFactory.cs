using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class TatortFactory : Singleton<TatortFactory>
{
    private PlayerAR player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameManagerAR.Instance.CurrentPlayer;
        Assert.IsNotNull(player);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
