using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class RayCastTesting : MonoBehaviour {

    public float dis;
    public Material hl;
    public string hl_Tag;

    Ray ray;
    RaycastHit hit;

    public float moveForce = 1.0F;
    public float rotateTorque = 1.0F;
    public float hoverHeight = 4.0F;
    public float hoverForce = 5.0F;
    public float hoverDamp = 0.5F;
    public Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.drag = 0.5F;
        rb.angularDrag = 0.5F;
    }

    void Update()
    {
        dis = Vector3.Distance(hit.transform.position, Camera.main.transform.position);

        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        Debug.DrawRay(ray.origin, ray.direction * Time.time, Color.green);

        if (hit.collider != null)
            Highlight();

    }

    void FixedUpdate()
    {
        if(this.GetComponent<Rigidbody>() != null)
        {
            ExampleRaycasting();
        }
    }

    void Highlight()
    {

        if (hit.collider.tag == hl_Tag)
            Debug.Log("You are " + dis + " from " + hit.collider.transform.position);


    }

    void ExampleRaycasting()
    {
        rb.AddForce(Input.GetAxis("Vertical") * moveForce * transform.forward);
        rb.AddTorque(Input.GetAxis("Horizontal") * rotateTorque * Vector3.up);
        RaycastHit hit;
        Ray downRay = new Ray(transform.position, -Vector3.up);
        if (Physics.Raycast(downRay, out hit))
        {
            float hoverError = hoverHeight - hit.distance;
            if (hoverError > 0)
            {
                float upwardSpeed = rb.velocity.y;
                float lift = hoverError * hoverForce - upwardSpeed * hoverDamp;
                rb.AddForce(lift * Vector3.up);
            }
        }
    }

}
