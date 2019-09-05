using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movescript : MonoBehaviour
{
    // script moves Player when camera moves

    public GameObject camera;
    private Vector3 startpos;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        startpos = camera.transform.position;
        anim =GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 activepos = camera.transform.position;
        if (activepos!=startpos)
        {
            Debug.Log("Camera Movement detected");
            anim.SetBool("move",true);
            startpos = activepos;
        }
        else
        {
            anim.SetBool("move", false);
        }
    }
}
