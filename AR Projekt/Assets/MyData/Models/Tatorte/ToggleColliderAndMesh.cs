using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleColliderAndMesh : MonoBehaviour
{
    private GameObject player;

    public Renderer[] rend;
    public Collider collider;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Loader");
        rend = transform.GetComponentsInChildren<Renderer>();
        collider = transform.GetComponent<Collider>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.GetComponent<PlayerAR>().lvl == this.transform.GetComponent<Tatort>().tatortNummer)
        {
            foreach (Renderer r in rend)
            {
                r.enabled = true;
            }
            //rend.enabled = true;
            collider.enabled = true;
        }
        else
        {
            foreach (Renderer r in rend)
            {
                r.enabled = false;
            }
            //rend.enabled = false;
            collider.enabled = false;
        }


        /*
        switch (player.GetComponent<PlayerAR>().lvl)
        {
            case 0:
                if(player.GetComponent<PlayerAR>().lvl==this.transform.GetComponent<Tatort>().tatortNummer)
                foreach(Renderer r in rend)
                {
                    r.enabled = false;
                }
                //rend.enabled = false;
                collider.enabled = false;
                break;

            case 1:
                foreach (Renderer r in rend)
                {
                    r.enabled = true;
                }
                //rend.enabled = true;
                collider.enabled = true;

                break;

            case 2:


                break;

            case 3:


                break;

            default:

                break;
                

        }*/
    }
}
