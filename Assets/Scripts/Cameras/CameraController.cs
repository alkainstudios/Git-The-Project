using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    // Variables
    public Transform target;
    public float lookSmooth = 0.09f;
    public Vector3 offsetFromTarget = new Vector3(0, 6, 8);
    public float xTilt = 10;

    Vector3 destination = Vector3.zero;
    CharacterController cc;
    float rotateVel = 0;



    // Functions
    private void Start()
    {
        SetCameraTarget(target);
    }

    public void SetCameraTarget(Transform t)
    {
        // Set target for camera
        target = t;

        // Chaeck if target is available
        if (target != null)
        {
            if (target.GetComponent<CharacterController>())
            {
                cc = target.GetComponent<CharacterController>();
            }
            else
            {
                Debug.LogError("~ " + this.name + ": needs a Character Controller! ~");
            }
        }
        else
        {
            Debug.LogError("~ " + this.name + ": needs a target transform! ~");
        }
    }

    private void LateUpdate()
    {
        // Moving
        MoveToTarget();
        // Rotate
        LookAtTarget();
    }

    void MoveToTarget()
    {
        destination = cc.TargetRotation * offsetFromTarget;
        destination += target.position;
        transform.position = destination;
    }

    void LookAtTarget()
    {
        float eulerYAngle = Mathf.SmoothDampAngle(transform.eulerAngles.y, target.eulerAngles.y, ref rotateVel, lookSmooth);
        transform.rotation = Quaternion.Euler(transform.eulerAngles.x, eulerYAngle, 0);
    }

}
