using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSceneManager : MonoBehaviour
{
    public GameObject ui1, ui2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleUI(GameObject ui1, GameObject ui2)
    {
        ui1.SetActive(!ui1);
        ui2.SetActive(!ui2);
    }
}
