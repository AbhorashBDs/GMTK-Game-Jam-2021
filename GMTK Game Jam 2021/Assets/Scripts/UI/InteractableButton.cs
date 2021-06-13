using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LaunchGame()
    {
        Debug.Log("launcher" + MGR_SceneManager.Instance.GetCurrentSceneIndex());
        MGR_SceneManager.Instance.LoadNextScene(MGR_SceneManager.Instance.GetCurrentSceneIndex());
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
