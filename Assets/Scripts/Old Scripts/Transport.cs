using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(BoxCollider))]
public class Transport : MonoBehaviour {
    public static Transport Instance { get; set; }


    // Variables \\
    public string scene;
    Scene sc;


	// Use this for initialization
	void Start () {
        
	}

    private void OnTriggerEnter(Collider col)
    {

    }

    
}
