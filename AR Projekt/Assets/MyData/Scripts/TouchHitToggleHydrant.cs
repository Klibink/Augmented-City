using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchHitToggleHydrant : MonoBehaviour
{
   
    public Material hitMaterial;
    public bool HydrantHit;

    // Start is called before the first frame update
    void Start()
    {
        HydrantHit = false;
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
                    var rig = hit.collider.GetComponent<Rigidbody>();
                    if (rig != null)
                    {
                        rig.GetComponent<MeshRenderer>().material = hitMaterial;
                        HydrantHit = true;
                    }
                }
            }
        }
    }
}
