using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour {
    // Variables
    //CharacterController cc;
    public float moveVel, speed;
    public Quaternion targetRotation;

    // Function
    private void Start()
    {
        /*
        if (GetComponent<CharacterController>())
            cc = this.GetComponent<CharacterController>();
        else
            Debug.LogError(gameObject.name + ": needs a Character Controller Component!");

    */
    }

    private void Update()
    {
        moveVel = Input.GetAxis("Vertical");
        
        //cc.SimpleMove(Vector3.forward * moveVel * speed);
    }
}
