using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class GameManagerAR : Singleton<GameManagerAR>
{
    private PlayerAR currentPlayer;

    public PlayerAR CurrentPlayer
    {
        get
        {
            if (currentPlayer == null)
            {
                currentPlayer = gameObject.AddComponent<PlayerAR>();
            }
            return currentPlayer;
        }
    }


}
