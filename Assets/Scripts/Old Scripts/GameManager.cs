using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    // Variables
    public string playerLevel;

    // Use this for initialization
    void Start () {
        SceneManager.LoadScene(playerLevel, LoadSceneMode.Additive);
	}
}
