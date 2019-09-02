using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TatortBeweisItem : MonoBehaviour
{
    private GameObject player;
    public Material hitMaterial;
    public Item itemType;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Loader");
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
                    }

                    player.GetComponent<PlayerAR>().AddToInventory(itemType);
                    //player.GetComponent<PlayerAR>().AddToInventory(this.gameObject);
                    //Übergangslösung, die abhängig vom level des Spielers Objekte dem Inventar hinzufügt
                    player.GetComponent<PlayerAR>().AddLvl();

                    ARSceneManager[] managers = FindObjectsOfType<ARSceneManager>();
                    foreach (ARSceneManager arSceneManager in managers)
                    {
                        if (arSceneManager.gameObject.activeSelf)
                        {
                            arSceneManager.objectTapped(this.gameObject);
                        }
                    }
                }
            }
        }
    }
}
