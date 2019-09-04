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
        Screen.orientation = ScreenOrientation.LandscapeRight;
        Screen.autorotateToLandscapeLeft = true;
        Screen.autorotateToLandscapeRight = true;
        Screen.autorotateToPortrait = false;
        Screen.autorotateToPortraitUpsideDown = false;
        Screen.orientation = ScreenOrientation.AutoRotation;
        Vp.loopPointReached += EndReached;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void EndReached(VideoPlayer vp)
    {
        Screen.autorotateToPortrait = true;
        //Screen.autorotateToPortraitUpsideDown = true;
        Screen.orientation = ScreenOrientation.AutoRotation;
        SceneManager.LoadScene("StartScene");
    }
}
