using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TouchHitSceneLoad : MonoBehaviour
{
    private GameObject player;
    //public Material hitMaterial;
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
                if(hit.transform == this.transform)
                {

                    //player.GetComponent<PlayerAR>().AddToInventory(this.gameObject);
                    SceneManager.LoadScene("MapScene");
                }
            }
        }


        /*if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit))
            {
                Destroy(hit.transform);
            }
        }
        */
    }
}
