using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AddScene : MonoBehaviour
{
    // Variables
    public string newLevel;
    public string oldLevel;
    public Scene sceneMan;

    // Use this for initialization
    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(newLevel, LoadSceneMode.Additive);
    }
    private void OnTriggerExit(Collider other)
    {
        SceneManager.UnloadSceneAsync(oldLevel);
    }

}
