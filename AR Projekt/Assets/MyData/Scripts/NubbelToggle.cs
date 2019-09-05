using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NubbelToggle : MonoBehaviour
{
    public GameObject Fire;
    public GameObject Nubbel;
    public GameObject Nubbel2;
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
                if (hit.transform == this.transform)
                { 
                    if (Fire.activeSelf == false)

                    {
                        Nubbel.SetActive(false);
                        Invoke("Counter", 2f);
                    
                    
                    }

                }
            }
        }
    }
    private void Counter()
    {
        
        Nubbel2.SetActive(true);
    }
}
