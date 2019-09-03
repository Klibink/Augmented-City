using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoLoadScene : MonoBehaviour
{
    // Start is called before the first frame update
    public VideoPlayer Vp;
    void Start()
    {
        Vp.loopPointReached += EndReached;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void EndReached(VideoPlayer vp)
    {
        SceneManager.LoadScene("StartScene");
    }
}
