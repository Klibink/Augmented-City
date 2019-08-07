using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSceneGUIManager : MonoBehaviour
{
    [SerializeField] private GameObject menu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleMenu()
    {
        menu.SetActive(!menu.activeSelf);
    }
}
