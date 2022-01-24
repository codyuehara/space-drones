using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject currentDrone;
    public Vector3 offset;
    public float horizontalSpeed = 10f;
    public float verticalSpeed = 10f;
    public float rotateSpeed = 10f;

    // Update is called once per frame
    void FixedUpdate()
    {
        //this.transform.position = currentDrone.transform.position + offset;
        if (Input.GetMouseButtonDown(0)){
            Debug.Log("mouse click");
            transform.RotateAround(currentDrone.transform.position, transform.up, -Input.GetAxis("Mouse X") * rotateSpeed);
        }

    }

    void LateUpdate() {
        
    }
}
