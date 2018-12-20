using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOrbit : MonoBehaviour {
    // Variables
    public Transform lookAt;
    public Transform camTransform;
    private Camera cam;
    public float distance = -5.0f;
    private float curX = 0.0f;
    private float curY = 0.0f;
    private float senX = 4.0f;
    private float senY = 1.0f;

    private const float Y_ANGLE_MIN = -10.0f;
    private const float Y_ANGLE_MAX = 35.0f;

    public float DIS_MIN = -2.5f;
    public float DIS_MAX = -0.5f;

    public bool invertMouse;

    // Functions
    void Start()
    {
        camTransform = transform;
        cam = Camera.main;
        Cursor.lockState = CursorLockMode.Locked;
        
    }

    private void Update()
    {
        // check 
    }

    private void FixedUpdate()
    {
        curX += Input.GetAxis("Mouse X") * senX;
        if(invertMouse)
            curY += Input.GetAxis("Mouse Y") * -senY;
        else
            curY += Input.GetAxis("Mouse Y") * senY;

        distance += Input.GetAxis("Mouse ScrollWheel");

        curY = Mathf.Clamp(curY, Y_ANGLE_MIN, Y_ANGLE_MAX);
        distance = Mathf.Clamp(distance, DIS_MIN, DIS_MAX);
    }

    private void LateUpdate()
    {
        Vector3 dir = new Vector3(0, 0, distance);
        Quaternion rotation = Quaternion.Euler(curY, curX, 0);
        camTransform.position = lookAt.position + rotation * dir;

        camTransform.LookAt(lookAt.position);
    }

}
