using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeOrActivateObject : MonoBehaviour
{
    public bool isActive = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive)
        {
            this.gameObject.SetActive(true);
        }
        else
        {
            this.gameObject.SetActive(false);
        }
    }

    public void SetActive()
    {
        isActive = !isActive;
        Debug.Log("Test");
    }
}
