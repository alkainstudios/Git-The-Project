using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastTesting : MonoBehaviour {
    public int dis;
    Ray ray;
    RaycastHit hit;

	// Use this for initialization
	void Start () {
	}

    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        Debug.DrawRay(ray.origin, ray.direction * dis, Color.green);
    }
}
