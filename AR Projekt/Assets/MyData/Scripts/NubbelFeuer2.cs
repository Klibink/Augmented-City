using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NubbelFeuer2 : MonoBehaviour
{
    public GameObject Hydrant;
    public GameObject[] Fire;
    public Material hitMaterial;

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
                    if (Hydrant.GetComponent<MeshRenderer>().material = hitMaterial)
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
