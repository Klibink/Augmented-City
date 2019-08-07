using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ARSceneTransitionManager : Singleton<ARSceneTransitionManager>
{
    private AsyncOperation sceneAsync;

    public void GoToScene(string sceneName, List<GameObject> objectsToMove)
    {
        Scene scene = SceneManager.GetActiveScene();
        int count = scene.GetRootGameObjects().Length;
        string name = scene.GetRootGameObjects()[0].name;
        Debug.LogFormat("{0} root objects in Scene, first one called {1}", count, name);
        StartCoroutine(LoadScene(sceneName, objectsToMove));
    }

    private IEnumerator LoadScene(string sceneName, List<GameObject> objectsToMove)
    {
        SceneManager.LoadSceneAsync(sceneName);

        SceneManager.sceneLoaded += (newScene, mode) => {
            SceneManager.SetActiveScene(newScene);
        };

        Scene sceneToLoad = SceneManager.GetSceneByName(sceneName);
        foreach (GameObject obj in objectsToMove)
        {
            SceneManager.MoveGameObjectToScene(obj, sceneToLoad);
        }
        yield return null;
    }
}
