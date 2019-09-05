using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NubbelFeuer2 : MonoBehaviour
{
    
    
    public GameObject[] Fire;
    public GameObject Hydrant;
    

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                
                {
                    if (Hydrant.GetComponent<TouchHitToggleHydrant>().HydrantHit == true)
                  
                        
                    {
                        if (hit.transform == this.transform)
                        {

                            for (int i = 0; i < Fire.Length; i++)
                            {
                                Fire[i].SetActive(false);
                            }
                        }

                    }

                   
                }
            }
        }
    }
}
